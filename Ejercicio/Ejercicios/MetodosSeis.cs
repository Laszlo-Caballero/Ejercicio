using Ejercicio.Database;
using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio.Ejercicios
{
    internal class MetodosSeis
    {

        private static Consultas consultas = new Consultas();
        public static string CodigoProducto()
        {
            SqlDataReader reader = consultas.Datos("select top 1 COD_PRO from TB_PRODUCTO order by COD_PRO desc");

            if (reader.Read())
            {
                string resultado = reader["COD_PRO"].ToString();
                int cod = int.Parse(resultado.Substring(1)) + 1;
                if (cod > 100)
                {
                    resultado = "P" + cod.ToString();
                }
                else if (cod > 10)
                {
                    resultado = "P0" + cod.ToString();
                }
                else
                {
                    resultado = "P00" + cod.ToString();
                }
                reader.Close();
                return resultado;
            }
            else
            {
                reader.Close();
                return "";
            }
        }

        public static bool Enviar(TextBox txtCod,TextBox txtNombre, TextBox txtPrecio,
            TextBox txtStockAct, TextBox txtStockMin, ComboBox cbUnidadMedida, RadioButton rbY)
        {
            string nombre = txtNombre.Text;
            float precio;
            int stockAct, stockMin;
            try
            {
                precio = float.Parse(txtPrecio.Text);
                stockAct = int.Parse(txtStockAct.Text);
                stockMin = int.Parse(txtStockMin.Text);
            }
            catch (Exception err)
            {
                MessageBox.Show("error al convertir los datos numericos");
                return false;
            }
            if (cbUnidadMedida.Text.Equals(""))
            {
                MessageBox.Show("Se necesita una unidad de medida");
                return false;
            }
            string unidad = cbUnidadMedida.Text;
            char importado = rbY.Checked ? 'V' : 'F';
            
            
            txtNombre.Clear();
            txtPrecio.Clear();
            txtStockAct.Clear();
            txtStockMin.Clear();
           
            
            string[] Datos = {txtCod.Text, nombre, precio.ToString(), stockAct.ToString(), stockMin.ToString(), unidad, importado.ToString()};
            string[] parametros = { "@COD", "@DESC", "@PRE", "@STK_ACT", "@STK_MIN", "@MED", "@IMP" };
            SqlDataReader result = consultas.execQuery("EXEC InsertarPro @COD, @DESC, @PRE, @STK_ACT, @STK_MIN, @MED, @IMP", parametros, Datos);
            MessageBox.Show(result.Read() ? "Se Inseto el Producto" : "Error al insertar Producto");
            return true;
        }

        public static void VerDatos(DataGridView tabla)
        {
            consultas.execQueryIntoTabla("Select * from TB_PRODUCTO", tabla, [], []);
        }
    }
}
