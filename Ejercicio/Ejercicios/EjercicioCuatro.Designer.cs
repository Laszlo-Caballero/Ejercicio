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
            grupoCriterio = new GroupBox();
            rdBMes = new RadioButton();
            rdBProducto = new RadioButton();
            rdBCliente = new RadioButton();
            txtBuscar = new TextBox();
            lblBuscar = new Label();
            GrupoReporte = new GroupBox();
            rbtProducto = new RadioButton();
            rbtMes = new RadioButton();
            rbtCliente = new RadioButton();
            datosTabla = new DataGridView();
            btnMostrar = new Button();
            btnBusqueda = new Button();
            grupoCriterio.SuspendLayout();
            GrupoReporte.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)datosTabla).BeginInit();
            SuspendLayout();
            // 
            // grupoCriterio
            // 
            grupoCriterio.Controls.Add(rdBMes);
            grupoCriterio.Controls.Add(rdBProducto);
            grupoCriterio.Controls.Add(rdBCliente);
            grupoCriterio.Location = new Point(12, 223);
            grupoCriterio.Name = "grupoCriterio";
            grupoCriterio.Size = new Size(272, 124);
            grupoCriterio.TabIndex = 8;
            grupoCriterio.TabStop = false;
            grupoCriterio.Text = "Criterios";
            // 
            // rdBMes
            // 
            rdBMes.AutoSize = true;
            rdBMes.Location = new Point(21, 92);
            rdBMes.Name = "rdBMes";
            rdBMes.Size = new Size(94, 19);
            rdBMes.TabIndex = 10;
            rdBMes.TabStop = true;
            rdBMes.Text = "Nombre Mes";
            rdBMes.UseVisualStyleBackColor = true;
            // 
            // rdBProducto
            // 
            rdBProducto.AutoSize = true;
            rdBProducto.Location = new Point(20, 31);
            rdBProducto.Name = "rdBProducto";
            rdBProducto.Size = new Size(116, 19);
            rdBProducto.TabIndex = 9;
            rdBProducto.TabStop = true;
            rdBProducto.Text = "Codigo Producto";
            rdBProducto.UseVisualStyleBackColor = true;
            // 
            // rdBCliente
            // 
            rdBCliente.AutoSize = true;
            rdBCliente.Location = new Point(21, 63);
            rdBCliente.Name = "rdBCliente";
            rdBCliente.Size = new Size(104, 19);
            rdBCliente.TabIndex = 8;
            rdBCliente.TabStop = true;
            rdBCliente.Text = "Codigo Cliente";
            rdBCliente.UseVisualStyleBackColor = true;
            // 
            // txtBuscar
            // 
            txtBuscar.Location = new Point(127, 185);
            txtBuscar.Name = "txtBuscar";
            txtBuscar.Size = new Size(157, 23);
            txtBuscar.TabIndex = 7;
            // 
            // lblBuscar
            // 
            lblBuscar.AutoSize = true;
            lblBuscar.Location = new Point(12, 188);
            lblBuscar.Name = "lblBuscar";
            lblBuscar.Size = new Size(45, 15);
            lblBuscar.TabIndex = 6;
            lblBuscar.Text = "Buscar:";
            // 
            // GrupoReporte
            // 
            GrupoReporte.Controls.Add(rbtProducto);
            GrupoReporte.Controls.Add(rbtMes);
            GrupoReporte.Controls.Add(rbtCliente);
            GrupoReporte.Location = new Point(12, 29);
            GrupoReporte.Name = "GrupoReporte";
            GrupoReporte.Size = new Size(272, 136);
            GrupoReporte.TabIndex = 5;
            GrupoReporte.TabStop = false;
            GrupoReporte.Text = "Reportes";
            // 
            // rbtProducto
            // 
            rbtProducto.AutoSize = true;
            rbtProducto.Location = new Point(21, 26);
            rbtProducto.Name = "rbtProducto";
            rbtProducto.Size = new Size(132, 19);
            rbtProducto.TabIndex = 8;
            rbtProducto.TabStop = true;
            rbtProducto.Text = "Ventas por Producto";
            rbtProducto.UseVisualStyleBackColor = true;
            // 
            // rbtMes
            // 
            rbtMes.AutoSize = true;
            rbtMes.Location = new Point(21, 97);
            rbtMes.Name = "rbtMes";
            rbtMes.Size = new Size(115, 19);
            rbtMes.TabIndex = 7;
            rbtMes.TabStop = true;
            rbtMes.Text = "Ingresos por Mes";
            rbtMes.UseVisualStyleBackColor = true;
            // 
            // rbtCliente
            // 
            rbtCliente.AutoSize = true;
            rbtCliente.Location = new Point(21, 61);
            rbtCliente.Name = "rbtCliente";
            rbtCliente.Size = new Size(134, 19);
            rbtCliente.TabIndex = 6;
            rbtCliente.TabStop = true;
            rbtCliente.Text = "Compras por Cliente";
            rbtCliente.UseVisualStyleBackColor = true;
            // 
            // datosTabla
            // 
            datosTabla.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            datosTabla.Location = new Point(309, 31);
            datosTabla.Name = "datosTabla";
            datosTabla.Size = new Size(467, 242);
            datosTabla.TabIndex = 9;
            // 
            // btnMostrar
            // 
            btnMostrar.Location = new Point(311, 296);
            btnMostrar.Name = "btnMostrar";
            btnMostrar.Size = new Size(93, 38);
            btnMostrar.TabIndex = 11;
            btnMostrar.Text = "MOSTRAR";
            btnMostrar.UseVisualStyleBackColor = true;
            btnMostrar.Click += btnMostrar_Click;
            // 
            // btnBusqueda
            // 
            btnBusqueda.Location = new Point(421, 296);
            btnBusqueda.Name = "btnBusqueda";
            btnBusqueda.Size = new Size(93, 38);
            btnBusqueda.TabIndex = 10;
            btnBusqueda.Text = "BUSQUEDA";
            btnBusqueda.UseVisualStyleBackColor = true;
            btnBusqueda.Click += btnBusqueda_Click;
            // 
            // EjercicioCuatro
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(804, 367);
            Controls.Add(btnMostrar);
            Controls.Add(btnBusqueda);
            Controls.Add(datosTabla);
            Controls.Add(grupoCriterio);
            Controls.Add(txtBuscar);
            Controls.Add(lblBuscar);
            Controls.Add(GrupoReporte);
            Name = "EjercicioCuatro";
            Text = "EjercicioCuatro";
            grupoCriterio.ResumeLayout(false);
            grupoCriterio.PerformLayout();
            GrupoReporte.ResumeLayout(false);
            GrupoReporte.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)datosTabla).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private GroupBox grupoCriterio;
        private RadioButton rdBMes;
        private RadioButton rdBProducto;
        private RadioButton rdBCliente;
        private TextBox txtBuscar;
        private Label lblBuscar;
        private GroupBox GrupoReporte;
        private RadioButton rbtProducto;
        private RadioButton rbtMes;
        private RadioButton rbtCliente;
        private DataGridView datosTabla;
        private Button btnMostrar;
        private Button btnBusqueda;
    }
}