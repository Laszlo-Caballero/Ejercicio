namespace Ejercicio.Ejercicios
{
    partial class EjercicioSeis
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
            txtCod = new TextBox();
            txtNombre = new TextBox();
            txtPrecio = new TextBox();
            txtStockAct = new TextBox();
            txtStockMin = new TextBox();
            cbUnidadMedida = new ComboBox();
            rbY = new RadioButton();
            rbN = new RadioButton();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            label7 = new Label();
            label8 = new Label();
            tabla = new DataGridView();
            btnEnviar = new Button();
            ((System.ComponentModel.ISupportInitialize)tabla).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 12F);
            label1.Location = new Point(12, 9);
            label1.Name = "label1";
            label1.Size = new Size(163, 28);
            label1.TabIndex = 0;
            label1.Text = "Insertar Producto";
            // 
            // txtCod
            // 
            txtCod.Enabled = false;
            txtCod.Location = new Point(29, 84);
            txtCod.Name = "txtCod";
            txtCod.Size = new Size(132, 27);
            txtCod.TabIndex = 1;
            // 
            // txtNombre
            // 
            txtNombre.Location = new Point(29, 157);
            txtNombre.Name = "txtNombre";
            txtNombre.Size = new Size(132, 27);
            txtNombre.TabIndex = 2;
            // 
            // txtPrecio
            // 
            txtPrecio.Location = new Point(29, 221);
            txtPrecio.Name = "txtPrecio";
            txtPrecio.Size = new Size(132, 27);
            txtPrecio.TabIndex = 3;
            // 
            // txtStockAct
            // 
            txtStockAct.Location = new Point(29, 277);
            txtStockAct.Name = "txtStockAct";
            txtStockAct.Size = new Size(132, 27);
            txtStockAct.TabIndex = 4;
            // 
            // txtStockMin
            // 
            txtStockMin.Location = new Point(29, 335);
            txtStockMin.Name = "txtStockMin";
            txtStockMin.Size = new Size(132, 27);
            txtStockMin.TabIndex = 5;
            // 
            // cbUnidadMedida
            // 
            cbUnidadMedida.DropDownStyle = ComboBoxStyle.DropDownList;
            cbUnidadMedida.FormattingEnabled = true;
            cbUnidadMedida.Items.AddRange(new object[] { "millar", "unidad", "docena", "ciento" });
            cbUnidadMedida.Location = new Point(230, 83);
            cbUnidadMedida.Name = "cbUnidadMedida";
            cbUnidadMedida.Size = new Size(151, 28);
            cbUnidadMedida.TabIndex = 6;
            // 
            // rbY
            // 
            rbY.AutoSize = true;
            rbY.Location = new Point(230, 147);
            rbY.Name = "rbY";
            rbY.Size = new Size(42, 24);
            rbY.TabIndex = 7;
            rbY.TabStop = true;
            rbY.Text = "Si";
            rbY.UseVisualStyleBackColor = true;
            // 
            // rbN
            // 
            rbN.AutoSize = true;
            rbN.Location = new Point(230, 177);
            rbN.Name = "rbN";
            rbN.Size = new Size(50, 24);
            rbN.TabIndex = 8;
            rbN.TabStop = true;
            rbN.Text = "No";
            rbN.UseVisualStyleBackColor = true;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(29, 50);
            label2.Name = "label2";
            label2.Size = new Size(122, 20);
            label2.TabIndex = 9;
            label2.Text = "Codigo Producto";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(29, 125);
            label3.Name = "label3";
            label3.Size = new Size(151, 20);
            label3.TabIndex = 10;
            label3.Text = "Descripcion Producto";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(67, 198);
            label4.Name = "label4";
            label4.Size = new Size(50, 20);
            label4.TabIndex = 11;
            label4.Text = "Precio";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(49, 254);
            label5.Name = "label5";
            label5.Size = new Size(91, 20);
            label5.TabIndex = 12;
            label5.Text = "Stock Actual";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(40, 312);
            label6.Name = "label6";
            label6.Size = new Size(100, 20);
            label6.TabIndex = 13;
            label6.Text = "Stock Minimo";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(230, 50);
            label7.Name = "label7";
            label7.Size = new Size(133, 20);
            label7.TabIndex = 14;
            label7.Text = "Unidad de medida";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(230, 124);
            label8.Name = "label8";
            label8.Size = new Size(87, 20);
            label8.TabIndex = 15;
            label8.Text = "Importado?";
            // 
            // tabla
            // 
            tabla.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            tabla.Location = new Point(400, 50);
            tabla.Name = "tabla";
            tabla.RowHeadersWidth = 51;
            tabla.Size = new Size(957, 420);
            tabla.TabIndex = 16;
            // 
            // btnEnviar
            // 
            btnEnviar.Location = new Point(29, 408);
            btnEnviar.Name = "btnEnviar";
            btnEnviar.Size = new Size(206, 62);
            btnEnviar.TabIndex = 17;
            btnEnviar.Text = "Enviar";
            btnEnviar.UseVisualStyleBackColor = true;
            btnEnviar.Click += btnEnviar_Click;
            // 
            // EjercicioSeis
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1369, 510);
            Controls.Add(btnEnviar);
            Controls.Add(tabla);
            Controls.Add(label8);
            Controls.Add(label7);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(rbN);
            Controls.Add(rbY);
            Controls.Add(cbUnidadMedida);
            Controls.Add(txtStockMin);
            Controls.Add(txtStockAct);
            Controls.Add(txtPrecio);
            Controls.Add(txtNombre);
            Controls.Add(txtCod);
            Controls.Add(label1);
            Name = "EjercicioSeis";
            Text = "EjercicioSeis";
            Load += EjercicioSeis_Load;
            ((System.ComponentModel.ISupportInitialize)tabla).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private TextBox txtCod;
        private TextBox txtNombre;
        private TextBox txtPrecio;
        private TextBox txtStockAct;
        private TextBox txtStockMin;
        private ComboBox cbUnidadMedida;
        private RadioButton rbY;
        private RadioButton rbN;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private Label label6;
        private Label label7;
        private Label label8;
        private DataGridView tabla;
        private Button btnEnviar;
    }
}