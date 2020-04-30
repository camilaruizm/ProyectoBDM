namespace ProyectoBDM
{
    partial class ValidacionPersona
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
            this.BtnCliente = new System.Windows.Forms.Button();
            this.BtnAdministrador = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // BtnCliente
            // 
            this.BtnCliente.Location = new System.Drawing.Point(420, 84);
            this.BtnCliente.Name = "BtnCliente";
            this.BtnCliente.Size = new System.Drawing.Size(368, 163);
            this.BtnCliente.TabIndex = 1;
            this.BtnCliente.Text = "Soy Cliente";
            this.BtnCliente.UseVisualStyleBackColor = true;
            // 
            // BtnAdministrador
            // 
            this.BtnAdministrador.Location = new System.Drawing.Point(12, 84);
            this.BtnAdministrador.Name = "BtnAdministrador";
            this.BtnAdministrador.Size = new System.Drawing.Size(368, 163);
            this.BtnAdministrador.TabIndex = 2;
            this.BtnAdministrador.Text = "Soy Administrador";
            this.BtnAdministrador.UseVisualStyleBackColor = true;
            // 
            // ValidacionPersona
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.BtnAdministrador);
            this.Controls.Add(this.BtnCliente);
            this.Name = "ValidacionPersona";
            this.Text = "ValidacionPersona";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button BtnCliente;
        private System.Windows.Forms.Button BtnAdministrador;
    }
}