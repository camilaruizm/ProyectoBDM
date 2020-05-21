namespace ProyectoBDM
{
    partial class CuentaCliente
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
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.button2 = new System.Windows.Forms.Button();
            this.btHistorial = new System.Windows.Forms.Button();
            this.label9 = new System.Windows.Forms.Label();
            this.mostrarPelicula = new System.Windows.Forms.Button();
            this.mostrarMulta = new System.Windows.Forms.Button();
            this.dgvM = new System.Windows.Forms.DataGridView();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dgvM)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Agency FB", 25F, System.Drawing.FontStyle.Bold);
            this.label8.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(40)))), ((int)(((byte)(70)))));
            this.label8.Location = new System.Drawing.Point(192, 9);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(238, 41);
            this.label8.TabIndex = 24;
            this.label8.Text = "ESTADO DE CUENTA";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Agency FB", 15F);
            this.label7.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(205)))), ((int)(((byte)(203)))));
            this.label7.Location = new System.Drawing.Point(13, 50);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(139, 24);
            this.label7.TabIndex = 60;
            this.label7.Text = "Películas en posesión:";
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(246)))), ((int)(((byte)(244)))), ((int)(((byte)(234)))));
            this.button2.Font = new System.Drawing.Font("Wingdings 3", 24.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(2)));
            this.button2.ForeColor = System.Drawing.Color.Black;
            this.button2.Location = new System.Drawing.Point(518, 383);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(46, 46);
            this.button2.TabIndex = 61;
            this.button2.Text = "";
            this.button2.UseVisualStyleBackColor = false;
            // 
            // btHistorial
            // 
            this.btHistorial.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(246)))), ((int)(((byte)(244)))), ((int)(((byte)(234)))));
            this.btHistorial.Font = new System.Drawing.Font("Agency FB", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btHistorial.Location = new System.Drawing.Point(199, 396);
            this.btHistorial.Name = "btHistorial";
            this.btHistorial.Size = new System.Drawing.Size(170, 46);
            this.btHistorial.TabIndex = 73;
            this.btHistorial.Text = "VER HISTORIAL";
            this.btHistorial.UseVisualStyleBackColor = false;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Agency FB", 15F);
            this.label9.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(205)))), ((int)(((byte)(203)))));
            this.label9.Location = new System.Drawing.Point(13, 197);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(50, 24);
            this.label9.TabIndex = 75;
            this.label9.Text = "Multas:";
            // 
            // mostrarPelicula
            // 
            this.mostrarPelicula.Location = new System.Drawing.Point(257, 171);
            this.mostrarPelicula.Name = "mostrarPelicula";
            this.mostrarPelicula.Size = new System.Drawing.Size(75, 23);
            this.mostrarPelicula.TabIndex = 76;
            this.mostrarPelicula.Text = "SHOW";
            this.mostrarPelicula.UseVisualStyleBackColor = true;
            this.mostrarPelicula.Click += new System.EventHandler(this.mostrarPelicula_Click);
            // 
            // mostrarMulta
            // 
            this.mostrarMulta.Location = new System.Drawing.Point(257, 343);
            this.mostrarMulta.Name = "mostrarMulta";
            this.mostrarMulta.Size = new System.Drawing.Size(75, 23);
            this.mostrarMulta.TabIndex = 77;
            this.mostrarMulta.Text = "SHOW";
            this.mostrarMulta.UseVisualStyleBackColor = true;
            this.mostrarMulta.Click += new System.EventHandler(this.mostrarMulta_Click);
            // 
            // dgvM
            // 
            this.dgvM.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvM.Location = new System.Drawing.Point(17, 77);
            this.dgvM.Name = "dgvM";
            this.dgvM.Size = new System.Drawing.Size(547, 88);
            this.dgvM.TabIndex = 78;
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(17, 236);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(547, 101);
            this.dataGridView1.TabIndex = 79;
            // 
            // CuentaCliente
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(32)))), ((int)(((byte)(35)))));
            this.ClientSize = new System.Drawing.Size(608, 469);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.dgvM);
            this.Controls.Add(this.mostrarMulta);
            this.Controls.Add(this.mostrarPelicula);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.btHistorial);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label8);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "CuentaCliente";
            this.Text = "CuentaCliente";
            ((System.ComponentModel.ISupportInitialize)(this.dgvM)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button btHistorial;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Button mostrarPelicula;
        private System.Windows.Forms.Button mostrarMulta;
        private System.Windows.Forms.DataGridView dgvM;
        private System.Windows.Forms.DataGridView dataGridView1;
    }
}