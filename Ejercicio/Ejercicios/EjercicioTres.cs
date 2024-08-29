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
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Button;

namespace Ejercicio.Ejercicios
{
    public partial class EjercicioTres : Form
    {
        public EjercicioTres()
        {
            InitializeComponent();
        }
        SqlConnection conexion = CDatabase.getConexion();

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void EjercicioTres_Load(object sender, EventArgs e)
        {



            try
            {
                string query = "SELECT COD_VEN FROM TB_VENDEDOR";
                SqlCommand cmd = new SqlCommand(query, conexion);
                SqlDataReader reader = cmd.ExecuteReader();

                while (reader.Read())
                {
                    CBVendedor.Items.Add(reader["COD_VEN"].ToString());
                }

                reader.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al cargar los datos: " + ex.Message);
            }

        }

        private void CBVendedor_SelectedIndexChanged(object sender, EventArgs e)
        {
            string selectedCodigo = CBVendedor.SelectedItem.ToString();



            try
            {
                string query = $"SELECT NOM_VEN, APE_VEN, SUELDO_VEN, FEC_ING, TIP_VEN, COD_DIS FROM TB_VENDEDOR WHERE COD_VEN = @codVen";
                SqlCommand cmd = new SqlCommand(query, conexion);
                cmd.Parameters.AddWithValue("@codVen", selectedCodigo);
                SqlDataReader reader = cmd.ExecuteReader();

                if (reader.Read())
                {
                    txtNombre.Text = reader["NOM_VEN"].ToString();
                    txtApellido.Text = reader["APE_VEN"].ToString();
                    txtSueldo.Text = reader["SUELDO_VEN"].ToString();
                    DTP1.Value = DateTime.Parse(reader["FEC_ING"].ToString());


                    // Configurar los CheckBoxes según el tipo de vendedor
                    if (reader["TIP_VEN"].ToString() == "1")
                    {
                        CB1.Checked = true;
                        CB2.Checked = false;
                    }
                    else if (reader["TIP_VEN"].ToString() == "2")
                    {
                        CB1.Checked = false;
                        CB2.Checked = true;
                    }

                    txtCodigo.Text = reader["COD_DIS"].ToString();
                }

                reader.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al consultar los datos: " + ex.Message);
            }

        }

        private void CB1_CheckedChanged(object sender, EventArgs e)
        {

        }
    }
}
