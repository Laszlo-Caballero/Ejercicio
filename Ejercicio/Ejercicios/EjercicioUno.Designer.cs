namespace Ejercicio.Ejercicios
{
    partial class EjercicioUno
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
            cbDistritos = new ComboBox();
            label4 = new Label();
            txtNombre = new TextBox();
            txtApellido = new TextBox();
            txtSueldo = new TextBox();
            label5 = new Label();
            label6 = new Label();
            label7 = new Label();
            label8 = new Label();
            label9 = new Label();
            label10 = new Label();
            dtpFechaIngreso = new DateTimePicker();
            cbTV = new ComboBox();
            cbDistritosNV = new ComboBox();
            label11 = new Label();
            label12 = new Label();
            label13 = new Label();
            txtNombreVendedor = new TextBox();
            txtApellidoVendedor = new TextBox();
            panel1 = new Panel();
            btnIngresar = new Button();
            btnVerSueldo = new Button();
            panel2 = new Panel();
            dataGridViewVendedores = new DataGridView();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridViewVendedores).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("DejaVu Sans", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(50, 40);
            label1.Name = "label1";
            label1.Size = new Size(784, 28);
            label1.TabIndex = 0;
            label1.Text = "CONSULTAR LOS VENDEDORES QUE HAY EN CADA DISTRITO";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("DejaVu Sans", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.Location = new Point(50, 117);
            label2.Name = "label2";
            label2.Size = new Size(133, 28);
            label2.TabIndex = 1;
            label2.Text = "DISTRITO";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("DejaVu Sans", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.Location = new Point(426, 117);
            label3.Name = "label3";
            label3.Size = new Size(188, 28);
            label3.TabIndex = 2;
            label3.Text = "VENDEDORES";
            // 
            // cbDistritos
            // 
            cbDistritos.FormattingEnabled = true;
            cbDistritos.Location = new Point(50, 176);
            cbDistritos.Name = "cbDistritos";
            cbDistritos.Size = new Size(258, 40);
            cbDistritos.TabIndex = 3;
            cbDistritos.SelectedIndexChanged += cbDistritos_SelectedIndexChanged;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("DejaVu Sans", 9F, FontStyle.Bold);
            label4.Location = new Point(58, 504);
            label4.Name = "label4";
            label4.Size = new Size(450, 28);
            label4.TabIndex = 5;
            label4.Text = "INGRESAR DATOS DEL VENDEDOR";
            // 
            // txtNombre
            // 
            txtNombre.Font = new Font("DejaVu Sans", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtNombre.Location = new Point(58, 607);
            txtNombre.Name = "txtNombre";
            txtNombre.Size = new Size(200, 35);
            txtNombre.TabIndex = 6;
            // 
            // txtApellido
            // 
            txtApellido.Font = new Font("DejaVu Sans", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtApellido.Location = new Point(345, 607);
            txtApellido.Name = "txtApellido";
            txtApellido.Size = new Size(200, 35);
            txtApellido.TabIndex = 7;
            // 
            // txtSueldo
            // 
            txtSueldo.Font = new Font("DejaVu Sans", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtSueldo.Location = new Point(58, 723);
            txtSueldo.Name = "txtSueldo";
            txtSueldo.Size = new Size(200, 35);
            txtSueldo.TabIndex = 8;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("DejaVu Sans", 9F, FontStyle.Bold);
            label5.Location = new Point(58, 561);
            label5.Name = "label5";
            label5.Size = new Size(121, 28);
            label5.TabIndex = 9;
            label5.Text = "Nombre:";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("DejaVu Sans", 9F, FontStyle.Bold);
            label6.Location = new Point(345, 561);
            label6.Name = "label6";
            label6.Size = new Size(122, 28);
            label6.TabIndex = 10;
            label6.Text = "Apellido:";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("DejaVu Sans", 9F, FontStyle.Bold);
            label7.Location = new Point(602, 561);
            label7.Name = "label7";
            label7.Size = new Size(244, 28);
            label7.TabIndex = 11;
            label7.Text = "Tipo de vendedor:";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("DejaVu Sans", 9F, FontStyle.Bold);
            label8.Location = new Point(58, 680);
            label8.Name = "label8";
            label8.Size = new Size(106, 28);
            label8.TabIndex = 12;
            label8.Text = "Sueldo:";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Font = new Font("DejaVu Sans", 9F, FontStyle.Bold);
            label9.Location = new Point(345, 680);
            label9.Name = "label9";
            label9.Size = new Size(237, 28);
            label9.TabIndex = 13;
            label9.Text = "Fecha de ingreso:";
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Font = new Font("DejaVu Sans", 9F, FontStyle.Bold);
            label10.Location = new Point(58, 798);
            label10.Name = "label10";
            label10.Size = new Size(115, 28);
            label10.TabIndex = 14;
            label10.Text = "Distrito:";
            // 
            // dtpFechaIngreso
            // 
            dtpFechaIngreso.Font = new Font("DejaVu Sans", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            dtpFechaIngreso.Location = new Point(345, 723);
            dtpFechaIngreso.Name = "dtpFechaIngreso";
            dtpFechaIngreso.Size = new Size(520, 35);
            dtpFechaIngreso.TabIndex = 15;
            // 
            // cbTV
            // 
            cbTV.Font = new Font("DejaVu Sans", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            cbTV.FormattingEnabled = true;
            cbTV.Items.AddRange(new object[] { "Interno", "Externo" });
            cbTV.Location = new Point(611, 607);
            cbTV.Name = "cbTV";
            cbTV.Size = new Size(200, 36);
            cbTV.TabIndex = 16;
            // 
            // cbDistritosNV
            // 
            cbDistritosNV.Font = new Font("DejaVu Sans", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            cbDistritosNV.FormattingEnabled = true;
            cbDistritosNV.Location = new Point(58, 848);
            cbDistritosNV.Name = "cbDistritosNV";
            cbDistritosNV.Size = new Size(200, 36);
            cbDistritosNV.TabIndex = 17;
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Font = new Font("DejaVu Sans", 9F, FontStyle.Bold);
            label11.Location = new Point(976, 504);
            label11.Name = "label11";
            label11.Size = new Size(488, 28);
            label11.TabIndex = 18;
            label11.Text = "CONSULTAR SUELDO DEL VENDEDOR";
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.Font = new Font("DejaVu Sans", 9F, FontStyle.Bold);
            label12.Location = new Point(985, 561);
            label12.Name = "label12";
            label12.Size = new Size(121, 28);
            label12.TabIndex = 19;
            label12.Text = "Nombre:";
            // 
            // label13
            // 
            label13.AutoSize = true;
            label13.Font = new Font("DejaVu Sans", 9F, FontStyle.Bold);
            label13.Location = new Point(984, 637);
            label13.Name = "label13";
            label13.Size = new Size(122, 28);
            label13.TabIndex = 20;
            label13.Text = "Apellido:";
            // 
            // txtNombreVendedor
            // 
            txtNombreVendedor.Font = new Font("DejaVu Sans", 9F, FontStyle.Bold);
            txtNombreVendedor.Location = new Point(1135, 561);
            txtNombreVendedor.Name = "txtNombreVendedor";
            txtNombreVendedor.Size = new Size(200, 35);
            txtNombreVendedor.TabIndex = 21;
            // 
            // txtApellidoVendedor
            // 
            txtApellidoVendedor.Font = new Font("DejaVu Sans", 9F, FontStyle.Bold);
            txtApellidoVendedor.Location = new Point(1135, 630);
            txtApellidoVendedor.Name = "txtApellidoVendedor";
            txtApellidoVendedor.Size = new Size(200, 35);
            txtApellidoVendedor.TabIndex = 22;
            // 
            // panel1
            // 
            panel1.Controls.Add(btnIngresar);
            panel1.Font = new Font("DejaVu Sans", 9F, FontStyle.Bold);
            panel1.Location = new Point(22, 479);
            panel1.Name = "panel1";
            panel1.Size = new Size(863, 457);
            panel1.TabIndex = 23;
            // 
            // btnIngresar
            // 
            btnIngresar.Location = new Point(575, 334);
            btnIngresar.Name = "btnIngresar";
            btnIngresar.Size = new Size(214, 75);
            btnIngresar.TabIndex = 0;
            btnIngresar.Text = "Ingresar datos";
            btnIngresar.UseVisualStyleBackColor = true;
            btnIngresar.Click += btnIngresar_Click;
            // 
            // btnVerSueldo
            // 
            btnVerSueldo.Font = new Font("DejaVu Sans", 9F, FontStyle.Bold);
            btnVerSueldo.Location = new Point(1163, 723);
            btnVerSueldo.Name = "btnVerSueldo";
            btnVerSueldo.Size = new Size(172, 74);
            btnVerSueldo.TabIndex = 24;
            btnVerSueldo.Text = "Ver sueldo";
            btnVerSueldo.UseVisualStyleBackColor = true;
            btnVerSueldo.Click += btnVerSueldo_Click;
            // 
            // panel2
            // 
            panel2.Location = new Point(946, 487);
            panel2.Name = "panel2";
            panel2.Size = new Size(533, 349);
            panel2.TabIndex = 25;
            // 
            // dataGridViewVendedores
            // 
            dataGridViewVendedores.AllowUserToAddRows = false;
            dataGridViewVendedores.AllowUserToResizeRows = false;
            dataGridViewVendedores.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewVendedores.Location = new Point(426, 161);
            dataGridViewVendedores.Name = "dataGridViewVendedores";
            dataGridViewVendedores.RowHeadersWidth = 82;
            dataGridViewVendedores.Size = new Size(996, 300);
            dataGridViewVendedores.TabIndex = 26;
            // 
            // EjercicioUno
            // 
            AutoScaleDimensions = new SizeF(13F, 32F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1510, 948);
            Controls.Add(dataGridViewVendedores);
            Controls.Add(btnVerSueldo);
            Controls.Add(txtApellidoVendedor);
            Controls.Add(txtNombreVendedor);
            Controls.Add(label13);
            Controls.Add(label12);
            Controls.Add(label11);
            Controls.Add(cbDistritosNV);
            Controls.Add(cbTV);
            Controls.Add(dtpFechaIngreso);
            Controls.Add(label10);
            Controls.Add(label9);
            Controls.Add(label8);
            Controls.Add(label7);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(txtSueldo);
            Controls.Add(txtApellido);
            Controls.Add(txtNombre);
            Controls.Add(label4);
            Controls.Add(cbDistritos);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(panel1);
            Controls.Add(panel2);
            Margin = new Padding(5);
            Name = "EjercicioUno";
            Text = "EjercicioUno";
            Load += EjercicioUno_Load;
            panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dataGridViewVendedores).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private ComboBox cbDistritos;
        private Label label4;
        private TextBox txtNombre;
        private TextBox txtApellido;
        private TextBox txtSueldo;
        private Label label5;
        private Label label6;
        private Label label7;
        private Label label8;
        private Label label9;
        private Label label10;
        private DateTimePicker dtpFechaIngreso;
        private ComboBox cbTV;
        private ComboBox cbDistritosNV;
        private Label label11;
        private Label label12;
        private Label label13;
        private TextBox txtNombreVendedor;
        private TextBox txtApellidoVendedor;
        private Panel panel1;
        private Button btnIngresar;
        private Button btnVerSueldo;
        private Panel panel2;
        private DataGridView dataGridViewVendedores;
    }
}