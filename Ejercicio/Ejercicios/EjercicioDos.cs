using Ejercicio.Database;
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
    public partial class EjercicioDos : Form
    {
        public EjercicioDos()
        {
            InitializeComponent();
            LlenarListBoxClientes();
        }
        // Llenar listBoxClientes con los códigos de clientes
        private void LlenarListBoxClientes()
        {
            try
            {
                SqlConnection conexion = CDatabase.getConexion();
                {
                    SqlCommand command = new SqlCommand("SELECT COD_CLI FROM TB_CLIENTE", conexion);
                    SqlDataReader reader = command.ExecuteReader();

                    while (reader.Read())
                    {
                        listBoxClientes.Items.Add(reader["COD_CLI"].ToString());
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al cargar los clientes: " + ex.Message);
            }
        }
        private void EjercicioDos_Load(object sender, EventArgs e)
        {

        }

        private void listBoxClientes_SelectedIndexChanged(object sender, EventArgs e)
        {
            listBoxFacturas.Items.Clear();
            string selectedClient = listBoxClientes.SelectedItem.ToString();
            MostrarRazonSocial(selectedClient);
            LlenarListBoxFacturas(selectedClient);

        }

        // Método para mostrar cliente seleccionado
        private void MostrarRazonSocial(string cliente)
        {
            try
            {
                SqlConnection conexion = CDatabase.getConexion();
                string query = "SELECT RAZ_SOC_CLI FROM TB_CLIENTE WHERE COD_CLI = @COD_CLI";

                SqlCommand command = new SqlCommand(query, conexion);
                command.Parameters.AddWithValue("@COD_CLI", cliente);

                SqlDataReader reader = command.ExecuteReader();

                if (reader.Read())
                {
                    string razonSocial = reader["RAZ_SOC_CLI"].ToString();
                    MessageBox.Show($"Cliente Seleccionado: {razonSocial}", "Información del Cliente", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("Cliente seleccionado no encontrado.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al cargar el cliente seleccionado: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        // Llenar listBoxFacturas con las facturas del cliente seleccionado
        private void LlenarListBoxFacturas(string cliente)
        {
            try
            {
                SqlConnection conexion = CDatabase.getConexion();
                {
                    SqlCommand command = new SqlCommand("SELECT NUM_FAC FROM TB_FACTURA WHERE COD_CLI = @COD_CLI", conexion);
                    command.Parameters.AddWithValue("@COD_CLI", cliente);
                    SqlDataReader reader = command.ExecuteReader();

                    while (reader.Read())
                    {
                        listBoxFacturas.Items.Add(reader["NUM_FAC"].ToString());
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al cargar las facturas: " + ex.Message);
            }
        }

        private void buttonVerDetalles_Click(object sender, EventArgs e)
        {
            if (listBoxClientes.SelectedItem == null)
            {
                MessageBox.Show("Por favor, selecciona un cliente.", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (listBoxFacturas.SelectedItem == null)
            {
                MessageBox.Show("Por favor, selecciona una factura.", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            string selectedInvoice = listBoxFacturas.SelectedItem.ToString();
            MostrarDetalleFactura(selectedInvoice);
        }
        // Función para mostrar los detalles de la factura utilizando la clase Consultas
        private void MostrarDetalleFactura(string factura)
        {
            try
            {
                // Crea la instancia de la clase Consultas
                Consultas consultas = new Consultas();

                // Crea la consulta
                string query = "SELECT D.COD_PRO, D.CAN_VEN, D.PRE_VEN FROM TB_DETALLE_FACTURA D WHERE D.NUM_FAC = @NUM_FAC";

                // Parámetros para la consulta
                string[] parametros = { "@NUM_FAC" };
                string[] datos = { factura };

                // Ejecuta la consulta
                SqlDataReader reader = consultas.execQuery(query, parametros, datos);

                if (reader != null && reader.HasRows)
                {
                    string detalles = "Detalles de la Factura:\r\n";
                    while (reader.Read())
                    {
                        detalles += $"Producto: {reader["COD_PRO"]}  -  Cantidad: {reader["CAN_VEN"]} -  Precio: {reader["PRE_VEN"]}\r\n";
                    }
                    textBoxResumenFacturas.Text = detalles;
                }
                else
                {
                    MessageBox.Show("No se encontraron detalles para la factura seleccionada.", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }

                // Asegúrate de cerrar el reader después de usarlo
                if (reader != null) reader.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al mostrar los detalles de la factura: " + ex.Message);
            }
        }
    }

}

