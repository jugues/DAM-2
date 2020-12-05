
namespace Gestión_Biblioteca
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.rbAutor = new System.Windows.Forms.RadioButton();
            this.rbEditorial = new System.Windows.Forms.RadioButton();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.pctbPortadaConsulta = new System.Windows.Forms.PictureBox();
            this.listboxAutorEditorial = new System.Windows.Forms.ListBox();
            this.listboxTitulo = new System.Windows.Forms.ListBox();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pctbPortadaConsulta)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.rbEditorial);
            this.groupBox1.Controls.Add(this.rbAutor);
            this.groupBox1.Location = new System.Drawing.Point(21, 33);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(443, 108);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Tipo de consulta";
            // 
            // rbAutor
            // 
            this.rbAutor.AutoSize = true;
            this.rbAutor.Location = new System.Drawing.Point(6, 37);
            this.rbAutor.Name = "rbAutor";
            this.rbAutor.Size = new System.Drawing.Size(50, 17);
            this.rbAutor.TabIndex = 0;
            this.rbAutor.TabStop = true;
            this.rbAutor.Text = "Autor";
            this.rbAutor.UseVisualStyleBackColor = true;
            this.rbAutor.CheckedChanged += new System.EventHandler(this.rbAutor_CheckedChanged);
            // 
            // rbEditorial
            // 
            this.rbEditorial.AutoSize = true;
            this.rbEditorial.Location = new System.Drawing.Point(6, 75);
            this.rbEditorial.Name = "rbEditorial";
            this.rbEditorial.Size = new System.Drawing.Size(62, 17);
            this.rbEditorial.TabIndex = 1;
            this.rbEditorial.TabStop = true;
            this.rbEditorial.Text = "Editorial";
            this.rbEditorial.UseVisualStyleBackColor = true;
            this.rbEditorial.CheckedChanged += new System.EventHandler(this.rbEditorial_CheckedChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(88, 278);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(47, 16);
            this.label1.TabIndex = 1;
            this.label1.Text = "Título";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(313, 278);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(107, 16);
            this.label2.TabIndex = 2;
            this.label2.Text = "Autor/Editorial";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(581, 278);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(63, 16);
            this.label3.TabIndex = 3;
            this.label3.Text = "Portada";
            // 
            // pctbPortadaConsulta
            // 
            this.pctbPortadaConsulta.Location = new System.Drawing.Point(536, 323);
            this.pctbPortadaConsulta.Name = "pctbPortadaConsulta";
            this.pctbPortadaConsulta.Size = new System.Drawing.Size(162, 212);
            this.pctbPortadaConsulta.TabIndex = 4;
            this.pctbPortadaConsulta.TabStop = false;
            // 
            // listboxAutorEditorial
            // 
            this.listboxAutorEditorial.FormattingEnabled = true;
            this.listboxAutorEditorial.Location = new System.Drawing.Point(289, 323);
            this.listboxAutorEditorial.Name = "listboxAutorEditorial";
            this.listboxAutorEditorial.Size = new System.Drawing.Size(175, 212);
            this.listboxAutorEditorial.TabIndex = 5;
            this.listboxAutorEditorial.SelectedIndexChanged += new System.EventHandler(this.listboxAutorEditorial_SelectedIndexChanged);
            // 
            // listboxTitulo
            // 
            this.listboxTitulo.FormattingEnabled = true;
            this.listboxTitulo.Location = new System.Drawing.Point(47, 323);
            this.listboxTitulo.Name = "listboxTitulo";
            this.listboxTitulo.Size = new System.Drawing.Size(175, 212);
            this.listboxTitulo.TabIndex = 6;
            this.listboxTitulo.SelectedIndexChanged += new System.EventHandler(this.listboxTitulo_SelectedIndexChanged);
            this.listboxTitulo.DoubleClick += new System.EventHandler(this.listboxTitulo_DoubleClick);
            // 
            // FrmConsulta
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(741, 646);
            this.Controls.Add(this.listboxTitulo);
            this.Controls.Add(this.listboxAutorEditorial);
            this.Controls.Add(this.pctbPortadaConsulta);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.groupBox1);
            this.Name = "FrmConsulta";
            this.Text = "FrmConsulta";
            this.Load += new System.EventHandler(this.FrmConsulta_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pctbPortadaConsulta)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton rbEditorial;
        private System.Windows.Forms.RadioButton rbAutor;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.PictureBox pctbPortadaConsulta;
        private System.Windows.Forms.ListBox listboxAutorEditorial;
        private System.Windows.Forms.ListBox listboxTitulo;
    }
}