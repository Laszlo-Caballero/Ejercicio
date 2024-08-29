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
    public partial class EjercicioCuatro : Form
    {
        public EjercicioCuatro()
        {
            InitializeComponent();
            MetodosCuatro.VerDatos(datosTabla);

        }

        private void btnMostrar_Click(object sender, EventArgs e)
        {
            MetodosCuatro.Mostrar(rbtProducto, rbtCliente, rbtMes, datosTabla);
        }

        private void btnBusqueda_Click(object sender, EventArgs e)
        {
            bool result = MetodosCuatro.Buscar(rdBProducto, rdBCliente, rdBMes, txtBuscar, datosTabla);
            if (!result)
                MessageBox.Show("Complete los datos necesarios para la busqueda");
        }
    }
}
