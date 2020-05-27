namespace ProyectoBDM
{
    partial class InicioSesionCliente
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
            this.LbInicioSesion = new System.Windows.Forms.Label();
            this.TbUsuarioIniCli = new System.Windows.Forms.TextBox();
            this.TbContrasenaIniCli = new System.Windows.Forms.TextBox();
            this.LbMensaje = new System.Windows.Forms.Label();
            this.LbMensaje2 = new System.Windows.Forms.Label();
            this.LinkLbRegistro = new System.Windows.Forms.LinkLabel();
            this.LbErrorIniCli = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.LbIniCliMal = new System.Windows.Forms.Label();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.BtnSalir = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.BtnIngresar = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // LbInicioSesion
            // 
            this.LbInicioSesion.AutoSize = true;
            this.LbInicioSesion.Font = new System.Drawing.Font("Bebas Neue", 35F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LbInicioSesion.ForeColor = System.Drawing.Color.Crimson;
            this.LbInicioSesion.Location = new System.Drawing.Point(110, 19);
            this.LbInicioSesion.Name = "LbInicioSesion";
            this.LbInicioSesion.Size = new System.Drawing.Size(259, 56);
            this.LbInicioSesion.TabIndex = 0;
            this.LbInicioSesion.Text = "Inicio de Sesion";
            this.LbInicioSesion.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // TbUsuarioIniCli
            // 
            this.TbUsuarioIniCli.Font = new System.Drawing.Font("Quicksand", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TbUsuarioIniCli.ForeColor = System.Drawing.SystemColors.WindowFrame;
            this.TbUsuarioIniCli.Location = new System.Drawing.Point(67, 81);
            this.TbUsuarioIniCli.Name = "TbUsuarioIniCli";
            this.TbUsuarioIniCli.Size = new System.Drawing.Size(207, 32);
            this.TbUsuarioIniCli.TabIndex = 3;
            this.TbUsuarioIniCli.Text = "Usuario";
            this.TbUsuarioIniCli.Click += new System.EventHandler(this.TbUsuarioIniCli_Click);
            // 
            // TbContrasenaIniCli
            // 
            this.TbContrasenaIniCli.Font = new System.Drawing.Font("Quicksand", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TbContrasenaIniCli.ForeColor = System.Drawing.SystemColors.WindowFrame;
            this.TbContrasenaIniCli.Location = new System.Drawing.Point(67, 135);
            this.TbContrasenaIniCli.Name = "TbContrasenaIniCli";
            this.TbContrasenaIniCli.Size = new System.Drawing.Size(207, 32);
            this.TbContrasenaIniCli.TabIndex = 4;
            this.TbContrasenaIniCli.Text = "Contraseña";
            this.TbContrasenaIniCli.Click += new System.EventHandler(this.TbContrasenaIniCli_Click);
            // 
            // LbMensaje
            // 
            this.LbMensaje.AutoSize = true;
            this.LbMensaje.Font = new System.Drawing.Font("Quicksand", 12F);
            this.LbMensaje.ForeColor = System.Drawing.Color.White;
            this.LbMensaje.Location = new System.Drawing.Point(295, 176);
            this.LbMensaje.Name = "LbMensaje";
            this.LbMensaje.Size = new System.Drawing.Size(179, 24);
            this.LbMensaje.TabIndex = 6;
            this.LbMensaje.Text = "Aun No Tienes Cuenta?";
            // 
            // LbMensaje2
            // 
            this.LbMensaje2.AutoSize = true;
            this.LbMensaje2.Font = new System.Drawing.Font("Quicksand", 12F);
            this.LbMensaje2.ForeColor = System.Drawing.Color.White;
            this.LbMensaje2.Location = new System.Drawing.Point(295, 201);
            this.LbMensaje2.Name = "LbMensaje2";
            this.LbMensaje2.Size = new System.Drawing.Size(85, 24);
            this.LbMensaje2.TabIndex = 7;
            this.LbMensaje2.Text = "Registrate";
            this.LbMensaje2.Click += new System.EventHandler(this.LbMensaje2_Click);
            // 
            // LinkLbRegistro
            // 
            this.LinkLbRegistro.ActiveLinkColor = System.Drawing.Color.Crimson;
            this.LinkLbRegistro.AutoSize = true;
            this.LinkLbRegistro.Font = new System.Drawing.Font("Quicksand", 12F);
            this.LinkLbRegistro.LinkColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(205)))), ((int)(((byte)(203)))));
            this.LinkLbRegistro.Location = new System.Drawing.Point(377, 201);
            this.LinkLbRegistro.Name = "LinkLbRegistro";
            this.LinkLbRegistro.Size = new System.Drawing.Size(45, 24);
            this.LinkLbRegistro.TabIndex = 8;
            this.LinkLbRegistro.TabStop = true;
            this.LinkLbRegistro.Text = "Aqui!";
            this.LinkLbRegistro.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabel1_LinkClicked);
            // 
            // LbErrorIniCli
            // 
            this.LbErrorIniCli.AutoSize = true;
            this.LbErrorIniCli.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LbErrorIniCli.Location = new System.Drawing.Point(39, 175);
            this.LbErrorIniCli.Name = "LbErrorIniCli";
            this.LbErrorIniCli.Size = new System.Drawing.Size(0, 17);
            this.LbErrorIniCli.TabIndex = 9;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 30F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(45, 175);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(0, 46);
            this.label1.TabIndex = 10;
            // 
            // LbIniCliMal
            // 
            this.LbIniCliMal.AutoSize = true;
            this.LbIniCliMal.Font = new System.Drawing.Font("Quicksand", 12F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LbIniCliMal.ForeColor = System.Drawing.Color.Crimson;
            this.LbIniCliMal.Location = new System.Drawing.Point(27, 183);
            this.LbIniCliMal.Name = "LbIniCliMal";
            this.LbIniCliMal.Size = new System.Drawing.Size(247, 24);
            this.LbIniCliMal.TabIndex = 11;
            this.LbIniCliMal.Text = "Usuario o contraseña incorrectos";
            this.LbIniCliMal.Visible = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = global::ProyectoBDM.Properties.Resources.ContrasenaCli;
            this.pictureBox2.Location = new System.Drawing.Point(31, 135);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(30, 30);
            this.pictureBox2.TabIndex = 13;
            this.pictureBox2.TabStop = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::ProyectoBDM.Properties.Resources.UsuarioCli;
            this.pictureBox1.Location = new System.Drawing.Point(31, 81);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(30, 30);
            this.pictureBox1.TabIndex = 12;
            this.pictureBox1.TabStop = false;
            // 
            // BtnSalir
            // 
            this.BtnSalir.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.BtnSalir.Cursor = System.Windows.Forms.Cursors.Default;
            this.BtnSalir.FlatAppearance.BorderSize = 0;
            this.BtnSalir.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnSalir.Font = new System.Drawing.Font("Wingdings 2", 17F, System.Drawing.FontStyle.Bold);
            this.BtnSalir.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(32)))), ((int)(((byte)(35)))));
            this.BtnSalir.Location = new System.Drawing.Point(411, 0);
            this.BtnSalir.Name = "BtnSalir";
            this.BtnSalir.Size = new System.Drawing.Size(75, 27);
            this.BtnSalir.TabIndex = 14;
            this.BtnSalir.Text = "";
            this.BtnSalir.UseVisualStyleBackColor = false;
            this.BtnSalir.Click += new System.EventHandler(this.BtnSalir_Click);
            this.BtnSalir.MouseLeave += new System.EventHandler(this.BtnSalir_MouseLeave);
            this.BtnSalir.MouseMove += new System.Windows.Forms.MouseEventHandler(this.BtnSalir_MouseMove);
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(252, 158);
            this.dataGridView1.Margin = new System.Windows.Forms.Padding(2);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(213, 79);
            this.dataGridView1.TabIndex = 17;
            // 
            // BtnIngresar
            // 
            this.BtnIngresar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.BtnIngresar.Font = new System.Drawing.Font("Bebas Neue", 18F);
            this.BtnIngresar.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(32)))), ((int)(((byte)(35)))));
            this.BtnIngresar.Location = new System.Drawing.Point(302, 96);
            this.BtnIngresar.Name = "BtnIngresar";
            this.BtnIngresar.Size = new System.Drawing.Size(163, 57);
            this.BtnIngresar.TabIndex = 5;
            this.BtnIngresar.Text = "Ingresar";
            this.BtnIngresar.UseVisualStyleBackColor = false;
            this.BtnIngresar.Click += new System.EventHandler(this.BtnIngresar_Click);
            this.BtnIngresar.MouseLeave += new System.EventHandler(this.BtnIngresar_MouseLeave);
            this.BtnIngresar.MouseMove += new System.Windows.Forms.MouseEventHandler(this.BtnIngresar_MouseMove);
            // 
            // InicioSesionCliente
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(32)))), ((int)(((byte)(35)))));
            this.ClientSize = new System.Drawing.Size(486, 244);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.BtnSalir);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.LbIniCliMal);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.LbErrorIniCli);
            this.Controls.Add(this.LinkLbRegistro);
            this.Controls.Add(this.LbMensaje2);
            this.Controls.Add(this.LbMensaje);
            this.Controls.Add(this.BtnIngresar);
            this.Controls.Add(this.TbContrasenaIniCli);
            this.Controls.Add(this.TbUsuarioIniCli);
            this.Controls.Add(this.LbInicioSesion);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "InicioSesionCliente";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Load += new System.EventHandler(this.InicioSesionCliente_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label LbInicioSesion;
        private System.Windows.Forms.TextBox TbUsuarioIniCli;
        private System.Windows.Forms.TextBox TbContrasenaIniCli;
        private System.Windows.Forms.Label LbMensaje;
        private System.Windows.Forms.LinkLabel LinkLbRegistro;
        private System.Windows.Forms.Label LbErrorIniCli;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label LbIniCliMal;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Button BtnSalir;
        public System.Windows.Forms.Label LbMensaje2;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button BtnIngresar;
    }
}