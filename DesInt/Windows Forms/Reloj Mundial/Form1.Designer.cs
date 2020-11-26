namespace Reloj_Mundial
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
            this.paísToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.añadirTsItem = new System.Windows.Forms.ToolStripMenuItem();
            this.borrarTsItem = new System.Windows.Forms.ToolStripMenuItem();
            this.label1 = new System.Windows.Forms.Label();
            this.tbHora = new System.Windows.Forms.TextBox();
            this.lblDonde = new System.Windows.Forms.Label();
            this.lblZona = new System.Windows.Forms.Label();
            this.tbZona = new System.Windows.Forms.TextBox();
            this.timer = new System.Windows.Forms.Timer(this.components);
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.paísToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(547, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // paísToolStripMenuItem
            // 
            this.paísToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.añadirTsItem,
            this.borrarTsItem});
            this.paísToolStripMenuItem.Name = "paísToolStripMenuItem";
            this.paísToolStripMenuItem.Size = new System.Drawing.Size(40, 20);
            this.paísToolStripMenuItem.Text = "País";
            // 
            // añadirTsItem
            // 
            this.añadirTsItem.Name = "añadirTsItem";
            this.añadirTsItem.Size = new System.Drawing.Size(180, 22);
            this.añadirTsItem.Text = "Añadir";
            this.añadirTsItem.Click += new System.EventHandler(this.AñadirTsItem_Click);
            // 
            // borrarTsItem
            // 
            this.borrarTsItem.Name = "borrarTsItem";
            this.borrarTsItem.Size = new System.Drawing.Size(109, 22);
            this.borrarTsItem.Text = "Borrar";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(64, 53);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(41, 16);
            this.label1.TabIndex = 1;
            this.label1.Text = "Hora:";
            // 
            // tbHora
            // 
            this.tbHora.Location = new System.Drawing.Point(67, 90);
            this.tbHora.Multiline = true;
            this.tbHora.Name = "tbHora";
            this.tbHora.ReadOnly = true;
            this.tbHora.Size = new System.Drawing.Size(289, 48);
            this.tbHora.TabIndex = 2;
            // 
            // lblDonde
            // 
            this.lblDonde.AutoSize = true;
            this.lblDonde.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDonde.Location = new System.Drawing.Point(64, 171);
            this.lblDonde.Name = "lblDonde";
            this.lblDonde.Size = new System.Drawing.Size(56, 16);
            this.lblDonde.TabIndex = 3;
            this.lblDonde.Text = "Hora en";
            // 
            // lblZona
            // 
            this.lblZona.AutoSize = true;
            this.lblZona.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblZona.Location = new System.Drawing.Point(126, 171);
            this.lblZona.Name = "lblZona";
            this.lblZona.Size = new System.Drawing.Size(15, 16);
            this.lblZona.TabIndex = 4;
            this.lblZona.Text = "?";
            // 
            // tbZona
            // 
            this.tbZona.Location = new System.Drawing.Point(67, 206);
            this.tbZona.Multiline = true;
            this.tbZona.Name = "tbZona";
            this.tbZona.ReadOnly = true;
            this.tbZona.Size = new System.Drawing.Size(289, 48);
            this.tbZona.TabIndex = 5;
            // 
            // timer
            // 
            this.timer.Tick += new System.EventHandler(this.Timer_Tick);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(547, 340);
            this.Controls.Add(this.tbZona);
            this.Controls.Add(this.lblZona);
            this.Controls.Add(this.lblDonde);
            this.Controls.Add(this.tbHora);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.Text = "Reloj Mundial";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem paísToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem añadirTsItem;
        private System.Windows.Forms.ToolStripMenuItem borrarTsItem;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tbHora;
        private System.Windows.Forms.Label lblDonde;
        private System.Windows.Forms.Label lblZona;
        private System.Windows.Forms.TextBox tbZona;
        private System.Windows.Forms.Timer timer;
    }
}

