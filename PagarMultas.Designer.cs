namespace ProyectoBDM
{
    partial class PagarMultas
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
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.nombrePagoMultas = new System.Windows.Forms.TextBox();
            this.valorPagoMulta = new System.Windows.Forms.TextBox();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(38, 36);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(141, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "NOMBRE DE QUIEN PAGA";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(38, 87);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(43, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "VALOR";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(38, 139);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(93, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "FECHA DE PAGO";
            // 
            // nombrePagoMultas
            // 
            this.nombrePagoMultas.Location = new System.Drawing.Point(232, 36);
            this.nombrePagoMultas.Name = "nombrePagoMultas";
            this.nombrePagoMultas.Size = new System.Drawing.Size(175, 20);
            this.nombrePagoMultas.TabIndex = 3;
            // 
            // valorPagoMulta
            // 
            this.valorPagoMulta.Location = new System.Drawing.Point(232, 87);
            this.valorPagoMulta.Name = "valorPagoMulta";
            this.valorPagoMulta.Size = new System.Drawing.Size(175, 20);
            this.valorPagoMulta.TabIndex = 4;
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Location = new System.Drawing.Point(232, 139);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(175, 20);
            this.dateTimePicker1.TabIndex = 5;
            // 
            // PagarMultas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(438, 204);
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.valorPagoMulta);
            this.Controls.Add(this.nombrePagoMultas);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "PagarMultas";
            this.Text = "PagarMultas";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox nombrePagoMultas;
        private System.Windows.Forms.TextBox valorPagoMulta;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
    }
}