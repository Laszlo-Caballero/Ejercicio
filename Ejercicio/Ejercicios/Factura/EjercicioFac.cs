using Ejercicio.Database;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ejercicio.Ejercicios.Factura
{
    public partial class EjercicioFac : Form
    {
        private MetodosFac metodosFac = new MetodosFac();
        private Consultas consultas = new Consultas();
        public EjercicioFac()
        {
            InitializeComponent();
            metodosFac.InsertaDatosCb(cbCliente);
        }

        private void cbCliente_SelectedIndexChanged(object sender, EventArgs e)
        {
            string cod = cbCliente.Text.Split(" ")[0];

            consultas.execQueryIntoTabla("select * from TB_FACTURA where COD_CLI = @cod"
                , tabla, ["@cod"], [cod]);

        }

        private void tabla_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if(e.RowIndex >= 0)
            {
                DataGridViewRow selected = tabla.Rows[e.RowIndex];

                string num_fac = selected.Cells["NUM_FAC"].Value.ToString();
                Factura fac = new Factura(num_fac);
                fac.Show();
            }
        }
    }
}
