
namespace Herencia_Formularios
{
    partial class FrmConsultaTree
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
            this.tvConsulta = new System.Windows.Forms.TreeView();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.tbNombreConsulta = new System.Windows.Forms.TextBox();
            this.tbApellidosConsulta = new System.Windows.Forms.TextBox();
            this.tbCiudadConsulta = new System.Windows.Forms.TextBox();
            this.tbEmailConsulta = new System.Windows.Forms.TextBox();
            this.tbCoomentarioConsulta = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // tvConsulta
            // 
            this.tvConsulta.Location = new System.Drawing.Point(30, 190);
            this.tvConsulta.Name = "tvConsulta";
            this.tvConsulta.Size = new System.Drawing.Size(240, 314);
            this.tvConsulta.TabIndex = 0;
            this.tvConsulta.AfterSelect += new System.Windows.Forms.TreeViewEventHandler(this.tvConsulta_AfterSelect);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(410, 242);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(63, 16);
            this.label1.TabIndex = 1;
            this.label1.Text = "Nombre";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(410, 298);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(74, 16);
            this.label2.TabIndex = 2;
            this.label2.Text = "Apellidos";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(410, 358);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(57, 16);
            this.label3.TabIndex = 3;
            this.label3.Text = "Ciudad";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(410, 413);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(47, 16);
            this.label4.TabIndex = 4;
            this.label4.Text = "Email";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(410, 465);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(87, 16);
            this.label5.TabIndex = 5;
            this.label5.Text = "Comentario";
            // 
            // tbNombreConsulta
            // 
            this.tbNombreConsulta.Location = new System.Drawing.Point(535, 241);
            this.tbNombreConsulta.Name = "tbNombreConsulta";
            this.tbNombreConsulta.Size = new System.Drawing.Size(165, 20);
            this.tbNombreConsulta.TabIndex = 6;
            // 
            // tbApellidosConsulta
            // 
            this.tbApellidosConsulta.Location = new System.Drawing.Point(535, 298);
            this.tbApellidosConsulta.Name = "tbApellidosConsulta";
            this.tbApellidosConsulta.Size = new System.Drawing.Size(165, 20);
            this.tbApellidosConsulta.TabIndex = 7;
            // 
            // tbCiudadConsulta
            // 
            this.tbCiudadConsulta.Location = new System.Drawing.Point(535, 354);
            this.tbCiudadConsulta.Name = "tbCiudadConsulta";
            this.tbCiudadConsulta.Size = new System.Drawing.Size(165, 20);
            this.tbCiudadConsulta.TabIndex = 8;
            // 
            // tbEmailConsulta
            // 
            this.tbEmailConsulta.Location = new System.Drawing.Point(535, 409);
            this.tbEmailConsulta.Name = "tbEmailConsulta";
            this.tbEmailConsulta.Size = new System.Drawing.Size(165, 20);
            this.tbEmailConsulta.TabIndex = 9;
            // 
            // tbCoomentarioConsulta
            // 
            this.tbCoomentarioConsulta.Location = new System.Drawing.Point(535, 465);
            this.tbCoomentarioConsulta.Multiline = true;
            this.tbCoomentarioConsulta.Name = "tbCoomentarioConsulta";
            this.tbCoomentarioConsulta.Size = new System.Drawing.Size(165, 73);
            this.tbCoomentarioConsulta.TabIndex = 10;
            // 
            // FrmConsultaTree
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(733, 599);
            this.Controls.Add(this.tbCoomentarioConsulta);
            this.Controls.Add(this.tbEmailConsulta);
            this.Controls.Add(this.tbCiudadConsulta);
            this.Controls.Add(this.tbApellidosConsulta);
            this.Controls.Add(this.tbNombreConsulta);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.tvConsulta);
            this.Name = "FrmConsultaTree";
            this.Text = "FrmConsultaTree";
            this.Load += new System.EventHandler(this.FrmConsultaTree_Load);
            this.Controls.SetChildIndex(this.tvConsulta, 0);
            this.Controls.SetChildIndex(this.label1, 0);
            this.Controls.SetChildIndex(this.label2, 0);
            this.Controls.SetChildIndex(this.label3, 0);
            this.Controls.SetChildIndex(this.label4, 0);
            this.Controls.SetChildIndex(this.label5, 0);
            this.Controls.SetChildIndex(this.tbNombreConsulta, 0);
            this.Controls.SetChildIndex(this.tbApellidosConsulta, 0);
            this.Controls.SetChildIndex(this.tbCiudadConsulta, 0);
            this.Controls.SetChildIndex(this.tbEmailConsulta, 0);
            this.Controls.SetChildIndex(this.tbCoomentarioConsulta, 0);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TreeView tvConsulta;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox tbNombreConsulta;
        private System.Windows.Forms.TextBox tbApellidosConsulta;
        private System.Windows.Forms.TextBox tbCiudadConsulta;
        private System.Windows.Forms.TextBox tbEmailConsulta;
        private System.Windows.Forms.TextBox tbCoomentarioConsulta;
    }
}