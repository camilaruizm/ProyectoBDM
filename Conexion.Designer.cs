namespace ProyectoBDM
{
    partial class Conexion
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
            this.LbServidor = new System.Windows.Forms.Label();
            this.LbBaseDatos = new System.Windows.Forms.Label();
            this.TbServidor = new System.Windows.Forms.TextBox();
            this.TbBaseDatos = new System.Windows.Forms.TextBox();
            this.BtnConectar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // LbServidor
            // 
            this.LbServidor.AutoSize = true;
            this.LbServidor.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LbServidor.Location = new System.Drawing.Point(99, 25);
            this.LbServidor.Name = "LbServidor";
            this.LbServidor.Size = new System.Drawing.Size(123, 31);
            this.LbServidor.TabIndex = 0;
            this.LbServidor.Text = "Servidor:";
            // 
            // LbBaseDatos
            // 
            this.LbBaseDatos.AutoSize = true;
            this.LbBaseDatos.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LbBaseDatos.Location = new System.Drawing.Point(22, 90);
            this.LbBaseDatos.Name = "LbBaseDatos";
            this.LbBaseDatos.Size = new System.Drawing.Size(200, 31);
            this.LbBaseDatos.TabIndex = 1;
            this.LbBaseDatos.Text = "Base de Datos:";
            // 
            // TbServidor
            // 
            this.TbServidor.Location = new System.Drawing.Point(228, 36);
            this.TbServidor.Name = "TbServidor";
            this.TbServidor.Size = new System.Drawing.Size(195, 20);
            this.TbServidor.TabIndex = 2;
            // 
            // TbBaseDatos
            // 
            this.TbBaseDatos.Location = new System.Drawing.Point(228, 101);
            this.TbBaseDatos.Name = "TbBaseDatos";
            this.TbBaseDatos.Size = new System.Drawing.Size(195, 20);
            this.TbBaseDatos.TabIndex = 3;
            // 
            // BtnConectar
            // 
            this.BtnConectar.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnConectar.Location = new System.Drawing.Point(347, 159);
            this.BtnConectar.Name = "BtnConectar";
            this.BtnConectar.Size = new System.Drawing.Size(223, 75);
            this.BtnConectar.TabIndex = 4;
            this.BtnConectar.Text = "Conectar";
            this.BtnConectar.UseVisualStyleBackColor = true;
            this.BtnConectar.Click += new System.EventHandler(this.BtnConectar_Click);
            // 
            // Conexion
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(582, 246);
            this.Controls.Add(this.BtnConectar);
            this.Controls.Add(this.TbBaseDatos);
            this.Controls.Add(this.TbServidor);
            this.Controls.Add(this.LbBaseDatos);
            this.Controls.Add(this.LbServidor);
            this.Name = "Conexion";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label LbServidor;
        private System.Windows.Forms.Label LbBaseDatos;
        private System.Windows.Forms.TextBox TbServidor;
        private System.Windows.Forms.TextBox TbBaseDatos;
        private System.Windows.Forms.Button BtnConectar;
    }
}