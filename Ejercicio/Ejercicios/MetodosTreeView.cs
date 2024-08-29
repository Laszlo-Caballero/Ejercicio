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
            treeView.Nodes.Clear();

            List<string> clientes = new List<string>();
            List<string> codCli = new List<string>();
            SqlDataReader clienteReader = consultas.execQuery("SELECT * FROM TB_CLIENTE", [], []);
            while (clienteReader.Read()) {
                clientes.Add(clienteReader["CONTACTO"].ToString());
                codCli.Add(clienteReader["COD_CLI"].ToString());
            }
            clienteReader.Close();

            for (int i = 0; i < clientes.Count; i++)
            {

                TreeNode clienteNode = new TreeNode(clientes[i]);
                SqlDataReader facturaReader = consultas.execQuery($"SELECT * FROM TB_FACTURA WHERE COD_CLI = @clienteId",
                                                                    new string[] { "@clienteId" }, new string[] { codCli[i] });

                while (facturaReader.Read())
                {
                    // Crear nodo para cada factura
                    TreeNode facturaNode = new TreeNode($"Factura {facturaReader["NUM_FAC"]}: {facturaReader["FEC_FAC"].ToString()}");
                    clienteNode.Nodes.Add(facturaNode);
                }
                facturaReader.Close();

                // Agregar el nodo del cliente al TreeView
                treeView.Nodes.Add(clienteNode);
            }

        }
        }

    }

