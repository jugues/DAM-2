namespace ExploradorArchivos
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.listviewFiles = new System.Windows.Forms.ListView();
            this.cNombre = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.cCreacion = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.cModificacion = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.cAcceso = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.treeviewDevices = new System.Windows.Forms.TreeView();
            this.imageList = new System.Windows.Forms.ImageList(this.components);
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.toolStripDropDownButton1 = new System.Windows.Forms.ToolStripDropDownButton();
            this.toolStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // listviewFiles
            // 
            this.listviewFiles.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.cNombre,
            this.cCreacion,
            this.cModificacion,
            this.cAcceso});
            this.listviewFiles.HideSelection = false;
            this.listviewFiles.Location = new System.Drawing.Point(351, 193);
            this.listviewFiles.Name = "listviewFiles";
            this.listviewFiles.Size = new System.Drawing.Size(379, 392);
            this.listviewFiles.TabIndex = 0;
            this.listviewFiles.UseCompatibleStateImageBehavior = false;
            this.listviewFiles.View = System.Windows.Forms.View.Details;
            // 
            // cNombre
            // 
            this.cNombre.Text = "Nombre";
            // 
            // cCreacion
            // 
            this.cCreacion.Text = "Fecha creación";
            this.cCreacion.Width = 85;
            // 
            // cModificacion
            // 
            this.cModificacion.Text = "Fecha modificación";
            this.cModificacion.Width = 137;
            // 
            // cAcceso
            // 
            this.cAcceso.Text = "Fecha acceso";
            this.cAcceso.Width = 120;
            // 
            // treeviewDevices
            // 
            this.treeviewDevices.ImageIndex = 0;
            this.treeviewDevices.ImageList = this.imageList;
            this.treeviewDevices.Location = new System.Drawing.Point(32, 193);
            this.treeviewDevices.Name = "treeviewDevices";
            this.treeviewDevices.SelectedImageIndex = 0;
            this.treeviewDevices.Size = new System.Drawing.Size(247, 392);
            this.treeviewDevices.TabIndex = 1;
            this.treeviewDevices.AfterSelect += new System.Windows.Forms.TreeViewEventHandler(this.treeviewDevices_AfterSelect);
            // 
            // imageList
            // 
            this.imageList.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imageList.ImageStream")));
            this.imageList.TransparentColor = System.Drawing.Color.Transparent;
            this.imageList.Images.SetKeyName(0, "hard.PNG");
            this.imageList.Images.SetKeyName(1, "folder.png");
            // 
            // toolStrip1
            // 
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripDropDownButton1});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(769, 25);
            this.toolStrip1.TabIndex = 2;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // toolStripDropDownButton1
            // 
            this.toolStripDropDownButton1.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripDropDownButton1.Image = ((System.Drawing.Image)(resources.GetObject("toolStripDropDownButton1.Image")));
            this.toolStripDropDownButton1.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripDropDownButton1.Name = "toolStripDropDownButton1";
            this.toolStripDropDownButton1.Size = new System.Drawing.Size(29, 22);
            this.toolStripDropDownButton1.Text = "Nuevo";
            this.toolStripDropDownButton1.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(769, 658);
            this.Controls.Add(this.toolStrip1);
            this.Controls.Add(this.treeviewDevices);
            this.Controls.Add(this.listviewFiles);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListView listviewFiles;
        private System.Windows.Forms.TreeView treeviewDevices;
        private System.Windows.Forms.ColumnHeader cNombre;
        private System.Windows.Forms.ColumnHeader cCreacion;
        private System.Windows.Forms.ColumnHeader cModificacion;
        private System.Windows.Forms.ColumnHeader cAcceso;
        private System.Windows.Forms.ImageList imageList;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripDropDownButton toolStripDropDownButton1;
    }
}

