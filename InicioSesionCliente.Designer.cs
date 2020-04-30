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
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.BtnIngresar = new System.Windows.Forms.Button();
            this.LbMensaje = new System.Windows.Forms.Label();
            this.LbMensaje2 = new System.Windows.Forms.Label();
            this.LinkLbRegistro = new System.Windows.Forms.LinkLabel();
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
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(139, 83);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(135, 20);
            this.textBox1.TabIndex = 3;
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(139, 127);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(135, 20);
            this.textBox2.TabIndex = 4;
            // 
            // BtnIngresar
            // 
            this.BtnIngresar.Location = new System.Drawing.Point(311, 78);
            this.BtnIngresar.Name = "BtnIngresar";
            this.BtnIngresar.Size = new System.Drawing.Size(163, 57);
            this.BtnIngresar.TabIndex = 5;
            this.BtnIngresar.Text = "Ingresar";
            this.BtnIngresar.UseVisualStyleBackColor = true;
            // 
            // LbMensaje
            // 
            this.LbMensaje.AutoSize = true;
            this.LbMensaje.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LbMensaje.Location = new System.Drawing.Point(308, 144);
            this.LbMensaje.Name = "LbMensaje";
            this.LbMensaje.Size = new System.Drawing.Size(159, 17);
            this.LbMensaje.TabIndex = 6;
            this.LbMensaje.Text = "Aun No Tienes Cuenta?";
            // 
            // LbMensaje2
            // 
            this.LbMensaje2.AutoSize = true;
            this.LbMensaje2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LbMensaje2.Location = new System.Drawing.Point(308, 177);
            this.LbMensaje2.Name = "LbMensaje2";
            this.LbMensaje2.Size = new System.Drawing.Size(73, 17);
            this.LbMensaje2.TabIndex = 7;
            this.LbMensaje2.Text = "Registrate";
            // 
            // LinkLbRegistro
            // 
            this.LinkLbRegistro.AutoSize = true;
            this.LinkLbRegistro.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LinkLbRegistro.Location = new System.Drawing.Point(387, 177);
            this.LinkLbRegistro.Name = "LinkLbRegistro";
            this.LinkLbRegistro.Size = new System.Drawing.Size(44, 17);
            this.LinkLbRegistro.TabIndex = 8;
            this.LinkLbRegistro.TabStop = true;
            this.LinkLbRegistro.Text = "Aqui!";
            this.LinkLbRegistro.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabel1_LinkClicked);
            // 
            // InicioSesionCliente
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(486, 215);
            this.Controls.Add(this.LinkLbRegistro);
            this.Controls.Add(this.LbMensaje2);
            this.Controls.Add(this.LbMensaje);
            this.Controls.Add(this.BtnIngresar);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.LbContrasenaCli);
            this.Controls.Add(this.LbUsuarioCli);
            this.Controls.Add(this.LbInicioSesion);
            this.Name = "InicioSesionCliente";
            this.Text = "InicioSesionCliente";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label LbInicioSesion;
        private System.Windows.Forms.Label LbUsuarioCli;
        private System.Windows.Forms.Label LbContrasenaCli;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Button BtnIngresar;
        private System.Windows.Forms.Label LbMensaje;
        private System.Windows.Forms.Label LbMensaje2;
        private System.Windows.Forms.LinkLabel LinkLbRegistro;
    }
}