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
    public partial class EjercicioSeis : Form
    {
        public EjercicioSeis()
        {
            InitializeComponent();
            txtCod.Text = MetodosSeis.CodigoProducto();
            MetodosSeis.VerDatos(tabla);
        }

        private void btnEnviar_Click(object sender, EventArgs e)
        {
            bool result = MetodosSeis.Enviar(txtCod, txtNombre, txtPrecio, txtStockAct, txtStockMin, cbUnidadMedida, rbY);
            if (result)
            {
                MetodosSeis.VerDatos(tabla);
                txtCod.Text = MetodosSeis.CodigoProducto();
            }
        }
    }
}
