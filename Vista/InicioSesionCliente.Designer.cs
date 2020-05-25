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
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
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
            this.LbInicioSesion.Font = new System.Drawing.Font("Arial Narrow", 35F);
            this.LbInicioSesion.Location = new System.Drawing.Point(129, 11);
            this.LbInicioSesion.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.LbInicioSesion.Name = "LbInicioSesion";
            this.LbInicioSesion.Size = new System.Drawing.Size(371, 69);
            this.LbInicioSesion.TabIndex = 0;
            this.LbInicioSesion.Text = "Inicio de Sesion";
            // 
            // TbUsuarioIniCli
            // 
            this.TbUsuarioIniCli.Font = new System.Drawing.Font("Arial", 15F);
            this.TbUsuarioIniCli.ForeColor = System.Drawing.SystemColors.WindowFrame;
            this.TbUsuarioIniCli.Location = new System.Drawing.Point(119, 90);
            this.TbUsuarioIniCli.Margin = new System.Windows.Forms.Padding(4);
            this.TbUsuarioIniCli.Name = "TbUsuarioIniCli";
            this.TbUsuarioIniCli.Size = new System.Drawing.Size(245, 36);
            this.TbUsuarioIniCli.TabIndex = 3;
            this.TbUsuarioIniCli.Text = "Usuario";
            this.TbUsuarioIniCli.Click += new System.EventHandler(this.TbUsuarioIniCli_Click);
            // 
            // TbContrasenaIniCli
            // 
            this.TbContrasenaIniCli.Font = new System.Drawing.Font("Arial", 15F);
            this.TbContrasenaIniCli.ForeColor = System.Drawing.SystemColors.WindowFrame;
            this.TbContrasenaIniCli.Location = new System.Drawing.Point(119, 156);
            this.TbContrasenaIniCli.Margin = new System.Windows.Forms.Padding(4);
            this.TbContrasenaIniCli.Name = "TbContrasenaIniCli";
            this.TbContrasenaIniCli.Size = new System.Drawing.Size(245, 36);
            this.TbContrasenaIniCli.TabIndex = 4;
            this.TbContrasenaIniCli.Text = "Contraseña";
            this.TbContrasenaIniCli.Click += new System.EventHandler(this.TbContrasenaIniCli_Click);
            // 
            // LbMensaje
            // 
            this.LbMensaje.AutoSize = true;
            this.LbMensaje.Font = new System.Drawing.Font("Arial Narrow", 13F);
            this.LbMensaje.Location = new System.Drawing.Point(411, 215);
            this.LbMensaje.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.LbMensaje.Name = "LbMensaje";
            this.LbMensaje.Size = new System.Drawing.Size(203, 26);
            this.LbMensaje.TabIndex = 6;
            this.LbMensaje.Text = "Aun No Tienes Cuenta?";
            // 
            // LbMensaje2
            // 
            this.LbMensaje2.AutoSize = true;
            this.LbMensaje2.Font = new System.Drawing.Font("Arial Narrow", 13F);
            this.LbMensaje2.Location = new System.Drawing.Point(411, 256);
            this.LbMensaje2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.LbMensaje2.Name = "LbMensaje2";
            this.LbMensaje2.Size = new System.Drawing.Size(94, 26);
            this.LbMensaje2.TabIndex = 7;
            this.LbMensaje2.Text = "Registrate";
            this.LbMensaje2.Click += new System.EventHandler(this.LbMensaje2_Click);
            // 
            // LinkLbRegistro
            // 
            this.LinkLbRegistro.AutoSize = true;
            this.LinkLbRegistro.Font = new System.Drawing.Font("Arial Narrow", 13F, System.Drawing.FontStyle.Bold);
            this.LinkLbRegistro.Location = new System.Drawing.Point(516, 256);
            this.LinkLbRegistro.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.LinkLbRegistro.Name = "LinkLbRegistro";
            this.LinkLbRegistro.Size = new System.Drawing.Size(58, 26);
            this.LinkLbRegistro.TabIndex = 8;
            this.LinkLbRegistro.TabStop = true;
            this.LinkLbRegistro.Text = "Aqui!";
            this.LinkLbRegistro.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabel1_LinkClicked);
            // 
            // LbErrorIniCli
            // 
            this.LbErrorIniCli.AutoSize = true;
            this.LbErrorIniCli.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LbErrorIniCli.Location = new System.Drawing.Point(52, 215);
            this.LbErrorIniCli.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.LbErrorIniCli.Name = "LbErrorIniCli";
            this.LbErrorIniCli.Size = new System.Drawing.Size(0, 20);
            this.LbErrorIniCli.TabIndex = 9;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 30F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(60, 215);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(0, 58);
            this.label1.TabIndex = 10;
            // 
            // LbIniCliMal
            // 
            this.LbIniCliMal.AutoSize = true;
            this.LbIniCliMal.Font = new System.Drawing.Font("Arial Narrow", 15F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))));
            this.LbIniCliMal.ForeColor = System.Drawing.Color.Red;
            this.LbIniCliMal.Location = new System.Drawing.Point(28, 242);
            this.LbIniCliMal.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.LbIniCliMal.Name = "LbIniCliMal";
            this.LbIniCliMal.Size = new System.Drawing.Size(353, 30);
            this.LbIniCliMal.TabIndex = 11;
            this.LbIniCliMal.Text = "Usuario o contraseña incorrectos";
            this.LbIniCliMal.Visible = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = global::ProyectoBDM.Properties.Resources.ContrasenaCli;
            this.pictureBox2.Location = new System.Drawing.Point(71, 156);
            this.pictureBox2.Margin = new System.Windows.Forms.Padding(4);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(40, 37);
            this.pictureBox2.TabIndex = 13;
            this.pictureBox2.TabStop = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::ProyectoBDM.Properties.Resources.UsuarioCli;
            this.pictureBox1.Location = new System.Drawing.Point(71, 90);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(4);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(40, 37);
            this.pictureBox1.TabIndex = 12;
            this.pictureBox1.TabStop = false;
            // 
            // BtnSalir
            // 
            this.BtnSalir.BackColor = System.Drawing.Color.Red;
            this.BtnSalir.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnSalir.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Bold);
            this.BtnSalir.Location = new System.Drawing.Point(548, -1);
            this.BtnSalir.Margin = new System.Windows.Forms.Padding(4);
            this.BtnSalir.Name = "BtnSalir";
            this.BtnSalir.Size = new System.Drawing.Size(100, 33);
            this.BtnSalir.TabIndex = 14;
            this.BtnSalir.Text = "X";
            this.BtnSalir.UseVisualStyleBackColor = false;
            this.BtnSalir.Click += new System.EventHandler(this.BtnSalir_Click);
            this.BtnSalir.MouseLeave += new System.EventHandler(this.BtnSalir_MouseLeave);
            this.BtnSalir.MouseMove += new System.Windows.Forms.MouseEventHandler(this.BtnSalir_MouseMove);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(264, 211);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(100, 22);
            this.textBox1.TabIndex = 15;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(150, 211);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 16;
            this.button1.Text = "Obtener id";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(290, 280);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(13, 11);
            this.dataGridView1.TabIndex = 17;
            this.dataGridView1.Visible = false;
            // 
            // BtnIngresar
            // 
            this.BtnIngresar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnIngresar.Font = new System.Drawing.Font("Arial", 15F, System.Drawing.FontStyle.Bold);
            this.BtnIngresar.Location = new System.Drawing.Point(412, 123);
            this.BtnIngresar.Margin = new System.Windows.Forms.Padding(4);
            this.BtnIngresar.Name = "BtnIngresar";
            this.BtnIngresar.Size = new System.Drawing.Size(217, 70);
            this.BtnIngresar.TabIndex = 5;
            this.BtnIngresar.Text = "Ingresar";
            this.BtnIngresar.UseVisualStyleBackColor = true;
            this.BtnIngresar.Click += new System.EventHandler(this.BtnIngresar_Click);
            this.BtnIngresar.MouseLeave += new System.EventHandler(this.BtnIngresar_MouseLeave);
            this.BtnIngresar.MouseMove += new System.Windows.Forms.MouseEventHandler(this.BtnIngresar_MouseMove);
            // 
            // InicioSesionCliente
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Lavender;
            this.ClientSize = new System.Drawing.Size(648, 300);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.textBox1);
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
            this.Margin = new System.Windows.Forms.Padding(4);
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
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button BtnIngresar;
    }
}