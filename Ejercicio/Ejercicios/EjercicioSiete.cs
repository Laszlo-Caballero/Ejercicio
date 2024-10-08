﻿using Ejercicio.Database;
using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ejercicio.Ejercicios
{
    public partial class EjercicioSiete : Form
    {
        private Consultas consultas = new Consultas();
        private bool formLoaded = false;
        public EjercicioSiete()
        {
            InitializeComponent();
        }

        private void EjercicioOcho_Load(object sender, EventArgs e)
        {
            SqlCommand comando = new SqlCommand();
            DataTable tabla = new DataTable();
            SqlConnection conexion = CDatabase.getConexion();

            if (conexion != null)
            {
                comando.Connection = conexion;
                comando.CommandType = CommandType.Text;
                comando.CommandText = "select * from dbo.TB_PROVEEDOR";
                SqlDataAdapter adaptador = new SqlDataAdapter(comando);
                adaptador.Fill(tabla);

                // Se configura el Combobox
                cbProveedores.DataSource = tabla;
                cbProveedores.DisplayMember = "RAZ_SOC_PRV";
                cbProveedores.ValueMember = "COD_PRV";
                cbProveedores.SelectedIndex = -1;
                conexion.Close();
            }
            formLoaded = true;
        }

        private void cbProveedores_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (!formLoaded) return; // Se verifica si el formulario ha sido completamente cargado

            string codProveedor = cbProveedores.SelectedValue.ToString();

            // Se configura la consulta y los parámetros
            string query = "SELECT * FROM dbo.TB_ORDEN_COMPRA WHERE COD_PRV = @COD_PRV";
            string[] parametros = { "@COD_PRV" };
            string[] datosParametros = { codProveedor };

            // Se llama al método para consultar y llenar el Data
            consultas.execQueryIntoTabla(query, dgvOrdenCompra, parametros, datosParametros);

            // Se muestra el mensaje
            MessageBox.Show("Número de órdenes de compra: " + dgvOrdenCompra.Rows.Count);
        }

        private void dgvOrdenCompra_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            // Se verifica que el clic no sea en el encabezado
            if (e.RowIndex >= 0)
            {
                // Obtiene el número de la orden de compra q se selecciona
                string numOco = dgvOrdenCompra.Rows[e.RowIndex].Cells["NUM_OCO"].Value.ToString();

                // Se hace la consulta para obtener los detalles de los productos asociados a la orden de compra
                string query = "SELECT P.COD_PRO, P.DES_PRO, D.CAN_PED, P.PRE_PRO " +
                               "FROM dbo.TB_DETALLE_COMPRA D " +
                               "INNER JOIN dbo.TB_PRODUCTO P ON D.COD_PRO = P.COD_PRO " +
                               "WHERE D.NUM_OCO = @NUM_OCO";
                string[] parametros = { "@NUM_OCO" };
                string[] datosParametros = { numOco };

                // Se llama al método para consultar y llenar el segundo Data
                consultas.execQueryIntoTabla(query, dgvProductos, parametros, datosParametros);

                // Se verifica cuántas filas fueron recuperadas y se muestra el mensaje
                MessageBox.Show("Número de productos: " + dgvProductos.Rows.Count);
            }
        }

        private void btnVerEstado_Click(object sender, EventArgs e)
        {
            string numeroOrden = txtOrdenCompra.Text.Trim();

            if (string.IsNullOrEmpty(numeroOrden))
            {
                MessageBox.Show("Por favor, ingrese el número de orden de compra.");
                return;
            }

            try
            {
                string query = "SELECT EST_OCO FROM dbo.TB_ORDEN_COMPRA WHERE NUM_OCO = @NUM_OCO";
                string[] parametros = { "@NUM_OCO" };
                string[] datosParametros = { numeroOrden };

                SqlDataReader reader = consultas.execQuery(query, parametros, datosParametros);

                if (reader != null && reader.Read())
                {
                    string estado = reader["EST_OCO"].ToString();
                    string mensaje;

                    if (estado == "1")
                    {
                        mensaje = "La orden de compra está *pendiente*.";
                    }
                    else if (estado == "2")
                    {
                        mensaje = "La orden de compra está *procesada*.";
                    }
                    else if (estado == "3")
                    {
                        mensaje = "La orden de compra está *completada*.";
                    }
                    else
                    {
                        mensaje = "No se conoce su estado.";
                    }

                    MessageBox.Show(mensaje);
                }
                else
                {
                    MessageBox.Show("No se encontró la orden de compra.");
                }

                reader?.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error " + ex.Message);
            }
        }
    }
}
