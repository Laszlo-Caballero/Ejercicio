﻿namespace Ejercicio.Ejercicios
{
    partial class EjercicioTres
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
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            gola = new Label();
            label7 = new Label();
            DTP1 = new DateTimePicker();
            CB1 = new CheckBox();
            CB2 = new CheckBox();
            CBVendedor = new ComboBox();
            txtNombre = new TextBox();
            txtCodigo = new TextBox();
            txtSueldo = new TextBox();
            txtApellido = new TextBox();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = SystemColors.ActiveBorder;
            label1.Font = new Font("Showcard Gothic", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.Location = new Point(160, 75);
            label1.Margin = new Padding(6, 0, 6, 0);
            label1.Name = "label1";
            label1.Size = new Size(351, 37);
            label1.TabIndex = 0;
            label1.Text = "CODIGO DE VENDEDOR:";
            label1.Click += label1_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("SimSun-ExtB", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.Location = new Point(234, 239);
            label2.Margin = new Padding(6, 0, 6, 0);
            label2.Name = "label2";
            label2.Size = new Size(214, 24);
            label2.TabIndex = 1;
            label2.Text = "Tipo de Vendedor:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("SimSun-ExtB", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label3.Location = new Point(373, 407);
            label3.Margin = new Padding(6, 0, 6, 0);
            label3.Name = "label3";
            label3.Size = new Size(202, 24);
            label3.TabIndex = 2;
            label3.Text = "Codigo Distrito:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("SimSun-ExtB", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label4.Location = new Point(111, 407);
            label4.Margin = new Padding(6, 0, 6, 0);
            label4.Name = "label4";
            label4.Size = new Size(94, 24);
            label4.TabIndex = 3;
            label4.Text = "Nombre:";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("SimSun-ExtB", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label5.Location = new Point(111, 565);
            label5.Margin = new Padding(6, 0, 6, 0);
            label5.Name = "label5";
            label5.Size = new Size(94, 24);
            label5.TabIndex = 4;
            label5.Text = "Sueldo:";
            // 
            // gola
            // 
            gola.AutoSize = true;
            gola.Font = new Font("SimSun-ExtB", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            gola.Location = new Point(373, 565);
            gola.Margin = new Padding(6, 0, 6, 0);
            gola.Name = "gola";
            gola.Size = new Size(118, 24);
            gola.TabIndex = 5;
            gola.Text = "Apellido:";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("SimSun-ExtB", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label7.Location = new Point(232, 732);
            label7.Margin = new Padding(6, 0, 6, 0);
            label7.Name = "label7";
            label7.Size = new Size(214, 24);
            label7.TabIndex = 6;
            label7.Text = "Fecha de Ingreso:";
            // 
            // DTP1
            // 
            DTP1.CalendarFont = new Font("SimSun-ExtB", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            DTP1.Enabled = false;
            DTP1.Location = new Point(93, 779);
            DTP1.Margin = new Padding(6, 6, 6, 6);
            DTP1.Name = "DTP1";
            DTP1.Size = new Size(520, 39);
            DTP1.TabIndex = 7;
            // 
            // CB1
            // 
            CB1.Appearance = Appearance.Button;
            CB1.AutoSize = true;
            CB1.Enabled = false;
            CB1.Location = new Point(254, 292);
            CB1.Margin = new Padding(6, 6, 6, 6);
            CB1.Name = "CB1";
            CB1.Size = new Size(37, 42);
            CB1.TabIndex = 8;
            CB1.Text = "1";
            CB1.UseVisualStyleBackColor = true;
            CB1.CheckedChanged += CB1_CheckedChanged;
            // 
            // CB2
            // 
            CB2.Appearance = Appearance.Button;
            CB2.AutoSize = true;
            CB2.Enabled = false;
            CB2.Location = new Point(355, 292);
            CB2.Margin = new Padding(6, 6, 6, 6);
            CB2.Name = "CB2";
            CB2.Size = new Size(37, 42);
            CB2.TabIndex = 9;
            CB2.Text = "2";
            CB2.UseVisualStyleBackColor = true;
            // 
            // CBVendedor
            // 
            CBVendedor.FormattingEnabled = true;
            CBVendedor.Location = new Point(208, 141);
            CBVendedor.Margin = new Padding(6, 6, 6, 6);
            CBVendedor.Name = "CBVendedor";
            CBVendedor.Size = new Size(221, 40);
            CBVendedor.TabIndex = 10;
            CBVendedor.SelectedIndexChanged += CBVendedor_SelectedIndexChanged;
            // 
            // txtNombre
            // 
            txtNombre.Enabled = false;
            txtNombre.Location = new Point(111, 459);
            txtNombre.Margin = new Padding(6, 6, 6, 6);
            txtNombre.Name = "txtNombre";
            txtNombre.Size = new Size(182, 39);
            txtNombre.TabIndex = 11;
            // 
            // txtCodigo
            // 
            txtCodigo.Enabled = false;
            txtCodigo.Location = new Point(373, 459);
            txtCodigo.Margin = new Padding(6, 6, 6, 6);
            txtCodigo.Name = "txtCodigo";
            txtCodigo.Size = new Size(182, 39);
            txtCodigo.TabIndex = 12;
            // 
            // txtSueldo
            // 
            txtSueldo.Enabled = false;
            txtSueldo.Location = new Point(111, 604);
            txtSueldo.Margin = new Padding(6, 6, 6, 6);
            txtSueldo.Name = "txtSueldo";
            txtSueldo.Size = new Size(182, 39);
            txtSueldo.TabIndex = 13;
            // 
            // txtApellido
            // 
            txtApellido.Enabled = false;
            txtApellido.Location = new Point(373, 604);
            txtApellido.Margin = new Padding(6, 6, 6, 6);
            txtApellido.Name = "txtApellido";
            txtApellido.Size = new Size(182, 39);
            txtApellido.TabIndex = 14;
            // 
            // EjercicioTres
            // 
            AutoScaleDimensions = new SizeF(13F, 32F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ActiveCaption;
            ClientSize = new Size(669, 960);
            Controls.Add(txtApellido);
            Controls.Add(txtSueldo);
            Controls.Add(txtCodigo);
            Controls.Add(txtNombre);
            Controls.Add(CBVendedor);
            Controls.Add(CB2);
            Controls.Add(CB1);
            Controls.Add(DTP1);
            Controls.Add(label7);
            Controls.Add(gola);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Margin = new Padding(6, 6, 6, 6);
            Name = "EjercicioTres";
            Text = "EjercicioTres";
            Load += EjercicioTres_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private Label gola;
        private Label label7;
        private DateTimePicker DTP1;
        private CheckBox CB1;
        private CheckBox CB2;
        private ComboBox CBVendedor;
        private TextBox txtNombre;
        private TextBox txtCodigo;
        private TextBox txtSueldo;
        private TextBox txtApellido;
    }
}