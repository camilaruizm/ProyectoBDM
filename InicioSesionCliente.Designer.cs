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
            this.LbUsuarioCli = new System.Windows.Forms.Label();
            this.LbContrasenaCli = new System.Windows.Forms.Label();
            this.TbUsuarioIniCli = new System.Windows.Forms.TextBox();
            this.TbContrasenaIniCli = new System.Windows.Forms.TextBox();
            this.BtnIngresar = new System.Windows.Forms.Button();
            this.LbMensaje = new System.Windows.Forms.Label();
            this.LbMensaje2 = new System.Windows.Forms.Label();
            this.LinkLbRegistro = new System.Windows.Forms.LinkLabel();
            this.LbErrorIniCli = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.LbIniCliMal = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // LbInicioSesion
            // 
            this.LbInicioSesion.AutoSize = true;
            this.LbInicioSesion.Font = new System.Drawing.Font("Microsoft Sans Serif", 30F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LbInicioSesion.Location = new System.Drawing.Point(54, 9);
            this.LbInicioSesion.Name = "LbInicioSesion";
            this.LbInicioSesion.Size = new System.Drawing.Size(303, 46);
            this.LbInicioSesion.TabIndex = 0;
            this.LbInicioSesion.Text = "Inicio de Sesion";
            // 
            // LbUsuarioCli
            // 
            this.LbUsuarioCli.AutoSize = true;
            this.LbUsuarioCli.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LbUsuarioCli.Location = new System.Drawing.Point(12, 78);
            this.LbUsuarioCli.Name = "LbUsuarioCli";
            this.LbUsuarioCli.Size = new System.Drawing.Size(85, 25);
            this.LbUsuarioCli.TabIndex = 1;
            this.LbUsuarioCli.Text = "Usuario:";
            // 
            // LbContrasenaCli
            // 
            this.LbContrasenaCli.AutoSize = true;
            this.LbContrasenaCli.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LbContrasenaCli.Location = new System.Drawing.Point(12, 122);
            this.LbContrasenaCli.Name = "LbContrasenaCli";
            this.LbContrasenaCli.Size = new System.Drawing.Size(120, 25);
            this.LbContrasenaCli.TabIndex = 2;
            this.LbContrasenaCli.Text = "Contraseña:";
            // 
            // TbUsuarioIniCli
            // 
            this.TbUsuarioIniCli.Location = new System.Drawing.Point(139, 83);
            this.TbUsuarioIniCli.Name = "TbUsuarioIniCli";
            this.TbUsuarioIniCli.Size = new System.Drawing.Size(135, 20);
            this.TbUsuarioIniCli.TabIndex = 3;
            // 
            // TbContrasenaIniCli
            // 
            this.TbContrasenaIniCli.Location = new System.Drawing.Point(139, 127);
            this.TbContrasenaIniCli.Name = "TbContrasenaIniCli";
            this.TbContrasenaIniCli.Size = new System.Drawing.Size(135, 20);
            this.TbContrasenaIniCli.TabIndex = 4;
            // 
            // BtnIngresar
            // 
            this.BtnIngresar.Location = new System.Drawing.Point(311, 109);
            this.BtnIngresar.Name = "BtnIngresar";
            this.BtnIngresar.Size = new System.Drawing.Size(163, 57);
            this.BtnIngresar.TabIndex = 5;
            this.BtnIngresar.Text = "Ingresar";
            this.BtnIngresar.UseVisualStyleBackColor = true;
            this.BtnIngresar.Click += new System.EventHandler(this.BtnIngresar_Click);
            // 
            // LbMensaje
            // 
            this.LbMensaje.AutoSize = true;
            this.LbMensaje.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LbMensaje.Location = new System.Drawing.Point(308, 175);
            this.LbMensaje.Name = "LbMensaje";
            this.LbMensaje.Size = new System.Drawing.Size(159, 17);
            this.LbMensaje.TabIndex = 6;
            this.LbMensaje.Text = "Aun No Tienes Cuenta?";
            // 
            // LbMensaje2
            // 
            this.LbMensaje2.AutoSize = true;
            this.LbMensaje2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LbMensaje2.Location = new System.Drawing.Point(308, 208);
            this.LbMensaje2.Name = "LbMensaje2";
            this.LbMensaje2.Size = new System.Drawing.Size(73, 17);
            this.LbMensaje2.TabIndex = 7;
            this.LbMensaje2.Text = "Registrate";
            // 
            // LinkLbRegistro
            // 
            this.LinkLbRegistro.AutoSize = true;
            this.LinkLbRegistro.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LinkLbRegistro.Location = new System.Drawing.Point(387, 208);
            this.LinkLbRegistro.Name = "LinkLbRegistro";
            this.LinkLbRegistro.Size = new System.Drawing.Size(44, 17);
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
            this.LbIniCliMal.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LbIniCliMal.ForeColor = System.Drawing.Color.Red;
            this.LbIniCliMal.Location = new System.Drawing.Point(12, 192);
            this.LbIniCliMal.Name = "LbIniCliMal";
            this.LbIniCliMal.Size = new System.Drawing.Size(275, 20);
            this.LbIniCliMal.TabIndex = 11;
            this.LbIniCliMal.Text = "Usuario o contraseña incorrectos";
            this.LbIniCliMal.Visible = false;
            // 
            // InicioSesionCliente
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(486, 245);
            this.Controls.Add(this.LbIniCliMal);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.LbErrorIniCli);
            this.Controls.Add(this.LinkLbRegistro);
            this.Controls.Add(this.LbMensaje2);
            this.Controls.Add(this.LbMensaje);
            this.Controls.Add(this.BtnIngresar);
            this.Controls.Add(this.TbContrasenaIniCli);
            this.Controls.Add(this.TbUsuarioIniCli);
            this.Controls.Add(this.LbContrasenaCli);
            this.Controls.Add(this.LbUsuarioCli);
            this.Controls.Add(this.LbInicioSesion);
            this.Name = "InicioSesionCliente";
            this.Text = "InicioSesionCliente";
            this.Load += new System.EventHandler(this.InicioSesionCliente_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label LbInicioSesion;
        private System.Windows.Forms.Label LbUsuarioCli;
        private System.Windows.Forms.Label LbContrasenaCli;
        private System.Windows.Forms.TextBox TbUsuarioIniCli;
        private System.Windows.Forms.TextBox TbContrasenaIniCli;
        private System.Windows.Forms.Button BtnIngresar;
        private System.Windows.Forms.Label LbMensaje;
        private System.Windows.Forms.Label LbMensaje2;
        private System.Windows.Forms.LinkLabel LinkLbRegistro;
        private System.Windows.Forms.Label LbErrorIniCli;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label LbIniCliMal;
    }
}