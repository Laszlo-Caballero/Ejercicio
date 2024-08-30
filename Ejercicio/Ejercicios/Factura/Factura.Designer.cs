namespace Ejercicio.Ejercicios.Factura
{
    partial class Factura
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            label1 = new Label();
            label2 = new Label();
            lblNum = new Label();
            label3 = new Label();
            dtFecha = new DateTimePicker();
            lbl = new Label();
            lblNombre = new Label();
            label4 = new Label();
            lblRuc = new Label();
            label5 = new Label();
            lblRazon = new Label();
            tabla = new ListView();
            Nombre = new ColumnHeader();
            Cantidad = new ColumnHeader();
            Precio = new ColumnHeader();
            label6 = new Label();
            label7 = new Label();
            lblIgv = new Label();
            label8 = new Label();
            lblTotal = new Label();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 15F);
            label1.Location = new Point(400, 14);
            label1.Margin = new Padding(5, 0, 5, 0);
            label1.Name = "label1";
            label1.Size = new Size(151, 54);
            label1.TabIndex = 0;
            label1.Text = "Factura";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 12F);
            label2.Location = new Point(94, 86);
            label2.Margin = new Padding(5, 0, 5, 0);
            label2.Name = "label2";
            label2.Size = new Size(255, 45);
            label2.TabIndex = 1;
            label2.Text = "Numero Factura:";
            // 
            // lblNum
            // 
            lblNum.AutoSize = true;
            lblNum.Location = new Point(358, 98);
            lblNum.Margin = new Padding(5, 0, 5, 0);
            lblNum.Name = "lblNum";
            lblNum.Size = new Size(27, 32);
            lblNum.TabIndex = 2;
            lblNum.Text = "0";
            lblNum.TextAlign = ContentAlignment.TopCenter;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(499, 98);
            label3.Margin = new Padding(5, 0, 5, 0);
            label3.Name = "label3";
            label3.Size = new Size(0, 32);
            label3.TabIndex = 3;
            // 
            // dtFecha
            // 
            dtFecha.Enabled = false;
            dtFecha.Location = new Point(509, 98);
            dtFecha.Margin = new Padding(5, 5, 5, 5);
            dtFecha.Name = "dtFecha";
            dtFecha.Size = new Size(464, 39);
            dtFecha.TabIndex = 4;
            // 
            // lbl
            // 
            lbl.AutoSize = true;
            lbl.Font = new Font("Segoe UI", 12F);
            lbl.Location = new Point(94, 179);
            lbl.Margin = new Padding(5, 0, 5, 0);
            lbl.Name = "lbl";
            lbl.Size = new Size(145, 45);
            lbl.TabIndex = 5;
            lbl.Text = "Nombre:";
            // 
            // lblNombre
            // 
            lblNombre.AutoSize = true;
            lblNombre.Location = new Point(249, 190);
            lblNombre.Margin = new Padding(5, 0, 5, 0);
            lblNombre.Name = "lblNombre";
            lblNombre.Size = new Size(28, 32);
            lblNombre.TabIndex = 6;
            lblNombre.Text = "n";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 12F);
            label4.Location = new Point(94, 259);
            label4.Margin = new Padding(5, 0, 5, 0);
            label4.Name = "label4";
            label4.Size = new Size(79, 45);
            label4.TabIndex = 7;
            label4.Text = "Ruc:";
            // 
            // lblRuc
            // 
            lblRuc.AutoSize = true;
            lblRuc.Location = new Point(182, 270);
            lblRuc.Margin = new Padding(5, 0, 5, 0);
            lblRuc.Name = "lblRuc";
            lblRuc.Size = new Size(27, 32);
            lblRuc.TabIndex = 8;
            lblRuc.Text = "0";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 12F);
            label5.Location = new Point(499, 190);
            label5.Margin = new Padding(5, 0, 5, 0);
            label5.Name = "label5";
            label5.Size = new Size(205, 45);
            label5.TabIndex = 9;
            label5.Text = "Razon Social:";
            // 
            // lblRazon
            // 
            lblRazon.AutoSize = true;
            lblRazon.Location = new Point(725, 202);
            lblRazon.Margin = new Padding(5, 0, 5, 0);
            lblRazon.Name = "lblRazon";
            lblRazon.Size = new Size(28, 32);
            lblRazon.TabIndex = 10;
            lblRazon.Text = "n";
            // 
            // tabla
            // 
            tabla.Columns.AddRange(new ColumnHeader[] { Nombre, Cantidad, Precio });
            tabla.Location = new Point(94, 470);
            tabla.Margin = new Padding(5, 5, 5, 5);
            tabla.Name = "tabla";
            tabla.Size = new Size(818, 324);
            tabla.TabIndex = 11;
            tabla.UseCompatibleStateImageBehavior = false;
            tabla.View = View.Details;
            // 
            // Nombre
            // 
            Nombre.Text = "Nombre";
            Nombre.Width = 300;
            // 
            // Cantidad
            // 
            Cantidad.Text = "Cantidad";
            Cantidad.Width = 80;
            // 
            // Precio
            // 
            Precio.Text = "Precio";
            Precio.Width = 80;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 15F);
            label6.Location = new Point(94, 381);
            label6.Margin = new Padding(5, 0, 5, 0);
            label6.Name = "label6";
            label6.Size = new Size(416, 54);
            label6.TabIndex = 12;
            label6.Text = "Productos Comprados";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI", 12F);
            label7.Location = new Point(499, 270);
            label7.Margin = new Padding(5, 0, 5, 0);
            label7.Name = "label7";
            label7.Size = new Size(244, 45);
            label7.TabIndex = 13;
            label7.Text = "Porecentaje igv:";
            // 
            // lblIgv
            // 
            lblIgv.AutoSize = true;
            lblIgv.Location = new Point(751, 283);
            lblIgv.Margin = new Padding(5, 0, 5, 0);
            lblIgv.Name = "lblIgv";
            lblIgv.Size = new Size(27, 32);
            lblIgv.TabIndex = 14;
            lblIgv.Text = "0";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Segoe UI", 15F);
            label8.Location = new Point(94, 885);
            label8.Margin = new Padding(5, 0, 5, 0);
            label8.Name = "label8";
            label8.Size = new Size(260, 54);
            label8.TabIndex = 15;
            label8.Text = "Total a pagar:";
            // 
            // lblTotal
            // 
            lblTotal.AutoSize = true;
            lblTotal.Location = new Point(372, 904);
            lblTotal.Margin = new Padding(5, 0, 5, 0);
            lblTotal.Name = "lblTotal";
            lblTotal.Size = new Size(27, 32);
            lblTotal.TabIndex = 16;
            lblTotal.Text = "0";
            // 
            // Factura
            // 
            AutoScaleDimensions = new SizeF(13F, 32F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(985, 1075);
            Controls.Add(lblTotal);
            Controls.Add(label8);
            Controls.Add(lblIgv);
            Controls.Add(label7);
            Controls.Add(label6);
            Controls.Add(tabla);
            Controls.Add(lblRazon);
            Controls.Add(label5);
            Controls.Add(lblRuc);
            Controls.Add(label4);
            Controls.Add(lblNombre);
            Controls.Add(lbl);
            Controls.Add(dtFecha);
            Controls.Add(label3);
            Controls.Add(lblNum);
            Controls.Add(label2);
            Controls.Add(label1);
            Margin = new Padding(5, 5, 5, 5);
            Name = "Factura";
            Text = "Factura";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label lblNum;
        private Label label3;
        private DateTimePicker dtFecha;
        private Label lbl;
        private Label lblNombre;
        private Label label4;
        private Label lblRuc;
        private Label label5;
        private Label lblRazon;
        private ListView tabla;
        private ColumnHeader Nombre;
        private ColumnHeader Cantidad;
        private ColumnHeader Precio;
        private Label label6;
        private Label label7;
        private Label lblIgv;
        private Label label8;
        private Label lblTotal;
    }
}