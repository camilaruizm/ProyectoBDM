namespace ProyectoBDM.Vista
{
    partial class consultasAdmin
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
            this.components = new System.ComponentModel.Container();
            this.panel1 = new System.Windows.Forms.Panel();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.clienteToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.préstamosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.enPréstamoActualmenteToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.historialDePréstamoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.actualmenteToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.porFechaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.caducadosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.panelEnPrestamoCli = new System.Windows.Forms.Panel();
            this.textBoxEnprestamo = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.dgvEnPrestamo = new System.Windows.Forms.DataGridView();
            this.panelHistorialCli = new System.Windows.Forms.Panel();
            this.dgvHistorialCli = new System.Windows.Forms.DataGridView();
            this.label2 = new System.Windows.Forms.Label();
            this.textBoxHistorialCli = new System.Windows.Forms.TextBox();
            this.buttonEnPrestamo = new System.Windows.Forms.Button();
            this.buttonHistorialCli = new System.Windows.Forms.Button();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.label5 = new System.Windows.Forms.Label();
            this.pCaducados = new System.Windows.Forms.Panel();
            this.label6 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.button3 = new System.Windows.Forms.Button();
            this.pPrestamoVig = new System.Windows.Forms.Panel();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.pFecha = new System.Windows.Forms.Panel();
            this.dateTimePicker2 = new System.Windows.Forms.DateTimePicker();
            this.label8 = new System.Windows.Forms.Label();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.label7 = new System.Windows.Forms.Label();
            this.button2 = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            this.panelEnPrestamoCli.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvEnPrestamo)).BeginInit();
            this.panelHistorialCli.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvHistorialCli)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.pCaducados.SuspendLayout();
            this.pPrestamoVig.SuspendLayout();
            this.pFecha.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.pPrestamoVig);
            this.panel1.Controls.Add(this.pFecha);
            this.panel1.Controls.Add(this.pCaducados);
            this.panel1.Controls.Add(this.panelHistorialCli);
            this.panel1.Controls.Add(this.menuStrip1);
            this.panel1.Controls.Add(this.panelEnPrestamoCli);
            this.panel1.Location = new System.Drawing.Point(29, 48);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(734, 250);
            this.panel1.TabIndex = 0;
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.clienteToolStripMenuItem,
            this.préstamosToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(734, 28);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // clienteToolStripMenuItem
            // 
            this.clienteToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.enPréstamoActualmenteToolStripMenuItem,
            this.historialDePréstamoToolStripMenuItem});
            this.clienteToolStripMenuItem.Name = "clienteToolStripMenuItem";
            this.clienteToolStripMenuItem.Size = new System.Drawing.Size(69, 24);
            this.clienteToolStripMenuItem.Text = "Cliente";
            this.clienteToolStripMenuItem.Click += new System.EventHandler(this.clienteToolStripMenuItem_Click);
            // 
            // préstamosToolStripMenuItem
            // 
            this.préstamosToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.actualmenteToolStripMenuItem,
            this.porFechaToolStripMenuItem,
            this.caducadosToolStripMenuItem});
            this.préstamosToolStripMenuItem.Name = "préstamosToolStripMenuItem";
            this.préstamosToolStripMenuItem.Size = new System.Drawing.Size(91, 24);
            this.préstamosToolStripMenuItem.Text = "Préstamos";
            // 
            // enPréstamoActualmenteToolStripMenuItem
            // 
            this.enPréstamoActualmenteToolStripMenuItem.Name = "enPréstamoActualmenteToolStripMenuItem";
            this.enPréstamoActualmenteToolStripMenuItem.Size = new System.Drawing.Size(261, 26);
            this.enPréstamoActualmenteToolStripMenuItem.Text = "En préstamo actualmente";
            this.enPréstamoActualmenteToolStripMenuItem.Click += new System.EventHandler(this.enPréstamoActualmenteToolStripMenuItem_Click);
            // 
            // historialDePréstamoToolStripMenuItem
            // 
            this.historialDePréstamoToolStripMenuItem.Name = "historialDePréstamoToolStripMenuItem";
            this.historialDePréstamoToolStripMenuItem.Size = new System.Drawing.Size(261, 26);
            this.historialDePréstamoToolStripMenuItem.Text = "Historial de préstamo";
            this.historialDePréstamoToolStripMenuItem.Click += new System.EventHandler(this.historialDePréstamoToolStripMenuItem_Click);
            // 
            // actualmenteToolStripMenuItem
            // 
            this.actualmenteToolStripMenuItem.Name = "actualmenteToolStripMenuItem";
            this.actualmenteToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.actualmenteToolStripMenuItem.Text = "Actualmente";
            this.actualmenteToolStripMenuItem.Click += new System.EventHandler(this.actualmenteToolStripMenuItem_Click);
            // 
            // porFechaToolStripMenuItem
            // 
            this.porFechaToolStripMenuItem.Name = "porFechaToolStripMenuItem";
            this.porFechaToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.porFechaToolStripMenuItem.Text = "Por fecha";
            this.porFechaToolStripMenuItem.Click += new System.EventHandler(this.porFechaToolStripMenuItem_Click);
            // 
            // caducadosToolStripMenuItem
            // 
            this.caducadosToolStripMenuItem.Name = "caducadosToolStripMenuItem";
            this.caducadosToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.caducadosToolStripMenuItem.Text = "Caducados";
            this.caducadosToolStripMenuItem.Click += new System.EventHandler(this.caducadosToolStripMenuItem_Click);
            // 
            // panelEnPrestamoCli
            // 
            this.panelEnPrestamoCli.BackColor = System.Drawing.Color.Yellow;
            this.panelEnPrestamoCli.Controls.Add(this.buttonEnPrestamo);
            this.panelEnPrestamoCli.Controls.Add(this.dgvEnPrestamo);
            this.panelEnPrestamoCli.Controls.Add(this.label1);
            this.panelEnPrestamoCli.Controls.Add(this.textBoxEnprestamo);
            this.panelEnPrestamoCli.Location = new System.Drawing.Point(233, 59);
            this.panelEnPrestamoCli.Name = "panelEnPrestamoCli";
            this.panelEnPrestamoCli.Size = new System.Drawing.Size(481, 169);
            this.panelEnPrestamoCli.TabIndex = 1;
            // 
            // textBoxEnprestamo
            // 
            this.textBoxEnprestamo.Location = new System.Drawing.Point(134, 16);
            this.textBoxEnprestamo.Name = "textBoxEnprestamo";
            this.textBoxEnprestamo.Size = new System.Drawing.Size(174, 22);
            this.textBoxEnprestamo.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(21, 18);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(107, 17);
            this.label1.TabIndex = 2;
            this.label1.Text = "Nombre cliente:";
            // 
            // dgvEnPrestamo
            // 
            this.dgvEnPrestamo.AllowUserToAddRows = false;
            this.dgvEnPrestamo.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvEnPrestamo.Location = new System.Drawing.Point(78, 55);
            this.dgvEnPrestamo.Name = "dgvEnPrestamo";
            this.dgvEnPrestamo.ReadOnly = true;
            this.dgvEnPrestamo.RowHeadersWidth = 51;
            this.dgvEnPrestamo.RowTemplate.Height = 24;
            this.dgvEnPrestamo.Size = new System.Drawing.Size(274, 99);
            this.dgvEnPrestamo.TabIndex = 3;
            // 
            // panelHistorialCli
            // 
            this.panelHistorialCli.BackColor = System.Drawing.Color.Blue;
            this.panelHistorialCli.Controls.Add(this.buttonHistorialCli);
            this.panelHistorialCli.Controls.Add(this.dgvHistorialCli);
            this.panelHistorialCli.Controls.Add(this.label2);
            this.panelHistorialCli.Controls.Add(this.textBoxHistorialCli);
            this.panelHistorialCli.Location = new System.Drawing.Point(66, 60);
            this.panelHistorialCli.Name = "panelHistorialCli";
            this.panelHistorialCli.Size = new System.Drawing.Size(481, 170);
            this.panelHistorialCli.TabIndex = 4;
            // 
            // dgvHistorialCli
            // 
            this.dgvHistorialCli.AllowUserToAddRows = false;
            this.dgvHistorialCli.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvHistorialCli.Location = new System.Drawing.Point(78, 58);
            this.dgvHistorialCli.Name = "dgvHistorialCli";
            this.dgvHistorialCli.ReadOnly = true;
            this.dgvHistorialCli.RowHeadersWidth = 51;
            this.dgvHistorialCli.RowTemplate.Height = 24;
            this.dgvHistorialCli.Size = new System.Drawing.Size(274, 88);
            this.dgvHistorialCli.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(21, 15);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(107, 17);
            this.label2.TabIndex = 2;
            this.label2.Text = "Nombre cliente:";
            // 
            // textBoxHistorialCli
            // 
            this.textBoxHistorialCli.Location = new System.Drawing.Point(134, 13);
            this.textBoxHistorialCli.Name = "textBoxHistorialCli";
            this.textBoxHistorialCli.Size = new System.Drawing.Size(174, 22);
            this.textBoxHistorialCli.TabIndex = 1;
            // 
            // buttonEnPrestamo
            // 
            this.buttonEnPrestamo.Location = new System.Drawing.Point(332, 14);
            this.buttonEnPrestamo.Name = "buttonEnPrestamo";
            this.buttonEnPrestamo.Size = new System.Drawing.Size(141, 23);
            this.buttonEnPrestamo.TabIndex = 4;
            this.buttonEnPrestamo.Text = "Buscar Cliente";
            this.buttonEnPrestamo.UseVisualStyleBackColor = true;
            this.buttonEnPrestamo.Click += new System.EventHandler(this.buttonEnPrestamo_Click);
            // 
            // buttonHistorialCli
            // 
            this.buttonHistorialCli.Location = new System.Drawing.Point(332, 11);
            this.buttonHistorialCli.Name = "buttonHistorialCli";
            this.buttonHistorialCli.Size = new System.Drawing.Size(141, 23);
            this.buttonHistorialCli.TabIndex = 5;
            this.buttonHistorialCli.Text = "Buscar Cliente";
            this.buttonHistorialCli.UseVisualStyleBackColor = true;
            this.buttonHistorialCli.Click += new System.EventHandler(this.buttonHistorialCli_Click);
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(29, 441);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(734, 120);
            this.dataGridView1.TabIndex = 7;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(32, 410);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(166, 17);
            this.label5.TabIndex = 8;
            this.label5.Text = "Resultados de búsqueda";
            // 
            // pCaducados
            // 
            this.pCaducados.BackColor = System.Drawing.Color.NavajoWhite;
            this.pCaducados.Controls.Add(this.label6);
            this.pCaducados.Controls.Add(this.label9);
            this.pCaducados.Controls.Add(this.button3);
            this.pCaducados.Location = new System.Drawing.Point(6, 120);
            this.pCaducados.Name = "pCaducados";
            this.pCaducados.Size = new System.Drawing.Size(481, 79);
            this.pCaducados.TabIndex = 8;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(285, 46);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(47, 17);
            this.label6.TabIndex = 7;
            this.label6.Text = "Fecha";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(82, 46);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(187, 17);
            this.label9.TabIndex = 6;
            this.label9.Text = "Prestamos caducados hasta";
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(171, 13);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(128, 23);
            this.button3.TabIndex = 5;
            this.button3.Text = "Buscar";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // pPrestamoVig
            // 
            this.pPrestamoVig.BackColor = System.Drawing.Color.MediumOrchid;
            this.pPrestamoVig.Controls.Add(this.label4);
            this.pPrestamoVig.Controls.Add(this.label3);
            this.pPrestamoVig.Controls.Add(this.button1);
            this.pPrestamoVig.Location = new System.Drawing.Point(235, 40);
            this.pPrestamoVig.Name = "pPrestamoVig";
            this.pPrestamoVig.Size = new System.Drawing.Size(481, 79);
            this.pPrestamoVig.TabIndex = 9;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(285, 46);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(47, 17);
            this.label4.TabIndex = 7;
            this.label4.Text = "Fecha";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(82, 46);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(171, 17);
            this.label3.TabIndex = 6;
            this.label3.Text = "Prestamos vigentes hasta";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(171, 13);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(128, 23);
            this.button1.TabIndex = 5;
            this.button1.Text = "Buscar";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // pFecha
            // 
            this.pFecha.BackColor = System.Drawing.Color.Olive;
            this.pFecha.Controls.Add(this.dateTimePicker2);
            this.pFecha.Controls.Add(this.label8);
            this.pFecha.Controls.Add(this.dateTimePicker1);
            this.pFecha.Controls.Add(this.label7);
            this.pFecha.Controls.Add(this.button2);
            this.pFecha.Location = new System.Drawing.Point(66, 158);
            this.pFecha.Name = "pFecha";
            this.pFecha.Size = new System.Drawing.Size(481, 89);
            this.pFecha.TabIndex = 11;
            // 
            // dateTimePicker2
            // 
            this.dateTimePicker2.CustomFormat = "yyyy-MM-dd";
            this.dateTimePicker2.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dateTimePicker2.Location = new System.Drawing.Point(304, 13);
            this.dateTimePicker2.Name = "dateTimePicker2";
            this.dateTimePicker2.Size = new System.Drawing.Size(90, 22);
            this.dateTimePicker2.TabIndex = 10;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(247, 15);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(49, 17);
            this.label8.TabIndex = 9;
            this.label8.Text = "Hasta:";
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.CustomFormat = "yyyy-MM-dd";
            this.dateTimePicker1.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dateTimePicker1.Location = new System.Drawing.Point(85, 13);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(90, 22);
            this.dateTimePicker1.TabIndex = 8;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(28, 15);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(53, 17);
            this.label7.TabIndex = 6;
            this.label7.Text = "Desde:";
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(170, 49);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(129, 23);
            this.button2.TabIndex = 5;
            this.button2.Text = "Buscar";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // consultasAdmin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 584);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.panel1);
            this.Name = "consultasAdmin";
            this.Text = "v";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.panelEnPrestamoCli.ResumeLayout(false);
            this.panelEnPrestamoCli.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvEnPrestamo)).EndInit();
            this.panelHistorialCli.ResumeLayout(false);
            this.panelHistorialCli.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvHistorialCli)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.pCaducados.ResumeLayout(false);
            this.pCaducados.PerformLayout();
            this.pPrestamoVig.ResumeLayout(false);
            this.pPrestamoVig.PerformLayout();
            this.pFecha.ResumeLayout(false);
            this.pFecha.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem clienteToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem enPréstamoActualmenteToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem historialDePréstamoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem préstamosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem actualmenteToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem porFechaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem caducadosToolStripMenuItem;
        private System.Windows.Forms.Panel panelEnPrestamoCli;
        private System.Windows.Forms.DataGridView dgvEnPrestamo;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBoxEnprestamo;
        private System.Windows.Forms.Panel panelHistorialCli;
        private System.Windows.Forms.DataGridView dgvHistorialCli;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBoxHistorialCli;
        private System.Windows.Forms.Button buttonEnPrestamo;
        private System.Windows.Forms.Button buttonHistorialCli;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Panel pCaducados;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Panel pFecha;
        private System.Windows.Forms.DateTimePicker dateTimePicker2;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Panel pPrestamoVig;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button button1;
    }
}