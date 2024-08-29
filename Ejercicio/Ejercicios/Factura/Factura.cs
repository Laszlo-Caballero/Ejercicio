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
    public partial class Factura : Form
    {
        private MetodosFac metodos = new MetodosFac();
        public Factura(string cod)
        {
            InitializeComponent();
            metodos.Factura(cod, lblNum, dtFecha, lblNombre, lblRazon, lblRuc, lblIgv, tabla, lblTotal);
        }
    }
}
