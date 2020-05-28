namespace ProyectoBDM
{
    partial class MenuAdmin
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
            this.bApelicula = new System.Windows.Forms.Button();
            this.bA_act = new System.Windows.Forms.Button();
            this.bAdir = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.generoPelicula = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.buttonEstado = new System.Windows.Forms.Button();
            this.LbMenuCliente = new System.Windows.Forms.Label();
            this.BtnSalir = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(235, 78);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(0, 13);
            this.label1.TabIndex = 0;
            // 
            // bApelicula
            // 
            this.bApelicula.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.bApelicula.Font = new System.Drawing.Font("Bebas Neue", 20.25F);
            this.bApelicula.Location = new System.Drawing.Point(28, 94);
            this.bApelicula.Name = "bApelicula";
            this.bApelicula.Size = new System.Drawing.Size(238, 75);
            this.bApelicula.TabIndex = 1;
            this.bApelicula.Text = "PELICULAS";
            this.bApelicula.UseVisualStyleBackColor = false;
            this.bApelicula.Click += new System.EventHandler(this.bApelicula_Click);
            // 
            // bA_act
            // 
            this.bA_act.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.bA_act.Font = new System.Drawing.Font("Bebas Neue", 20.25F);
            this.bA_act.Location = new System.Drawing.Point(272, 94);
            this.bA_act.Name = "bA_act";
            this.bA_act.Size = new System.Drawing.Size(238, 75);
            this.bA_act.TabIndex = 2;
            this.bA_act.Text = "ACTORES";
            this.bA_act.UseVisualStyleBackColor = false;
            this.bA_act.Click += new System.EventHandler(this.bA_act_Click);
            // 
            // bAdir
            // 
            this.bAdir.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.bAdir.Font = new System.Drawing.Font("Bebas Neue", 20.25F);
            this.bAdir.Location = new System.Drawing.Point(272, 175);
            this.bAdir.Name = "bAdir";
            this.bAdir.Size = new System.Drawing.Size(238, 75);
            this.bAdir.TabIndex = 3;
            this.bAdir.Text = "DIRECTORES";
            this.bAdir.UseVisualStyleBackColor = false;
            this.bAdir.Click += new System.EventHandler(this.bAdir_Click);
            // 
            // button4
            // 
            this.button4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.button4.Font = new System.Drawing.Font("Bebas Neue", 20.25F);
            this.button4.Location = new System.Drawing.Point(28, 256);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(238, 75);
            this.button4.TabIndex = 4;
            this.button4.Text = "CONSULTAS";
            this.button4.UseVisualStyleBackColor = false;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // generoPelicula
            // 
            this.generoPelicula.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.generoPelicula.Font = new System.Drawing.Font("Bebas Neue", 20.25F);
            this.generoPelicula.Location = new System.Drawing.Point(28, 175);
            this.generoPelicula.Name = "generoPelicula";
            this.generoPelicula.Size = new System.Drawing.Size(238, 75);
            this.generoPelicula.TabIndex = 5;
            this.generoPelicula.Text = "GÉNEROS";
            this.generoPelicula.UseVisualStyleBackColor = false;
            this.generoPelicula.Click += new System.EventHandler(this.generoPelicula_Click);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.button1.Font = new System.Drawing.Font("Bebas Neue", 20.25F);
            this.button1.Location = new System.Drawing.Point(272, 256);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(238, 75);
            this.button1.TabIndex = 6;
            this.button1.Text = "MULTAS";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // buttonEstado
            // 
            this.buttonEstado.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.buttonEstado.Font = new System.Drawing.Font("Bebas Neue", 20.25F);
            this.buttonEstado.Location = new System.Drawing.Point(28, 336);
            this.buttonEstado.Margin = new System.Windows.Forms.Padding(2);
            this.buttonEstado.Name = "buttonEstado";
            this.buttonEstado.Size = new System.Drawing.Size(482, 75);
            this.buttonEstado.TabIndex = 7;
            this.buttonEstado.Text = "ESTADO DE PRESTAMOS";
            this.buttonEstado.UseVisualStyleBackColor = false;
            this.buttonEstado.Click += new System.EventHandler(this.buttonEstado_Click);
            // 
            // LbMenuCliente
            // 
            this.LbMenuCliente.AutoSize = true;
            this.LbMenuCliente.Font = new System.Drawing.Font("Bebas Neue", 35F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LbMenuCliente.ForeColor = System.Drawing.Color.Crimson;
            this.LbMenuCliente.Location = new System.Drawing.Point(129, 19);
            this.LbMenuCliente.Name = "LbMenuCliente";
            this.LbMenuCliente.Size = new System.Drawing.Size(281, 61);
            this.LbMenuCliente.TabIndex = 8;
            this.LbMenuCliente.Text = "ELIGE UNA OPCIóN";
            // 
            // BtnSalir
            // 
            this.BtnSalir.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.BtnSalir.Cursor = System.Windows.Forms.Cursors.Default;
            this.BtnSalir.FlatAppearance.BorderSize = 0;
            this.BtnSalir.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnSalir.Font = new System.Drawing.Font("Wingdings 2", 17F, System.Drawing.FontStyle.Bold);
            this.BtnSalir.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(32)))), ((int)(((byte)(35)))));
            this.BtnSalir.Location = new System.Drawing.Point(463, 0);
            this.BtnSalir.Name = "BtnSalir";
            this.BtnSalir.Size = new System.Drawing.Size(75, 27);
            this.BtnSalir.TabIndex = 16;
            this.BtnSalir.Text = "";
            this.BtnSalir.UseVisualStyleBackColor = false;
            this.BtnSalir.Click += new System.EventHandler(this.BtnSalir_Click);
            // 
            // MenuAdmin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(32)))), ((int)(((byte)(35)))));
            this.ClientSize = new System.Drawing.Size(538, 439);
            this.Controls.Add(this.BtnSalir);
            this.Controls.Add(this.LbMenuCliente);
            this.Controls.Add(this.buttonEstado);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.generoPelicula);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.bAdir);
            this.Controls.Add(this.bA_act);
            this.Controls.Add(this.bApelicula);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "MenuAdmin";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "MenuAdmin";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button bApelicula;
        private System.Windows.Forms.Button bA_act;
        private System.Windows.Forms.Button bAdir;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button generoPelicula;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button buttonEstado;
        private System.Windows.Forms.Label LbMenuCliente;
        private System.Windows.Forms.Button BtnSalir;
    }
}