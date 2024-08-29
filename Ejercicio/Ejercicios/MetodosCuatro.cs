using Ejercicio.Database;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio.Ejercicios
{
    internal class MetodosCuatro
    {
        private static Consultas consultas = new Consultas();

        public static void VerDatos(DataGridView grid)
        {
            consultas.execQueryIntoTabla("SELECT * FROM PROD_VENTA ORDER BY [VENTAS TOTALES]  DESC", grid, [], []);
        }

        public static bool Buscar(RadioButton rbP, RadioButton rbC, RadioButton rbM, TextBox txtBuscar, DataGridView grid)
        {
            if (txtBuscar.Text.Equals(""))
                return false;
            if (!rbP.Checked && !rbC.Checked && !rbM.Checked)
                return false;

            String criterio = rbP.Checked ? "Producto" : rbC.Checked ? "Cliente" : rbM.Checked ? "Mes" : "";
            string dato = txtBuscar.Text;
            string[] Datos = { dato, criterio };
            string[] Parametros = {"@dato", "@criterio" };

            consultas.execQueryCommandTabla("EXEC Busqueda @dato, @criterio", Parametros, Datos, grid);
            return true;
        }


        public static void Mostrar(RadioButton rbP, RadioButton rbC, RadioButton rbM, DataGridView grid)
        {
            String tabla = rbP.Checked ? "Producto" : rbC.Checked ? "Cliente" : rbM.Checked ? "Mes" : "";
            string[] Datos = { tabla };
            string[] Parametros = { "@tabla" };


            consultas.execQueryIntoTabla("EXEC Mostrar @tabla", grid, Parametros, Datos);
        }
    }
}
