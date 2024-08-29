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
    public partial class EjercicioOcho : Form
    {
        private Consultas consultas = new Consultas();
        private bool formLoaded = false;
        public EjercicioOcho()
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

                // Se configura el ComboBox1
                cbProveedores.DataSource = tabla;
                cbProveedores.DisplayMember = "RAZ_SOC_PRV";
                cbProveedores.ValueMember = "COD_PRV";
                cbProveedores.SelectedIndex = -1;
                // Cerrar la conexión después de usarla
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

            // Verificar cuántas filas fueron recuperadas
            MessageBox.Show("Número de órdenes de compra: " + dgvOrdenCompra.Rows.Count);
        }

        private void dgvOrdenCompra_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            // Verifica que el clic no sea en el encabezado
            if (e.RowIndex >= 0)
            {
                // Obtiene el número de la orden de compra seleccionada
                string numOco = dgvOrdenCompra.Rows[e.RowIndex].Cells["NUM_OCO"].Value.ToString();

                // Configura la consulta para obtener los detalles de los productos asociados a la orden de compra
                string query = "SELECT P.COD_PRO, P.DES_PRO, D.CAN_PED, P.PRE_PRO " +
                               "FROM dbo.TB_DETALLE_COMPRA D " +
                               "INNER JOIN dbo.TB_PRODUCTO P ON D.COD_PRO = P.COD_PRO " +
                               "WHERE D.NUM_OCO = @NUM_OCO";
                string[] parametros = { "@NUM_OCO" };
                string[] datosParametros = { numOco };

                // Llama al método para consultar y llenar el segundo DataGridView
                consultas.execQueryIntoTabla(query, dgvProductos, parametros, datosParametros);

                // Verificar cuántas filas fueron recuperadas
                MessageBox.Show("Número de productos: " + dgvProductos.Rows.Count);
            }
        }
    }
}
