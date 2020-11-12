namespace ListViewPrueba
{
    partial class Mercado
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
            this.lstvAlimentos = new System.Windows.Forms.ListView();
            this.btnAgregar = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.rbFrutas = new System.Windows.Forms.RadioButton();
            this.rbCarnes = new System.Windows.Forms.RadioButton();
            this.tbAgregar = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.lblSeleccionado = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // lstvAlimentos
            // 
            this.lstvAlimentos.Location = new System.Drawing.Point(27, 109);
            this.lstvAlimentos.Name = "lstvAlimentos";
            this.lstvAlimentos.Size = new System.Drawing.Size(185, 241);
            this.lstvAlimentos.TabIndex = 0;
            this.lstvAlimentos.UseCompatibleStateImageBehavior = false;
            this.lstvAlimentos.View = System.Windows.Forms.View.SmallIcon;
            // 
            // btnAgregar
            // 
            this.btnAgregar.Location = new System.Drawing.Point(100, 419);
            this.btnAgregar.Name = "btnAgregar";
            this.btnAgregar.Size = new System.Drawing.Size(92, 36);
            this.btnAgregar.TabIndex = 1;
            this.btnAgregar.Text = "Agregar";
            this.btnAgregar.UseVisualStyleBackColor = true;
            this.btnAgregar.Click += new System.EventHandler(this.BtnAgregar_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.rbCarnes);
            this.groupBox1.Controls.Add(this.rbFrutas);
            this.groupBox1.Location = new System.Drawing.Point(290, 375);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(200, 100);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Grupo";
            // 
            // rbFrutas
            // 
            this.rbFrutas.AutoSize = true;
            this.rbFrutas.Location = new System.Drawing.Point(6, 31);
            this.rbFrutas.Name = "rbFrutas";
            this.rbFrutas.Size = new System.Drawing.Size(54, 17);
            this.rbFrutas.TabIndex = 0;
            this.rbFrutas.TabStop = true;
            this.rbFrutas.Text = "Frutas";
            this.rbFrutas.UseVisualStyleBackColor = true;
            // 
            // rbCarnes
            // 
            this.rbCarnes.AutoSize = true;
            this.rbCarnes.Location = new System.Drawing.Point(6, 63);
            this.rbCarnes.Name = "rbCarnes";
            this.rbCarnes.Size = new System.Drawing.Size(58, 17);
            this.rbCarnes.TabIndex = 1;
            this.rbCarnes.TabStop = true;
            this.rbCarnes.Text = "Carnes";
            this.rbCarnes.UseVisualStyleBackColor = true;
            // 
            // tbAgregar
            // 
            this.tbAgregar.Location = new System.Drawing.Point(296, 316);
            this.tbAgregar.Name = "tbAgregar";
            this.tbAgregar.Size = new System.Drawing.Size(194, 20);
            this.tbAgregar.TabIndex = 2;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(398, 109);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(92, 38);
            this.button1.TabIndex = 3;
            this.button1.Text = "Limpiar";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // lblSeleccionado
            // 
            this.lblSeleccionado.AutoSize = true;
            this.lblSeleccionado.Location = new System.Drawing.Point(258, 109);
            this.lblSeleccionado.Name = "lblSeleccionado";
            this.lblSeleccionado.Size = new System.Drawing.Size(75, 13);
            this.lblSeleccionado.TabIndex = 4;
            this.lblSeleccionado.Text = "Seleccionado:";
            // 
            // Mercado
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(596, 530);
            this.Controls.Add(this.lblSeleccionado);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.tbAgregar);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.btnAgregar);
            this.Controls.Add(this.lstvAlimentos);
            this.Name = "Mercado";
            this.Text = "Mercado";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListView lstvAlimentos;
        private System.Windows.Forms.Button btnAgregar;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton rbCarnes;
        private System.Windows.Forms.RadioButton rbFrutas;
        private System.Windows.Forms.TextBox tbAgregar;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label lblSeleccionado;
    }
}

