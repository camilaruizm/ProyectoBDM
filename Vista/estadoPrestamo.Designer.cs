namespace ProyectoBDM.Vista
{
    partial class estadoPrestamo
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
            this.label1 = new System.Windows.Forms.Label();
            this.dgvEstado = new System.Windows.Forms.DataGridView();
            this.textBoxIdPrestamo = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.buttonBuscarP = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvEstado)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(60, 42);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(116, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "Estado Préstamo";
            // 
            // dgvEstado
            // 
            this.dgvEstado.AllowUserToAddRows = false;
            this.dgvEstado.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvEstado.ColumnHeadersVisible = false;
            this.dgvEstado.Location = new System.Drawing.Point(107, 150);
            this.dgvEstado.Name = "dgvEstado";
            this.dgvEstado.ReadOnly = true;
            this.dgvEstado.RowHeadersWidth = 51;
            this.dgvEstado.RowTemplate.Height = 24;
            this.dgvEstado.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvEstado.Size = new System.Drawing.Size(622, 103);
            this.dgvEstado.TabIndex = 1;
            // 
            // textBoxIdPrestamo
            // 
            this.textBoxIdPrestamo.Location = new System.Drawing.Point(223, 78);
            this.textBoxIdPrestamo.Name = "textBoxIdPrestamo";
            this.textBoxIdPrestamo.Size = new System.Drawing.Size(100, 22);
            this.textBoxIdPrestamo.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(81, 81);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(116, 17);
            this.label2.TabIndex = 3;
            this.label2.Text = "Estado Préstamo";
            // 
            // buttonBuscarP
            // 
            this.buttonBuscarP.Location = new System.Drawing.Point(352, 77);
            this.buttonBuscarP.Name = "buttonBuscarP";
            this.buttonBuscarP.Size = new System.Drawing.Size(117, 23);
            this.buttonBuscarP.TabIndex = 4;
            this.buttonBuscarP.Text = "Buscar estado";
            this.buttonBuscarP.UseVisualStyleBackColor = true;
            this.buttonBuscarP.Click += new System.EventHandler(this.buttonBuscarP_Click);
            // 
            // estadoPrestamo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.buttonBuscarP);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.textBoxIdPrestamo);
            this.Controls.Add(this.dgvEstado);
            this.Controls.Add(this.label1);
            this.Name = "estadoPrestamo";
            this.Text = "estadoPrestamo";
            ((System.ComponentModel.ISupportInitialize)(this.dgvEstado)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dgvEstado;
        private System.Windows.Forms.TextBox textBoxIdPrestamo;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button buttonBuscarP;
    }
}