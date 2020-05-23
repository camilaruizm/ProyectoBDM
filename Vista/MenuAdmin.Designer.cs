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
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(244, 125);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(0, 13);
            this.label1.TabIndex = 0;
            // 
            // bApelicula
            // 
            this.bApelicula.BackColor = System.Drawing.SystemColors.ButtonShadow;
            this.bApelicula.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.bApelicula.Location = new System.Drawing.Point(37, 57);
            this.bApelicula.Name = "bApelicula";
            this.bApelicula.Size = new System.Drawing.Size(238, 65);
            this.bApelicula.TabIndex = 1;
            this.bApelicula.Text = "PELICULAS";
            this.bApelicula.UseVisualStyleBackColor = false;
            this.bApelicula.Click += new System.EventHandler(this.bApelicula_Click);
            // 
            // bA_act
            // 
            this.bA_act.BackColor = System.Drawing.SystemColors.ButtonShadow;
            this.bA_act.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.bA_act.Location = new System.Drawing.Point(37, 304);
            this.bA_act.Name = "bA_act";
            this.bA_act.Size = new System.Drawing.Size(238, 62);
            this.bA_act.TabIndex = 2;
            this.bA_act.Text = "ACTORES";
            this.bA_act.UseVisualStyleBackColor = false;
            this.bA_act.Click += new System.EventHandler(this.bA_act_Click);
            // 
            // bAdir
            // 
            this.bAdir.BackColor = System.Drawing.SystemColors.ButtonShadow;
            this.bAdir.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.bAdir.Location = new System.Drawing.Point(37, 180);
            this.bAdir.Name = "bAdir";
            this.bAdir.Size = new System.Drawing.Size(238, 70);
            this.bAdir.TabIndex = 3;
            this.bAdir.Text = "DIRECTORES";
            this.bAdir.UseVisualStyleBackColor = false;
            this.bAdir.Click += new System.EventHandler(this.bAdir_Click);
            // 
            // button4
            // 
            this.button4.BackColor = System.Drawing.SystemColors.ButtonShadow;
            this.button4.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button4.Location = new System.Drawing.Point(444, 304);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(238, 59);
            this.button4.TabIndex = 4;
            this.button4.Text = "CONSULTAS";
            this.button4.UseVisualStyleBackColor = false;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // generoPelicula
            // 
            this.generoPelicula.BackColor = System.Drawing.SystemColors.ButtonShadow;
            this.generoPelicula.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.generoPelicula.Location = new System.Drawing.Point(444, 57);
            this.generoPelicula.Name = "generoPelicula";
            this.generoPelicula.Size = new System.Drawing.Size(238, 65);
            this.generoPelicula.TabIndex = 5;
            this.generoPelicula.Text = "GÉNEROS";
            this.generoPelicula.UseVisualStyleBackColor = false;
            this.generoPelicula.Click += new System.EventHandler(this.generoPelicula_Click);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.SystemColors.ButtonShadow;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button1.Location = new System.Drawing.Point(444, 180);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(238, 70);
            this.button1.TabIndex = 6;
            this.button1.Text = "MULTAS";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // MenuAdmin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.generoPelicula);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.bAdir);
            this.Controls.Add(this.bA_act);
            this.Controls.Add(this.bApelicula);
            this.Controls.Add(this.label1);
            this.Name = "MenuAdmin";
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
    }
}