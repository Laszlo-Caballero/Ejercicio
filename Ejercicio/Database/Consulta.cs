using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio.Database
{
    internal class Consultas
    {
        private SqlConnection conexion = CDatabase.getConexion();
        public void Consultar(string query, DataGridView tabla, String[] parametros, String[] Datosparametros)
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
                conexion.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        public SqlDataReader Datos(string query)
        {
            SqlCommand command = new SqlCommand(query, conexion);
            try
            {
                SqlDataReader reader = command.ExecuteReader();
                return reader;
            }
            catch (SqlException ex)
            {
                MessageBox.Show(ex.ToString());
                return null;
            }
        }
    }
}
