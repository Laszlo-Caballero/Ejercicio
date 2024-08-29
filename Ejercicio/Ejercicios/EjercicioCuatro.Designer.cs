namespace Ejercicio.Ejercicios
{
    partial class EjercicioCuatro
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
            datosTabla = new DataGridView();
            groupBox1 = new GroupBox();
            groupBox2 = new GroupBox();
            rbtAsc = new RadioButton();
            rbtDesc = new RadioButton();
            rbtProducto = new RadioButton();
            rbtCliente = new RadioButton();
            rbtIngresos = new RadioButton();
            ((System.ComponentModel.ISupportInitialize)datosTabla).BeginInit();
            groupBox1.SuspendLayout();
            groupBox2.SuspendLayout();
            SuspendLayout();
            // 
            // datosTabla
            // 
            datosTabla.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            datosTabla.Location = new Point(319, 29);
            datosTabla.Name = "datosTabla";
            datosTabla.Size = new Size(446, 252);
            datosTabla.TabIndex = 0;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(rbtIngresos);
            groupBox1.Controls.Add(rbtCliente);
            groupBox1.Controls.Add(rbtProducto);
            groupBox1.Location = new Point(12, 29);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(272, 145);
            groupBox1.TabIndex = 1;
            groupBox1.TabStop = false;
            groupBox1.Text = "Reportes";
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(rbtDesc);
            groupBox2.Controls.Add(rbtAsc);
            groupBox2.Location = new Point(12, 199);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(272, 82);
            groupBox2.TabIndex = 2;
            groupBox2.TabStop = false;
            groupBox2.Text = "Orenamiento";
            // 
            // rbtAsc
            // 
            rbtAsc.AutoSize = true;
            rbtAsc.Location = new Point(21, 40);
            rbtAsc.Name = "rbtAsc";
            rbtAsc.Size = new Size(87, 19);
            rbtAsc.TabIndex = 3;
            rbtAsc.TabStop = true;
            rbtAsc.Text = "Ascendente";
            rbtAsc.UseVisualStyleBackColor = true;
            // 
            // rbtDesc
            // 
            rbtDesc.AutoSize = true;
            rbtDesc.Location = new Point(145, 40);
            rbtDesc.Name = "rbtDesc";
            rbtDesc.Size = new Size(93, 19);
            rbtDesc.TabIndex = 4;
            rbtDesc.TabStop = true;
            rbtDesc.Text = "Descendente";
            rbtDesc.UseVisualStyleBackColor = true;
            // 
            // rbtProducto
            // 
            rbtProducto.AutoSize = true;
            rbtProducto.Location = new Point(21, 34);
            rbtProducto.Name = "rbtProducto";
            rbtProducto.Size = new Size(132, 19);
            rbtProducto.TabIndex = 5;
            rbtProducto.TabStop = true;
            rbtProducto.Text = "Ventas por Producto";
            rbtProducto.UseVisualStyleBackColor = true;
            // 
            // rbtCliente
            // 
            rbtCliente.AutoSize = true;
            rbtCliente.Location = new Point(21, 74);
            rbtCliente.Name = "rbtCliente";
            rbtCliente.Size = new Size(120, 19);
            rbtCliente.TabIndex = 6;
            rbtCliente.TabStop = true;
            rbtCliente.Text = "Ventas por Cliente";
            rbtCliente.UseVisualStyleBackColor = true;
            // 
            // rbtIngresos
            // 
            rbtIngresos.AutoSize = true;
            rbtIngresos.Location = new Point(21, 110);
            rbtIngresos.Name = "rbtIngresos";
            rbtIngresos.Size = new Size(115, 19);
            rbtIngresos.TabIndex = 7;
            rbtIngresos.TabStop = true;
            rbtIngresos.Text = "Ingresos por Mes";
            rbtIngresos.UseVisualStyleBackColor = true;
            // 
            // EjercicioCuatro
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 319);
            Controls.Add(groupBox2);
            Controls.Add(groupBox1);
            Controls.Add(datosTabla);
            Name = "EjercicioCuatro";
            Text = "EjercicioCuatro";
            ((System.ComponentModel.ISupportInitialize)datosTabla).EndInit();
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private DataGridView datosTabla;
        private GroupBox groupBox1;
        private RadioButton rbtIngresos;
        private RadioButton rbtCliente;
        private RadioButton rbtProducto;
        private GroupBox groupBox2;
        private RadioButton rbtDesc;
        private RadioButton rbtAsc;
    }
}