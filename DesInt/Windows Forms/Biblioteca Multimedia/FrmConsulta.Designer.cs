namespace Biblioteca_Multimedia
{
    partial class FrmConsulta
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
            this.lblABuscar = new System.Windows.Forms.Label();
            this.tbBuscar = new System.Windows.Forms.TextBox();
            this.listview = new System.Windows.Forms.ListView();
            this.btnBusca = new System.Windows.Forms.Button();
            this.columnTitulo = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnTipo = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.SuspendLayout();
            // 
            // lblABuscar
            // 
            this.lblABuscar.AutoSize = true;
            this.lblABuscar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblABuscar.Location = new System.Drawing.Point(63, 63);
            this.lblABuscar.Name = "lblABuscar";
            this.lblABuscar.Size = new System.Drawing.Size(115, 16);
            this.lblABuscar.TabIndex = 0;
            this.lblABuscar.Text = "Texto a buscar:";
            // 
            // tbBuscar
            // 
            this.tbBuscar.Location = new System.Drawing.Point(242, 63);
            this.tbBuscar.Name = "tbBuscar";
            this.tbBuscar.Size = new System.Drawing.Size(243, 20);
            this.tbBuscar.TabIndex = 1;
            // 
            // listview
            // 
            this.listview.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnTitulo,
            this.columnTipo});
            this.listview.Location = new System.Drawing.Point(124, 160);
            this.listview.Name = "listview";
            this.listview.Size = new System.Drawing.Size(441, 189);
            this.listview.TabIndex = 2;
            this.listview.UseCompatibleStateImageBehavior = false;
            // 
            // btnBusca
            // 
            this.btnBusca.Location = new System.Drawing.Point(542, 63);
            this.btnBusca.Name = "btnBusca";
            this.btnBusca.Size = new System.Drawing.Size(88, 32);
            this.btnBusca.TabIndex = 3;
            this.btnBusca.Text = "Buscar";
            this.btnBusca.UseVisualStyleBackColor = true;
            // 
            // columnTitulo
            // 
            this.columnTitulo.Text = "Título";
            // 
            // columnTipo
            // 
            this.columnTipo.Text = "Tipo";
            // 
            // FrmConsulta
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(708, 482);
            this.Controls.Add(this.btnBusca);
            this.Controls.Add(this.listview);
            this.Controls.Add(this.tbBuscar);
            this.Controls.Add(this.lblABuscar);
            this.Name = "FrmConsulta";
            this.Text = "Consulta de elementos multimedia";
            this.Load += new System.EventHandler(this.FrmConsulta_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblABuscar;
        private System.Windows.Forms.TextBox tbBuscar;
        private System.Windows.Forms.ListView listview;
        private System.Windows.Forms.Button btnBusca;
        private System.Windows.Forms.ColumnHeader columnTitulo;
        private System.Windows.Forms.ColumnHeader columnTipo;
    }
}