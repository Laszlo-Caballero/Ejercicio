using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Ejercicio.Database
{
    internal class Consultas
    {
        private SqlConnection conexion = CDatabase.getConexion();
        public void execQueryIntoTabla(string query, DataGridView tabla, string[] parametros, string[] Datosparametros)
        {
            try
            {
                SqlDataAdapter adapter;
                if (parametros.Length > 0 && Datosparametros.Length > 0)
                {
                    adapter = new SqlDataAdapter();
                    SqlCommand command = new SqlCommand(query, conexion);
                    for (int i = 0; i < parametros.Length; i++)
                    {
                        command.Parameters.AddWithValue(parametros[i], Datosparametros[i]);
                    }
                    adapter.SelectCommand = command;
                }
                else
                {
                    adapter = new SqlDataAdapter(query, conexion);
                }
                DataTable datable = new DataTable();
                adapter.Fill(datable);
                tabla.DataSource = datable;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        public SqlDataReader execQuery(string query, string[] parametros, string[] datos)
        {
            try
            {
                SqlCommand command;
                if (parametros.Length > 0 && datos.Length > 0)
                {
                    command = new SqlCommand(query, conexion);
                    for (int i = 0; i < parametros.Length; i++)
                    {
                        command.Parameters.AddWithValue(parametros[i], datos[i]);
                    }
                }
                else
                {
                    command = new SqlCommand(query, conexion);
                }

                SqlDataReader reader = command.ExecuteReader();

                return reader;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
                return null;
            }
        }
        
    }
}
