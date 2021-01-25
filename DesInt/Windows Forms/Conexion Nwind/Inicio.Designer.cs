
namespace Conexion_Emple
{
    partial class Inicio
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
            this.listboxProductos = new System.Windows.Forms.ListBox();
            this.btnConsulta = new System.Windows.Forms.Button();
            this.btnConsultaFrank = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // listboxProductos
            // 
            this.listboxProductos.FormattingEnabled = true;
            this.listboxProductos.Location = new System.Drawing.Point(64, 55);
            this.listboxProductos.Name = "listboxProductos";
            this.listboxProductos.Size = new System.Drawing.Size(198, 264);
            this.listboxProductos.TabIndex = 0;
            // 
            // btnConsulta
            // 
            this.btnConsulta.Location = new System.Drawing.Point(307, 72);
            this.btnConsulta.Name = "btnConsulta";
            this.btnConsulta.Size = new System.Drawing.Size(124, 44);
            this.btnConsulta.TabIndex = 1;
            this.btnConsulta.Text = "Consultar productos";
            this.btnConsulta.UseVisualStyleBackColor = true;
            this.btnConsulta.Click += new System.EventHandler(this.btnConsulta_Click);
            // 
            // btnConsultaFrank
            // 
            this.btnConsultaFrank.Location = new System.Drawing.Point(307, 122);
            this.btnConsultaFrank.Name = "btnConsultaFrank";
            this.btnConsultaFrank.Size = new System.Drawing.Size(124, 44);
            this.btnConsultaFrank.TabIndex = 2;
            this.btnConsultaFrank.Text = "Consultar Frank";
            this.btnConsultaFrank.UseVisualStyleBackColor = true;
            this.btnConsultaFrank.Click += new System.EventHandler(this.btnConsultaFrank_Click);
            // 
            // Inicio
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(776, 501);
            this.Controls.Add(this.btnConsultaFrank);
            this.Controls.Add(this.btnConsulta);
            this.Controls.Add(this.listboxProductos);
            this.Name = "Inicio";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Inicio_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListBox listboxProductos;
        private System.Windows.Forms.Button btnConsulta;
        private System.Windows.Forms.Button btnConsultaFrank;
    }
}

