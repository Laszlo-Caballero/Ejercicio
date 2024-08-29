namespace Ejercicio.Ejercicios.Factura
{
    partial class EjercicioFac
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
            cbCliente = new ComboBox();
            tabla = new DataGridView();
            ((System.ComponentModel.ISupportInitialize)tabla).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 12F);
            label1.Location = new Point(12, 9);
            label1.Name = "label1";
            label1.Size = new Size(208, 28);
            label1.TabIndex = 0;
            label1.Text = "Ver Facturas de Cliente";
            // 
            // cbCliente
            // 
            cbCliente.DropDownStyle = ComboBoxStyle.DropDownList;
            cbCliente.FormattingEnabled = true;
            cbCliente.Location = new Point(12, 40);
            cbCliente.Name = "cbCliente";
            cbCliente.Size = new Size(208, 28);
            cbCliente.TabIndex = 1;
            cbCliente.SelectedIndexChanged += cbCliente_SelectedIndexChanged;
            // 
            // tabla
            // 
            tabla.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            tabla.Location = new Point(262, 21);
            tabla.Name = "tabla";
            tabla.ReadOnly = true;
            tabla.RowHeadersWidth = 51;
            tabla.Size = new Size(758, 398);
            tabla.TabIndex = 2;
            tabla.CellClick += tabla_CellClick;
            // 
            // EjercicioFac
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1060, 450);
            Controls.Add(tabla);
            Controls.Add(cbCliente);
            Controls.Add(label1);
            Name = "EjercicioFac";
            Text = "EjercicioFac";
            ((System.ComponentModel.ISupportInitialize)tabla).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private ComboBox cbCliente;
        private DataGridView tabla;
    }
}