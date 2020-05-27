namespace ProyectoBDM
{
    partial class estadoCuenta
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
            this.label2 = new System.Windows.Forms.Label();
            this.dgvP = new System.Windows.Forms.DataGridView();
            this.showPeliculaCliente = new System.Windows.Forms.Button();
            this.MULTAS = new System.Windows.Forms.Label();
            this.dgvM = new System.Windows.Forms.DataGridView();
            this.showMultas = new System.Windows.Forms.Button();
            this.verHistorial = new System.Windows.Forms.Button();
            this.back = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvP)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvM)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(346, 35);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(98, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "ESTADO CUENTA";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(80, 73);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(146, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "PELÍCULAS EN PRESTAMO";
            // 
            // dgvP
            // 
            this.dgvP.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvP.Location = new System.Drawing.Point(83, 99);
            this.dgvP.Name = "dgvP";
            this.dgvP.RowHeadersWidth = 51;
            this.dgvP.Size = new System.Drawing.Size(606, 110);
            this.dgvP.TabIndex = 2;
            // 
            // showPeliculaCliente
            // 
            this.showPeliculaCliente.Location = new System.Drawing.Point(356, 215);
            this.showPeliculaCliente.Name = "showPeliculaCliente";
            this.showPeliculaCliente.Size = new System.Drawing.Size(75, 23);
            this.showPeliculaCliente.TabIndex = 3;
            this.showPeliculaCliente.Text = "SHOW";
            this.showPeliculaCliente.UseVisualStyleBackColor = true;
            this.showPeliculaCliente.Click += new System.EventHandler(this.showPeliculaCliente_Click);
            // 
            // MULTAS
            // 
            this.MULTAS.AutoSize = true;
            this.MULTAS.Location = new System.Drawing.Point(80, 249);
            this.MULTAS.Name = "MULTAS";
            this.MULTAS.Size = new System.Drawing.Size(51, 13);
            this.MULTAS.TabIndex = 4;
            this.MULTAS.Text = "MULTAS";
            // 
            // dgvM
            // 
            this.dgvM.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvM.Location = new System.Drawing.Point(83, 282);
            this.dgvM.Name = "dgvM";
            this.dgvM.RowHeadersWidth = 51;
            this.dgvM.Size = new System.Drawing.Size(613, 127);
            this.dgvM.TabIndex = 5;
            // 
            // showMultas
            // 
            this.showMultas.Location = new System.Drawing.Point(369, 422);
            this.showMultas.Name = "showMultas";
            this.showMultas.Size = new System.Drawing.Size(75, 23);
            this.showMultas.TabIndex = 6;
            this.showMultas.Text = "SHOW";
            this.showMultas.UseVisualStyleBackColor = true;
            this.showMultas.Click += new System.EventHandler(this.showMultas_Click);
            // 
            // verHistorial
            // 
            this.verHistorial.Location = new System.Drawing.Point(713, 422);
            this.verHistorial.Name = "verHistorial";
            this.verHistorial.Size = new System.Drawing.Size(75, 23);
            this.verHistorial.TabIndex = 7;
            this.verHistorial.Text = "Ver Historial";
            this.verHistorial.UseVisualStyleBackColor = true;
            this.verHistorial.Click += new System.EventHandler(this.verHistorial_Click);
            // 
            // back
            // 
            this.back.Font = new System.Drawing.Font("Wingdings 3", 24.75F);
            this.back.Location = new System.Drawing.Point(131, 126);
            this.back.Name = "back";
            this.back.Size = new System.Drawing.Size(46, 46);
            this.back.TabIndex = 8;
            this.back.Text = "";
            this.back.UseVisualStyleBackColor = true;
            this.back.Click += new System.EventHandler(this.back_Click);
            // 
            // estadoCuenta
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(803, 457);
            this.Controls.Add(this.back);
            this.Controls.Add(this.verHistorial);
            this.Controls.Add(this.showMultas);
            this.Controls.Add(this.dgvM);
            this.Controls.Add(this.MULTAS);
            this.Controls.Add(this.showPeliculaCliente);
            this.Controls.Add(this.dgvP);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "estadoCuenta";
            this.Text = "estadoCuenta";
            this.Load += new System.EventHandler(this.estadoCuenta_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvP)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvM)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataGridView dgvP;
        private System.Windows.Forms.Button showPeliculaCliente;
        private System.Windows.Forms.Label MULTAS;
        private System.Windows.Forms.DataGridView dgvM;
        private System.Windows.Forms.Button showMultas;
        private System.Windows.Forms.Button verHistorial;
        private System.Windows.Forms.Button back;
    }
}