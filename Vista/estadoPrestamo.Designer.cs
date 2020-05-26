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
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.buttonLimpiar = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
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
            this.dgvEstado.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.DisplayedCells;
            this.dgvEstado.ColumnHeadersHeight = 29;
            this.dgvEstado.Location = new System.Drawing.Point(12, 186);
            this.dgvEstado.Name = "dgvEstado";
            this.dgvEstado.ReadOnly = true;
            this.dgvEstado.RowHeadersVisible = false;
            this.dgvEstado.RowHeadersWidth = 51;
            this.dgvEstado.RowTemplate.Height = 24;
            this.dgvEstado.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvEstado.Size = new System.Drawing.Size(901, 196);
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
            this.label2.Location = new System.Drawing.Point(57, 81);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(159, 17);
            this.label2.TabIndex = 3;
            this.label2.Text = "Insertar ID del préstamo";
            // 
            // buttonBuscarP
            // 
            this.buttonBuscarP.Location = new System.Drawing.Point(352, 77);
            this.buttonBuscarP.Name = "buttonBuscarP";
            this.buttonBuscarP.Size = new System.Drawing.Size(117, 23);
            this.buttonBuscarP.TabIndex = 4;
            this.buttonBuscarP.Text = "Buscar préstamo";
            this.buttonBuscarP.UseVisualStyleBackColor = true;
            this.buttonBuscarP.Click += new System.EventHandler(this.buttonBuscarP_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(626, 72);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(87, 33);
            this.button1.TabIndex = 5;
            this.button1.Text = "Entregado";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(738, 72);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(111, 33);
            this.button2.TabIndex = 6;
            this.button2.Text = "No entregado";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // buttonLimpiar
            // 
            this.buttonLimpiar.Location = new System.Drawing.Point(672, 121);
            this.buttonLimpiar.Name = "buttonLimpiar";
            this.buttonLimpiar.Size = new System.Drawing.Size(122, 31);
            this.buttonLimpiar.TabIndex = 7;
            this.buttonLimpiar.Text = "Limpiar estado";
            this.buttonLimpiar.UseVisualStyleBackColor = true;
            this.buttonLimpiar.Click += new System.EventHandler(this.buttonLimpiar_Click);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(352, 114);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(117, 26);
            this.button3.TabIndex = 8;
            this.button3.Text = "Mostrar todo";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // estadoPrestamo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(925, 450);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.buttonLimpiar);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.buttonBuscarP);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.textBoxIdPrestamo);
            this.Controls.Add(this.dgvEstado);
            this.Controls.Add(this.label1);
            this.Name = "estadoPrestamo";
            this.Text = "estadoPrestamo";
            this.Load += new System.EventHandler(this.estadoPrestamo_Load);
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
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button buttonLimpiar;
        private System.Windows.Forms.Button button3;
    }
}