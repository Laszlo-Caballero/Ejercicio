namespace Ejercicio.Ejercicios
{
    partial class EjercicioSiete
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
            cbProveedores = new ComboBox();
            label2 = new Label();
            dgvOrdenCompra = new DataGridView();
            dgvProductos = new DataGridView();
            label3 = new Label();
            ((System.ComponentModel.ISupportInitialize)dgvOrdenCompra).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dgvProductos).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("DejaVu Sans", 9F, FontStyle.Bold);
            label1.Location = new Point(67, 49);
            label1.Name = "label1";
            label1.Size = new Size(171, 28);
            label1.TabIndex = 0;
            label1.Text = "PROVEEDOR";
            // 
            // cbProveedores
            // 
            cbProveedores.FormattingEnabled = true;
            cbProveedores.Location = new Point(67, 105);
            cbProveedores.Name = "cbProveedores";
            cbProveedores.Size = new Size(242, 40);
            cbProveedores.TabIndex = 1;
            cbProveedores.SelectedIndexChanged += cbProveedores_SelectedIndexChanged;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("DejaVu Sans", 9F, FontStyle.Bold);
            label2.Location = new Point(382, 49);
            label2.Name = "label2";
            label2.Size = new Size(663, 28);
            label2.TabIndex = 3;
            label2.Text = "ORDENES DE COMPRA ASOCIADAS AL PROVEEDOR";
            // 
            // dgvOrdenCompra
            // 
            dgvOrdenCompra.AllowUserToAddRows = false;
            dgvOrdenCompra.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvOrdenCompra.Location = new Point(382, 105);
            dgvOrdenCompra.Name = "dgvOrdenCompra";
            dgvOrdenCompra.RowHeadersWidth = 82;
            dgvOrdenCompra.Size = new Size(1034, 300);
            dgvOrdenCompra.TabIndex = 4;
            dgvOrdenCompra.CellClick += dgvOrdenCompra_CellClick;
            // 
            // dgvProductos
            // 
            dgvProductos.AllowUserToAddRows = false;
            dgvProductos.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvProductos.Location = new Point(382, 519);
            dgvProductos.Name = "dgvProductos";
            dgvProductos.RowHeadersWidth = 82;
            dgvProductos.Size = new Size(847, 283);
            dgvProductos.TabIndex = 5;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("DejaVu Sans", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.Location = new Point(382, 458);
            label3.Name = "label3";
            label3.Size = new Size(521, 28);
            label3.TabIndex = 6;
            label3.Text = "PRODUCTOS DE LA ORDEN DE COMPRA";
            // 
            // EjercicioOcho
            // 
            AutoScaleDimensions = new SizeF(13F, 32F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1468, 883);
            Controls.Add(label3);
            Controls.Add(dgvProductos);
            Controls.Add(dgvOrdenCompra);
            Controls.Add(label2);
            Controls.Add(cbProveedores);
            Controls.Add(label1);
            Name = "EjercicioOcho";
            Text = "EjercicioOcho";
            Load += EjercicioOcho_Load;
            ((System.ComponentModel.ISupportInitialize)dgvOrdenCompra).EndInit();
            ((System.ComponentModel.ISupportInitialize)dgvProductos).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private ComboBox cbProveedores;
        private Label label2;
        private DataGridView dgvOrdenCompra;
        private DataGridView dgvProductos;
        private Label label3;
    }
}