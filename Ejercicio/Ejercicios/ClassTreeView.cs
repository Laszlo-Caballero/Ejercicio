using Ejercicio.Database;
using Microsoft.Data.SqlClient;
using System.Windows.Forms;

namespace Ejercicio.Ejercicios
{
    internal class MetodosTreeView
    {
        private static Consultas consultas = new Consultas();

        public static void CargarDatos(TreeView treeView)
        {
            // Limpia el TreeView antes de cargar nuevos datos
            treeView.Nodes.Clear();

            // Cargar Clientes
            using (SqlDataReader clienteReader = consultas.execQuery("SELECT * FROM TB_CLIENTE", [], []))
            {
                while (clienteReader.Read())
                {
                    // Crear nodo para cada cliente
                    TreeNode clienteNode = new TreeNode(clienteReader["CONTACTO"].ToString());
                    string clienteId = clienteReader["COD_CLI"].ToString();

                    // Cargar Facturas para cada cliente
                    using (SqlDataReader facturaReader = consultas.execQuery($"SELECT * FROM TB_FACTURA WHERE COD_CLI = '{clienteId}'", [], []))
                    {clienteReader.Close(); 
                        while (facturaReader.Read())
                        {
                            // Crear nodo para cada factura
                            TreeNode facturaNode = new TreeNode($"Factura {facturaReader["NUM_FAC"]}: {facturaReader["FEC_FAC"].ToString()}");
                            clienteNode.Nodes.Add(facturaNode);
                        }
                        facturaReader.Close();
                    }

                    // Agregar el nodo del cliente al TreeView
                    treeView.Nodes.Add(clienteNode);
                }
                clienteReader.Close();
            }
        }
    }
}

