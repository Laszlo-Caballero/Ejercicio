namespace Ejercicio.Ejercicios
{
    partial class EjercicioCinco
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;
        private Label label1;
        private TreeView treeView;
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
            treeView = new TreeView();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 12F);
            label1.Location = new Point(12, 9);
            label1.Name = "label1";
            label1.Size = new Size(171, 28);
            label1.TabIndex = 0;
            label1.Text = "Clientes y Facturas";
            // 
            // treeView
            // 
            treeView.Location = new Point(12, 50);
            treeView.Name = "treeView";
            treeView.Size = new Size(760, 400);
            treeView.TabIndex = 1;
            treeView.AfterSelect += treeView_AfterSelect;
            // 
            // EjercicioCinco
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(784, 461);
            Controls.Add(treeView);
            Controls.Add(label1);
            Name = "EjercicioCinco";
            Text = "Clientes y Facturas";
            Load += EjercicioCinco_Load;
            ResumeLayout(false);
            PerformLayout();
        }
        #endregion
    }
}