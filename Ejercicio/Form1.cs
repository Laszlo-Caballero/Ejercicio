using Ejercicio.Ejercicios;
using Ejercicio.Database;
namespace Ejercicio
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btn1_Click(object sender, EventArgs e)
        {
            EjercicioUno ejercicioUno = new EjercicioUno();
            ejercicioUno.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            EjercicioDos ejercicioDos = new EjercicioDos();
            ejercicioDos.Show();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            EjercicioSeis ejercicioSeis = new EjercicioSeis();
            ejercicioSeis.Show();
        }

        private void btnEjercicio8_Click(object sender, EventArgs e)
        {
            EjercicioOcho ejercicioOcho = new EjercicioOcho();
            ejercicioOcho.Show();
        }
    }
}
