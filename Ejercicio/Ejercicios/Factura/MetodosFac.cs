using Ejercicio.Database;
using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio.Ejercicios.Factura
{
    internal class MetodosFac
    {

        private Consultas consultas = new Consultas();
        public void InsertaDatosCb(ComboBox cb)
        {
            cb.Items.Clear();
            SqlDataReader reader = consultas.execQuery("select * from TB_CLIENTE", [], []);
            while (reader.Read()) {
                cb.Items.Add(reader["COD_CLI"].ToString() + " " + reader["RAZ_SOC_CLI"].ToString());
            }
            reader.Close();
        }

        public void Factura(string fac, Label numfac, 
            DateTimePicker fecha, Label nombre, Label raz, 
            Label ruc, Label igv, ListView tabla, Label total)
        {
            SqlDataReader DF = consultas.execQuery("exec Datos_Fac @numfac", ["@numfac"], [fac]);

            if (DF.Read())
            {
                numfac.Text = DF["NUM_FAC"].ToString();
                string format = "d/MM/yyyy HH:mm:ss";
                fecha.Value = DateTime.ParseExact(DF["FEC_FAC"].ToString(), format, System.Globalization.CultureInfo.InvariantCulture);
                nombre.Text = DF["CONTACTO"].ToString();
                raz.Text = DF["RAZ_SOC_CLI"].ToString();
                ruc.Text = DF["RUC_CLI"].ToString();
                igv.Text = DF["PORC_IGV"].ToString();            
            }
            DF.Close();

            SqlDataReader Productos = consultas.execQuery("select P.DES_PRO, DF.CAN_VEN, DF.PRE_VEN  from TB_DETALLE_FACTURA DF inner join TB_PRODUCTO P on P.COD_PRO = DF.COD_PRO where DF.NUM_FAC = @numfac", ["@numfac"], [fac]);
            float totalPrecio = 0;
            while (Productos.Read()) 
            {
                int cantidad = int.Parse(Productos["CAN_VEN"].ToString());
                float precio = float.Parse(Productos["PRE_VEN"].ToString());
                ListViewItem fila = new ListViewItem(Productos["DES_PRO"].ToString());
                fila.SubItems.Add(cantidad.ToString());
                fila.SubItems.Add(precio.ToString());

                tabla.Items.Add(fila);
                totalPrecio += cantidad * precio;
            }
            Productos.Close();
            total.Text = totalPrecio.ToString();   
        }
    }
}
