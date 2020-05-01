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
            this.LbSeleccione = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // BtnCliente
            // 
            this.BtnCliente.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.BtnCliente.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnCliente.Font = new System.Drawing.Font("Arial", 20F, System.Drawing.FontStyle.Bold);
            this.BtnCliente.Location = new System.Drawing.Point(420, 125);
            this.BtnCliente.Name = "BtnCliente";
            this.BtnCliente.Size = new System.Drawing.Size(368, 163);
            this.BtnCliente.TabIndex = 1;
            this.BtnCliente.Text = "Soy Cliente";
            this.BtnCliente.UseVisualStyleBackColor = true;
            this.BtnCliente.Click += new System.EventHandler(this.BtnCliente_Click);
            this.BtnCliente.MouseLeave += new System.EventHandler(this.BtnCliente_MouseLeave);
            this.BtnCliente.MouseMove += new System.Windows.Forms.MouseEventHandler(this.BtnCliente_MouseMove);
            // 
            // BtnAdministrador
            // 
            this.BtnAdministrador.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnAdministrador.Font = new System.Drawing.Font("Arial", 20F, System.Drawing.FontStyle.Bold);
            this.BtnAdministrador.Location = new System.Drawing.Point(12, 125);
            this.BtnAdministrador.Name = "BtnAdministrador";
            this.BtnAdministrador.Size = new System.Drawing.Size(368, 163);
            this.BtnAdministrador.TabIndex = 2;
            this.BtnAdministrador.Text = "Soy Administrador";
            this.BtnAdministrador.UseVisualStyleBackColor = true;
            this.BtnAdministrador.Click += new System.EventHandler(this.BtnAdministrador_Click);
            this.BtnAdministrador.MouseLeave += new System.EventHandler(this.BtnAdministrador_MouseLeave);
            this.BtnAdministrador.MouseMove += new System.Windows.Forms.MouseEventHandler(this.BtnAdministrador_MouseMove);
            // 
            // LbSeleccione
            // 
            this.LbSeleccione.AutoSize = true;
            this.LbSeleccione.Font = new System.Drawing.Font("Arial", 20F, System.Drawing.FontStyle.Bold);
            this.LbSeleccione.Location = new System.Drawing.Point(27, 47);
            this.LbSeleccione.Name = "LbSeleccione";
            this.LbSeleccione.Size = new System.Drawing.Size(749, 32);
            this.LbSeleccione.TabIndex = 3;
            this.LbSeleccione.Text = "Porfavor Seleccione el tipo de persona al que pertenece";
            // 
            // ValidacionPersona
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Lavender;
            this.ClientSize = new System.Drawing.Size(800, 314);
            this.Controls.Add(this.LbSeleccione);
            this.Controls.Add(this.BtnAdministrador);
            this.Controls.Add(this.BtnCliente);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "ValidacionPersona";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ValidacionPersona";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button BtnCliente;
        private System.Windows.Forms.Button BtnAdministrador;
        private System.Windows.Forms.Label LbSeleccione;
    }
}