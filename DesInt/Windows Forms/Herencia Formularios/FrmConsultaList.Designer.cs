
namespace Herencia_Formularios
{
    partial class FrmConsultaList
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
            this.comboCiudad = new System.Windows.Forms.ComboBox();
            this.comboVista = new System.Windows.Forms.ComboBox();
            this.lvConsultaList = new System.Windows.Forms.ListView();
            this.chNombre = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.chApellidos = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.chEmail = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.chComentario = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(131, 131);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(57, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "Ciudad";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(502, 131);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(43, 16);
            this.label2.TabIndex = 1;
            this.label2.Text = "Vista";
            // 
            // comboCiudad
            // 
            this.comboCiudad.FormattingEnabled = true;
            this.comboCiudad.Location = new System.Drawing.Point(60, 176);
            this.comboCiudad.Name = "comboCiudad";
            this.comboCiudad.Size = new System.Drawing.Size(220, 21);
            this.comboCiudad.TabIndex = 2;
            this.comboCiudad.SelectedIndexChanged += new System.EventHandler(this.comboCiudad_SelectedIndexChanged);
            // 
            // comboVista
            // 
            this.comboVista.FormattingEnabled = true;
            this.comboVista.Location = new System.Drawing.Point(424, 176);
            this.comboVista.Name = "comboVista";
            this.comboVista.Size = new System.Drawing.Size(200, 21);
            this.comboVista.TabIndex = 3;
            this.comboVista.SelectedIndexChanged += new System.EventHandler(this.comboVista_SelectedIndexChanged);
            // 
            // lvConsultaList
            // 
            this.lvConsultaList.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.chNombre,
            this.chApellidos,
            this.chEmail,
            this.chComentario});
            this.lvConsultaList.HideSelection = false;
            this.lvConsultaList.Location = new System.Drawing.Point(60, 284);
            this.lvConsultaList.Name = "lvConsultaList";
            this.lvConsultaList.Size = new System.Drawing.Size(604, 215);
            this.lvConsultaList.TabIndex = 4;
            this.lvConsultaList.UseCompatibleStateImageBehavior = false;
            // 
            // chNombre
            // 
            this.chNombre.Text = "Nombre";
            // 
            // chApellidos
            // 
            this.chApellidos.Text = "Apellidos";
            // 
            // chEmail
            // 
            this.chEmail.Text = "Email";
            // 
            // chComentario
            // 
            this.chComentario.Text = "Comentario";
            // 
            // FrmConsultaList
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(733, 599);
            this.Controls.Add(this.lvConsultaList);
            this.Controls.Add(this.comboVista);
            this.Controls.Add(this.comboCiudad);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "FrmConsultaList";
            this.Text = "FrmConsultaList";
            this.Load += new System.EventHandler(this.FrmConsultaList_Load);
            this.Controls.SetChildIndex(this.label1, 0);
            this.Controls.SetChildIndex(this.label2, 0);
            this.Controls.SetChildIndex(this.comboCiudad, 0);
            this.Controls.SetChildIndex(this.comboVista, 0);
            this.Controls.SetChildIndex(this.lvConsultaList, 0);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox comboCiudad;
        private System.Windows.Forms.ComboBox comboVista;
        private System.Windows.Forms.ListView lvConsultaList;
        private System.Windows.Forms.ColumnHeader chNombre;
        private System.Windows.Forms.ColumnHeader chApellidos;
        private System.Windows.Forms.ColumnHeader chEmail;
        private System.Windows.Forms.ColumnHeader chComentario;
    }
}