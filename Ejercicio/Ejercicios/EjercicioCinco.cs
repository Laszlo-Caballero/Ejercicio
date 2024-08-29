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
    public partial class EjercicioCinco : Form
    {
        public EjercicioCinco()
        {
            InitializeComponent();
        }

        private void EjercicioCinco_Load(object sender, EventArgs e)
        {
            MetodosTreeView.CargarDatos(treeView);
        }

        private void treeView_AfterSelect(object sender, TreeViewEventArgs e)
        {

        }
    }
}
