namespace Gestión_Biblioteca
{
    partial class Form3
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.ficheroToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.altaCtrlAToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.consultaCtrlCToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ficheroToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(800, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // ficheroToolStripMenuItem
            // 
            this.ficheroToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.altaCtrlAToolStripMenuItem,
            this.consultaCtrlCToolStripMenuItem});
            this.ficheroToolStripMenuItem.Name = "ficheroToolStripMenuItem";
            this.ficheroToolStripMenuItem.Size = new System.Drawing.Size(58, 20);
            this.ficheroToolStripMenuItem.Text = "Fichero";
            // 
            // altaCtrlAToolStripMenuItem
            // 
            this.altaCtrlAToolStripMenuItem.Name = "altaCtrlAToolStripMenuItem";
            this.altaCtrlAToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.altaCtrlAToolStripMenuItem.Text = "Alta  Ctrl+A";
            // 
            // consultaCtrlCToolStripMenuItem
            // 
            this.consultaCtrlCToolStripMenuItem.Name = "consultaCtrlCToolStripMenuItem";
            this.consultaCtrlCToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.consultaCtrlCToolStripMenuItem.Text = "Consulta  Ctrl+C";
            // 
            // Form3
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form3";
            this.Text = "Form3";
            this.Load += new System.EventHandler(this.Form3_Load);
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
    }
}