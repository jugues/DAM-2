namespace Gestión_Biblioteca
{
    partial class Form1
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.ficheroToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.altaCtrlAToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.consultaCtrlCToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.lblHora = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ficheroToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(585, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // ficheroToolStripMenuItem
            // 
            this.ficheroToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.altaCtrlAToolStripMenuItem,
            this.consultaCtrlCToolStripMenuItem});
            this.ficheroToolStripMenuItem.Name = "ficheroToolStripMenuItem";
            this.ficheroToolStripMenuItem.Size = new System.Drawing.Size(61, 20);
            this.ficheroToolStripMenuItem.Text = "Fichero ";
            // 
            // altaCtrlAToolStripMenuItem
            // 
            this.altaCtrlAToolStripMenuItem.Name = "altaCtrlAToolStripMenuItem";
            this.altaCtrlAToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.altaCtrlAToolStripMenuItem.Text = "Alta  Ctrl+A";
            this.altaCtrlAToolStripMenuItem.Click += new System.EventHandler(this.AltaCtrlAToolStripMenuItem_Click);
            // 
            // consultaCtrlCToolStripMenuItem
            // 
            this.consultaCtrlCToolStripMenuItem.Name = "consultaCtrlCToolStripMenuItem";
            this.consultaCtrlCToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.consultaCtrlCToolStripMenuItem.Text = "Consulta  Ctrl+C";
            this.consultaCtrlCToolStripMenuItem.Click += new System.EventHandler(this.ConsultaCtrlCToolStripMenuItem_Click);
            // 
            // lblHora
            // 
            this.lblHora.AutoSize = true;
            this.lblHora.Location = new System.Drawing.Point(400, 323);
            this.lblHora.Name = "lblHora";
            this.lblHora.Size = new System.Drawing.Size(65, 13);
            this.lblHora.TabIndex = 1;
            this.lblHora.Text = "Hora actual:";
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Interval = 60000;
            this.timer1.Tick += new System.EventHandler(this.Timer1_Tick);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(585, 366);
            this.Controls.Add(this.lblHora);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.Text = "Gestión de Biblioteca";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem ficheroToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem altaCtrlAToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem consultaCtrlCToolStripMenuItem;
        private System.Windows.Forms.Label lblHora;
        private System.Windows.Forms.Timer timer1;
    }
}

