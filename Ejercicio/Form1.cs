using Ejercicio.Ejercicios;
using Ejercicio.Ejercicios.Factura;
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
            EjercicioFac ejercicioFac = new EjercicioFac();
            ejercicioFac.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            EjercicioTres ejerciciotres = new EjercicioTres();
            ejerciciotres.Show();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            EjercicioCuatro ejercicioCuatro = new EjercicioCuatro();
            ejercicioCuatro.Show();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            EjercicioCinco ejercicioCinco = new EjercicioCinco();
            ejercicioCinco.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            EjercicioSiete ejercicioSiete = new EjercicioSiete();   
            ejercicioSiete.Show();
        }
    }
}
