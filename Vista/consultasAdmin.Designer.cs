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
            this.pPrestamoVig = new System.Windows.Forms.Panel();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.pFecha = new System.Windows.Forms.Panel();
            this.dateTimePicker2 = new System.Windows.Forms.DateTimePicker();
            this.label8 = new System.Windows.Forms.Label();
            this.prestamosFecha = new System.Windows.Forms.Button();
            this.pCaducados = new System.Windows.Forms.Panel();
            this.label6 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.button3 = new System.Windows.Forms.Button();
            this.panelHistorialCli = new System.Windows.Forms.Panel();
            this.buttonHistorialCli = new System.Windows.Forms.Button();
            this.dgvHistorialCli = new System.Windows.Forms.DataGridView();
            this.label2 = new System.Windows.Forms.Label();
            this.textBoxHistorialCli = new System.Windows.Forms.TextBox();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.clienteToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.enPréstamoActualmenteToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.historialDePréstamoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.préstamosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.actualmenteToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.porFechaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.caducadosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.panelEnPrestamoCli = new System.Windows.Forms.Panel();
            this.buttonEnPrestamo = new System.Windows.Forms.Button();
            this.dgvEnPrestamo = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.textBoxEnprestamo = new System.Windows.Forms.TextBox();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.label5 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.pPrestamoVig.SuspendLayout();
            this.pFecha.SuspendLayout();
            this.pCaducados.SuspendLayout();
            this.panelHistorialCli.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvHistorialCli)).BeginInit();
            this.menuStrip1.SuspendLayout();
            this.panelEnPrestamoCli.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvEnPrestamo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.pCaducados);
            this.panel1.Controls.Add(this.panelHistorialCli);
            this.panel1.Controls.Add(this.menuStrip1);
            this.panel1.Location = new System.Drawing.Point(22, 39);
            this.panel1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(550, 203);
            this.panel1.TabIndex = 0;
            // 
            // pPrestamoVig
            // 
            this.pPrestamoVig.BackColor = System.Drawing.Color.MediumOrchid;
            this.pPrestamoVig.Controls.Add(this.label4);
            this.pPrestamoVig.Controls.Add(this.label3);
            this.pPrestamoVig.Controls.Add(this.button1);
            this.pPrestamoVig.Location = new System.Drawing.Point(209, 20);
            this.pPrestamoVig.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.pPrestamoVig.Name = "pPrestamoVig";
            this.pPrestamoVig.Size = new System.Drawing.Size(361, 64);
            this.pPrestamoVig.TabIndex = 9;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(214, 37);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(37, 13);
            this.label4.TabIndex = 7;
            this.label4.Text = "Fecha";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(62, 37);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(128, 13);
            this.label3.TabIndex = 6;
            this.label3.Text = "Prestamos vigentes hasta";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(128, 11);
            this.button1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(96, 19);
            this.button1.TabIndex = 5;
            this.button1.Text = "Buscar";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // pFecha
            // 
            this.pFecha.BackColor = System.Drawing.Color.Olive;
            this.pFecha.Controls.Add(this.dateTimePicker2);
            this.pFecha.Controls.Add(this.label8);
            this.pFecha.Controls.Add(this.prestamosFecha);
            this.pFecha.Location = new System.Drawing.Point(211, 246);
            this.pFecha.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.pFecha.Name = "pFecha";
            this.pFecha.Size = new System.Drawing.Size(361, 72);
            this.pFecha.TabIndex = 11;
            // 
            // dateTimePicker2
            // 
            this.dateTimePicker2.CustomFormat = "yyyy-MM-dd";
            this.dateTimePicker2.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dateTimePicker2.Location = new System.Drawing.Point(207, 11);
            this.dateTimePicker2.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.dateTimePicker2.Name = "dateTimePicker2";
            this.dateTimePicker2.Size = new System.Drawing.Size(100, 20);
            this.dateTimePicker2.TabIndex = 10;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(89, 11);
            this.label8.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(114, 13);
            this.label8.TabIndex = 9;
            this.label8.Text = "Prestamos pedidos en:";
            // 
            // prestamosFecha
            // 
            this.prestamosFecha.Location = new System.Drawing.Point(128, 40);
            this.prestamosFecha.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.prestamosFecha.Name = "prestamosFecha";
            this.prestamosFecha.Size = new System.Drawing.Size(97, 19);
            this.prestamosFecha.TabIndex = 5;
            this.prestamosFecha.Text = "Buscar";
            this.prestamosFecha.UseVisualStyleBackColor = true;
            this.prestamosFecha.Click += new System.EventHandler(this.button2_Click);
            // 
            // pCaducados
            // 
            this.pCaducados.BackColor = System.Drawing.Color.NavajoWhite;
            this.pCaducados.Controls.Add(this.label6);
            this.pCaducados.Controls.Add(this.label9);
            this.pCaducados.Controls.Add(this.button3);
            this.pCaducados.Location = new System.Drawing.Point(2, 139);
            this.pCaducados.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.pCaducados.Name = "pCaducados";
            this.pCaducados.Size = new System.Drawing.Size(361, 64);
            this.pCaducados.TabIndex = 8;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(214, 37);
            this.label6.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(37, 13);
            this.label6.TabIndex = 7;
            this.label6.Text = "Fecha";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(62, 37);
            this.label9.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(141, 13);
            this.label9.TabIndex = 6;
            this.label9.Text = "Prestamos caducados hasta";
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(128, 11);
            this.button3.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(96, 19);
            this.button3.TabIndex = 5;
            this.button3.Text = "Buscar";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // panelHistorialCli
            // 
            this.panelHistorialCli.BackColor = System.Drawing.Color.Blue;
            this.panelHistorialCli.Controls.Add(this.buttonHistorialCli);
            this.panelHistorialCli.Controls.Add(this.dgvHistorialCli);
            this.panelHistorialCli.Controls.Add(this.label2);
            this.panelHistorialCli.Controls.Add(this.panelEnPrestamoCli);
            this.panelHistorialCli.Controls.Add(this.textBoxHistorialCli);
            this.panelHistorialCli.Location = new System.Drawing.Point(16, 31);
            this.panelHistorialCli.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.panelHistorialCli.Name = "panelHistorialCli";
            this.panelHistorialCli.Size = new System.Drawing.Size(361, 138);
            this.panelHistorialCli.TabIndex = 4;
            // 
            // buttonHistorialCli
            // 
            this.buttonHistorialCli.Location = new System.Drawing.Point(249, 9);
            this.buttonHistorialCli.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.buttonHistorialCli.Name = "buttonHistorialCli";
            this.buttonHistorialCli.Size = new System.Drawing.Size(106, 19);
            this.buttonHistorialCli.TabIndex = 5;
            this.buttonHistorialCli.Text = "Buscar Cliente";
            this.buttonHistorialCli.UseVisualStyleBackColor = true;
            this.buttonHistorialCli.Click += new System.EventHandler(this.buttonHistorialCli_Click);
            // 
            // dgvHistorialCli
            // 
            this.dgvHistorialCli.AllowUserToAddRows = false;
            this.dgvHistorialCli.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvHistorialCli.Location = new System.Drawing.Point(58, 47);
            this.dgvHistorialCli.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.dgvHistorialCli.Name = "dgvHistorialCli";
            this.dgvHistorialCli.ReadOnly = true;
            this.dgvHistorialCli.RowHeadersWidth = 51;
            this.dgvHistorialCli.RowTemplate.Height = 24;
            this.dgvHistorialCli.Size = new System.Drawing.Size(206, 72);
            this.dgvHistorialCli.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(16, 12);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(81, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Nombre cliente:";
            // 
            // textBoxHistorialCli
            // 
            this.textBoxHistorialCli.Location = new System.Drawing.Point(100, 11);
            this.textBoxHistorialCli.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.textBoxHistorialCli.Name = "textBoxHistorialCli";
            this.textBoxHistorialCli.Size = new System.Drawing.Size(132, 20);
            this.textBoxHistorialCli.TabIndex = 1;
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.clienteToolStripMenuItem,
            this.préstamosToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Padding = new System.Windows.Forms.Padding(4, 2, 0, 2);
            this.menuStrip1.Size = new System.Drawing.Size(550, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // clienteToolStripMenuItem
            // 
            this.clienteToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.enPréstamoActualmenteToolStripMenuItem,
            this.historialDePréstamoToolStripMenuItem});
            this.clienteToolStripMenuItem.Name = "clienteToolStripMenuItem";
            this.clienteToolStripMenuItem.Size = new System.Drawing.Size(56, 20);
            this.clienteToolStripMenuItem.Text = "Cliente";
            this.clienteToolStripMenuItem.Click += new System.EventHandler(this.clienteToolStripMenuItem_Click);
            // 
            // enPréstamoActualmenteToolStripMenuItem
            // 
            this.enPréstamoActualmenteToolStripMenuItem.Name = "enPréstamoActualmenteToolStripMenuItem";
            this.enPréstamoActualmenteToolStripMenuItem.Size = new System.Drawing.Size(209, 22);
            this.enPréstamoActualmenteToolStripMenuItem.Text = "En préstamo actualmente";
            this.enPréstamoActualmenteToolStripMenuItem.Click += new System.EventHandler(this.enPréstamoActualmenteToolStripMenuItem_Click);
            // 
            // historialDePréstamoToolStripMenuItem
            // 
            this.historialDePréstamoToolStripMenuItem.Name = "historialDePréstamoToolStripMenuItem";
            this.historialDePréstamoToolStripMenuItem.Size = new System.Drawing.Size(209, 22);
            this.historialDePréstamoToolStripMenuItem.Text = "Historial de préstamo";
            this.historialDePréstamoToolStripMenuItem.Click += new System.EventHandler(this.historialDePréstamoToolStripMenuItem_Click);
            // 
            // préstamosToolStripMenuItem
            // 
            this.préstamosToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.actualmenteToolStripMenuItem,
            this.porFechaToolStripMenuItem,
            this.caducadosToolStripMenuItem});
            this.préstamosToolStripMenuItem.Name = "préstamosToolStripMenuItem";
            this.préstamosToolStripMenuItem.Size = new System.Drawing.Size(74, 20);
            this.préstamosToolStripMenuItem.Text = "Préstamos";
            // 
            // actualmenteToolStripMenuItem
            // 
            this.actualmenteToolStripMenuItem.Name = "actualmenteToolStripMenuItem";
            this.actualmenteToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.actualmenteToolStripMenuItem.Text = "Actualmente";
            this.actualmenteToolStripMenuItem.Click += new System.EventHandler(this.actualmenteToolStripMenuItem_Click);
            // 
            // porFechaToolStripMenuItem
            // 
            this.porFechaToolStripMenuItem.Name = "porFechaToolStripMenuItem";
            this.porFechaToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.porFechaToolStripMenuItem.Text = "Por fecha";
            this.porFechaToolStripMenuItem.Click += new System.EventHandler(this.porFechaToolStripMenuItem_Click);
            // 
            // caducadosToolStripMenuItem
            // 
            this.caducadosToolStripMenuItem.Name = "caducadosToolStripMenuItem";
            this.caducadosToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
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
            this.panelEnPrestamoCli.Location = new System.Drawing.Point(203, 21);
            this.panelEnPrestamoCli.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.panelEnPrestamoCli.Name = "panelEnPrestamoCli";
            this.panelEnPrestamoCli.Size = new System.Drawing.Size(361, 137);
            this.panelEnPrestamoCli.TabIndex = 1;
            // 
            // buttonEnPrestamo
            // 
            this.buttonEnPrestamo.Location = new System.Drawing.Point(249, 11);
            this.buttonEnPrestamo.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.buttonEnPrestamo.Name = "buttonEnPrestamo";
            this.buttonEnPrestamo.Size = new System.Drawing.Size(106, 19);
            this.buttonEnPrestamo.TabIndex = 4;
            this.buttonEnPrestamo.Text = "Buscar Cliente";
            this.buttonEnPrestamo.UseVisualStyleBackColor = true;
            this.buttonEnPrestamo.Click += new System.EventHandler(this.buttonEnPrestamo_Click);
            // 
            // dgvEnPrestamo
            // 
            this.dgvEnPrestamo.AllowUserToAddRows = false;
            this.dgvEnPrestamo.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvEnPrestamo.Location = new System.Drawing.Point(58, 45);
            this.dgvEnPrestamo.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.dgvEnPrestamo.Name = "dgvEnPrestamo";
            this.dgvEnPrestamo.ReadOnly = true;
            this.dgvEnPrestamo.RowHeadersWidth = 51;
            this.dgvEnPrestamo.RowTemplate.Height = 24;
            this.dgvEnPrestamo.Size = new System.Drawing.Size(206, 80);
            this.dgvEnPrestamo.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(16, 15);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(81, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Nombre cliente:";
            // 
            // textBoxEnprestamo
            // 
            this.textBoxEnprestamo.Location = new System.Drawing.Point(100, 13);
            this.textBoxEnprestamo.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.textBoxEnprestamo.Name = "textBoxEnprestamo";
            this.textBoxEnprestamo.Size = new System.Drawing.Size(132, 20);
            this.textBoxEnprestamo.TabIndex = 1;
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(22, 358);
            this.dataGridView1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(550, 98);
            this.dataGridView1.TabIndex = 7;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(24, 333);
            this.label5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(125, 13);
            this.label5.TabIndex = 8;
            this.label5.Text = "Resultados de búsqueda";
            // 
            // consultasAdmin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(600, 474);
            this.Controls.Add(this.pPrestamoVig);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.pFecha);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.panel1);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "consultasAdmin";
            this.Text = "v";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.pPrestamoVig.ResumeLayout(false);
            this.pPrestamoVig.PerformLayout();
            this.pFecha.ResumeLayout(false);
            this.pFecha.PerformLayout();
            this.pCaducados.ResumeLayout(false);
            this.pCaducados.PerformLayout();
            this.panelHistorialCli.ResumeLayout(false);
            this.panelHistorialCli.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvHistorialCli)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.panelEnPrestamoCli.ResumeLayout(false);
            this.panelEnPrestamoCli.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvEnPrestamo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
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
        private System.Windows.Forms.Button prestamosFecha;
        private System.Windows.Forms.Panel pPrestamoVig;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button button1;
    }
}