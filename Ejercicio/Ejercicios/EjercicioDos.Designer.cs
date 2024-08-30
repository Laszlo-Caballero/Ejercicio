namespace Ejercicio.Ejercicios
{
    partial class EjercicioDos
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
            listBoxClientes = new ListBox();
            listBoxFacturas = new ListBox();
            buttonVerDetalles = new Button();
            textBoxResumenFacturas = new TextBox();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            SuspendLayout();
            // 
            // listBoxClientes
            // 
            listBoxClientes.Font = new Font("DejaVu Sans", 9F);
            listBoxClientes.FormattingEnabled = true;
            listBoxClientes.ItemHeight = 28;
            listBoxClientes.Location = new Point(39, 126);
            listBoxClientes.Margin = new Padding(5, 5, 5, 5);
            listBoxClientes.Name = "listBoxClientes";
            listBoxClientes.Size = new Size(365, 396);
            listBoxClientes.TabIndex = 0;
            listBoxClientes.SelectedIndexChanged += listBoxClientes_SelectedIndexChanged;
            // 
            // listBoxFacturas
            // 
            listBoxFacturas.Font = new Font("DejaVu Sans", 9F);
            listBoxFacturas.FormattingEnabled = true;
            listBoxFacturas.ItemHeight = 28;
            listBoxFacturas.Location = new Point(444, 126);
            listBoxFacturas.Margin = new Padding(5, 5, 5, 5);
            listBoxFacturas.Name = "listBoxFacturas";
            listBoxFacturas.Size = new Size(368, 284);
            listBoxFacturas.TabIndex = 1;
            // 
            // buttonVerDetalles
            // 
            buttonVerDetalles.Font = new Font("DejaVu Sans", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            buttonVerDetalles.Location = new Point(444, 461);
            buttonVerDetalles.Margin = new Padding(5, 5, 5, 5);
            buttonVerDetalles.Name = "buttonVerDetalles";
            buttonVerDetalles.Size = new Size(370, 51);
            buttonVerDetalles.TabIndex = 2;
            buttonVerDetalles.Text = "VER DETALLE";
            buttonVerDetalles.UseVisualStyleBackColor = true;
            buttonVerDetalles.Click += buttonVerDetalles_Click;
            // 
            // textBoxResumenFacturas
            // 
            textBoxResumenFacturas.Font = new Font("DejaVu Sans", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            textBoxResumenFacturas.Location = new Point(57, 651);
            textBoxResumenFacturas.Margin = new Padding(5, 5, 5, 5);
            textBoxResumenFacturas.Multiline = true;
            textBoxResumenFacturas.Name = "textBoxResumenFacturas";
            textBoxResumenFacturas.Size = new Size(738, 313);
            textBoxResumenFacturas.TabIndex = 3;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("DejaVu Sans", 9F, FontStyle.Bold);
            label1.Location = new Point(39, 62);
            label1.Margin = new Padding(5, 0, 5, 0);
            label1.Name = "label1";
            label1.Size = new Size(293, 28);
            label1.TabIndex = 4;
            label1.Text = "CODIGO DE CLIENTES";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("DejaVu Sans", 9F, FontStyle.Bold);
            label2.Location = new Point(448, 62);
            label2.Margin = new Padding(5, 0, 5, 0);
            label2.Name = "label2";
            label2.Size = new Size(145, 28);
            label2.TabIndex = 5;
            label2.Text = "FACTURAS";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("DejaVu Sans", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.Location = new Point(276, 584);
            label3.Margin = new Padding(5, 0, 5, 0);
            label3.Name = "label3";
            label3.Size = new Size(292, 28);
            label3.TabIndex = 6;
            label3.Text = "DETALLE DE FACTURA";
            // 
            // EjercicioDos
            // 
            AutoScaleDimensions = new SizeF(13F, 32F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(895, 986);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(textBoxResumenFacturas);
            Controls.Add(buttonVerDetalles);
            Controls.Add(listBoxFacturas);
            Controls.Add(listBoxClientes);
            Margin = new Padding(5, 5, 5, 5);
            Name = "EjercicioDos";
            Text = "EjercicioDos";
            Load += EjercicioDos_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ListBox listBoxClientes;
        private ListBox listBoxFacturas;
        private Button buttonVerDetalles;
        private TextBox textBoxResumenFacturas;
        private Label label1;
        private Label label2;
        private Label label3;
    }
}