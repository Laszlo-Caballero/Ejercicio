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
    public partial class EjercicioUno : Form
    {
        private Consultas consultas = new Consultas();
        private bool formLoaded = false;
        public EjercicioUno()
        {
            InitializeComponent();
        }

        private void EjercicioUno_Load(object sender, EventArgs e)
        {
            SqlCommand comando = new SqlCommand();
            DataTable tabla = new DataTable();
            DataTable tabla2 = new DataTable();
            SqlConnection conexion = CDatabase.getConexion();

            if (conexion != null)
            {
                comando.Connection = conexion;
                comando.CommandType = CommandType.Text;
                comando.CommandText = "select * from dbo.TB_DISTRITO";
                SqlDataAdapter adaptador = new SqlDataAdapter(comando);
                adaptador.Fill(tabla);
                adaptador.Fill(tabla2);

                // Se configura el ComboBox1
                cbDistritos.DataSource = tabla;
                cbDistritos.DisplayMember = "NOM_DIS";
                cbDistritos.ValueMember = "COD_DIS";
                cbDistritos.SelectedIndex = -1;
                // Se configura el ComboBox2
                cbDistritosNV.DataSource = tabla2;
                cbDistritosNV.DisplayMember = "NOM_DIS";
                cbDistritosNV.ValueMember = "COD_DIS";

                conexion.Close();
            }
            formLoaded = true;
        }

        private void cbDistritos_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (!formLoaded) return; // Cuando el formulario esté completamente cargado se va a mostrar los datos

            string codDistrito = cbDistritos.SelectedValue.ToString();

            // Seonfigura la consulta y los parámetros
            string query = "SELECT * FROM dbo.TB_VENDEDOR WHERE COD_DIS = @COD_DIS";
            string[] parametros = { "@COD_DIS" };
            string[] datosParametros = { codDistrito };

            // Llama al método consultar para llenar el Data
            consultas.execQueryIntoTabla(query, dataGridViewVendedores, parametros, datosParametros);

            // Se verifica cuantas filas se recuperaron y se muestra el mensaje
            MessageBox.Show("Número de vendedores: " + dataGridViewVendedores.Rows.Count);
        }

        private void btnVerSueldo_Click(object sender, EventArgs e)
        {
            string nombre = txtNombreVendedor.Text.Trim();
            string apellido = txtApellidoVendedor.Text.Trim();

            if (string.IsNullOrEmpty(nombre) || string.IsNullOrEmpty(apellido))
            {
                MessageBox.Show("Por favor, ingrese el nombre y apellido del vendedor.");
                return;
            }

            try
            {
                SqlConnection conexion = CDatabase.getConexion();
                SqlCommand comando = new SqlCommand("SELECT SUELDO_VEN FROM dbo.TB_VENDEDOR WHERE NOM_VEN = @NOM_VEN AND APE_VEN = @APE_VEN", conexion);
                comando.Parameters.AddWithValue("@NOM_VEN", nombre);
                comando.Parameters.AddWithValue("@APE_VEN", apellido);

                object resultado = comando.ExecuteScalar();

                if (resultado != null)
                {
                    decimal sueldo = Convert.ToDecimal(resultado);
                    MessageBox.Show($"El sueldo del vendedor {nombre} {apellido} es: {sueldo:C2}");
                }
                else
                {
                    MessageBox.Show("No se encontró el vendedor.");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ocurrió un error al obtener el sueldo: " + ex.Message);
            }
        }

        private void btnIngresar_Click(object sender, EventArgs e)
        {
            // Se verifica si todos los campos están completos
            if (string.IsNullOrWhiteSpace(txtNombre.Text) || string.IsNullOrWhiteSpace(txtApellido.Text) || string.IsNullOrWhiteSpace(txtSueldo.Text) || cbTV.SelectedIndex == -1 || cbDistritosNV.SelectedIndex == -1)
            {
                MessageBox.Show("Es necesario que complete todos los campos.");
                return;
            }

            SqlConnection conexion = CDatabase.getConexion();
            try
            {
                // Se obtiene el valor del tipo de vendedor seleccionado
                string tipoVen = cbTV.SelectedItem.ToString() == "Interno" ? "1" : "2";

                // Se genera el código del vendedor 
                string codigoVendedor = GenerarCodigoVendedor(conexion);

                // Se obtiene el código del distrito seleccionado
                string codigoDistrito = cbDistritosNV.SelectedValue.ToString();

                // Query para insertar datos
                string query = "INSERT INTO dbo.TB_VENDEDOR (COD_VEN, NOM_VEN, APE_VEN, SUELDO_VEN, FEC_ING, TIP_VEN, COD_DIS) " +
                               "VALUES (@COD_VEN, @NOM_VEN, @APE_VEN, @SUELDO_VEN, @FEC_ING, @TIP_VEN, @COD_DIS)";

                SqlCommand cmd = new SqlCommand(query, conexion);
                cmd.Parameters.AddWithValue("@COD_VEN", codigoVendedor); // Código generado automáticamente
                cmd.Parameters.AddWithValue("@NOM_VEN", txtNombre.Text);
                cmd.Parameters.AddWithValue("@APE_VEN", txtApellido.Text);
                cmd.Parameters.AddWithValue("@SUELDO_VEN", decimal.Parse(txtSueldo.Text)); // Convertir a decimal 
                cmd.Parameters.AddWithValue("@FEC_ING", dtpFechaIngreso.Value); // Se obtiene la fecha del DateTimePicker
                cmd.Parameters.AddWithValue("@TIP_VEN", tipoVen);
                cmd.Parameters.AddWithValue("@COD_DIS", codigoDistrito); // Código del distrito seleccionado

                cmd.ExecuteNonQuery();

                MessageBox.Show("Datos ingresados correctamente.");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al insertar los datos: " + ex.Message);
            }
            finally
            {
                conexion.Close();
            }
        }
        private string GenerarCodigoVendedor(SqlConnection conexion)
        {
            // Acá se obtiene el último código insertado
            string query = "SELECT TOP 1 COD_VEN FROM dbo.TB_VENDEDOR ORDER BY COD_VEN DESC";
            SqlCommand comando = new SqlCommand(query, conexion);

            object resultado = comando.ExecuteScalar();

            // Se genera el nuevo código
            if (resultado != null)
            {
                string ultimoCodigo = resultado.ToString();
                int numero = int.Parse(ultimoCodigo.Substring(1)) + 1;
                return "V" + numero.ToString("D2"); // Formato como: V01, V02, etc.
            }
            else
            {
                return "V01"; // Primer código
            }

        }
    }
}
