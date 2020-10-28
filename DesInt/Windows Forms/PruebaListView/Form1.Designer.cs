namespace PruebaListView
{
    partial class Principal
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
            this.miListView = new System.Windows.Forms.ListView();
            this.txtbCaja = new System.Windows.Forms.TextBox();
            this.gbGrupos = new System.Windows.Forms.GroupBox();
            this.rbLibros = new System.Windows.Forms.RadioButton();
            this.rbPelis = new System.Windows.Forms.RadioButton();
            this.btnAdicionar = new System.Windows.Forms.Button();
            this.btnLimpiar = new System.Windows.Forms.Button();
            this.lblSeleccionado = new System.Windows.Forms.Label();
            this.btnActualizar = new System.Windows.Forms.Button();
            this.btnBorrar = new System.Windows.Forms.Button();
            this.comboLibros = new System.Windows.Forms.ComboBox();
            this.comboPelis = new System.Windows.Forms.ComboBox();
            this.gbGrupos.SuspendLayout();
            this.SuspendLayout();
            // 
            // miListView
            // 
            this.miListView.HideSelection = false;
            this.miListView.Location = new System.Drawing.Point(41, 97);
            this.miListView.Name = "miListView";
            this.miListView.Size = new System.Drawing.Size(237, 368);
            this.miListView.TabIndex = 0;
            this.miListView.UseCompatibleStateImageBehavior = false;
            this.miListView.View = System.Windows.Forms.View.SmallIcon;
            // 
            // txtbCaja
            // 
            this.txtbCaja.Location = new System.Drawing.Point(353, 125);
            this.txtbCaja.Name = "txtbCaja";
            this.txtbCaja.Size = new System.Drawing.Size(231, 20);
            this.txtbCaja.TabIndex = 1;
            // 
            // gbGrupos
            // 
            this.gbGrupos.Controls.Add(this.btnAdicionar);
            this.gbGrupos.Controls.Add(this.rbPelis);
            this.gbGrupos.Controls.Add(this.rbLibros);
            this.gbGrupos.Location = new System.Drawing.Point(353, 245);
            this.gbGrupos.Name = "gbGrupos";
            this.gbGrupos.Size = new System.Drawing.Size(231, 130);
            this.gbGrupos.TabIndex = 2;
            this.gbGrupos.TabStop = false;
            this.gbGrupos.Text = "Grupos";
            // 
            // rbLibros
            // 
            this.rbLibros.AutoSize = true;
            this.rbLibros.Checked = true;
            this.rbLibros.Location = new System.Drawing.Point(18, 35);
            this.rbLibros.Name = "rbLibros";
            this.rbLibros.Size = new System.Drawing.Size(53, 17);
            this.rbLibros.TabIndex = 0;
            this.rbLibros.TabStop = true;
            this.rbLibros.Text = "Libros";
            this.rbLibros.UseVisualStyleBackColor = true;
            // 
            // rbPelis
            // 
            this.rbPelis.AutoSize = true;
            this.rbPelis.Location = new System.Drawing.Point(149, 35);
            this.rbPelis.Name = "rbPelis";
            this.rbPelis.Size = new System.Drawing.Size(47, 17);
            this.rbPelis.TabIndex = 1;
            this.rbPelis.Text = "Pelis";
            this.rbPelis.UseVisualStyleBackColor = true;
            // 
            // btnAdicionar
            // 
            this.btnAdicionar.Location = new System.Drawing.Point(70, 85);
            this.btnAdicionar.Name = "btnAdicionar";
            this.btnAdicionar.Size = new System.Drawing.Size(75, 23);
            this.btnAdicionar.TabIndex = 2;
            this.btnAdicionar.Text = "Añadir";
            this.btnAdicionar.UseVisualStyleBackColor = true;
            this.btnAdicionar.Click += new System.EventHandler(this.btnAdicionar_Click);
            // 
            // btnLimpiar
            // 
            this.btnLimpiar.Location = new System.Drawing.Point(371, 174);
            this.btnLimpiar.Name = "btnLimpiar";
            this.btnLimpiar.Size = new System.Drawing.Size(75, 23);
            this.btnLimpiar.TabIndex = 3;
            this.btnLimpiar.Text = "Limpiar";
            this.btnLimpiar.UseVisualStyleBackColor = true;
            this.btnLimpiar.Click += new System.EventHandler(this.btnLimpiar_Click);
            // 
            // lblSeleccionado
            // 
            this.lblSeleccionado.AutoSize = true;
            this.lblSeleccionado.Location = new System.Drawing.Point(420, 77);
            this.lblSeleccionado.Name = "lblSeleccionado";
            this.lblSeleccionado.Size = new System.Drawing.Size(100, 13);
            this.lblSeleccionado.TabIndex = 4;
            this.lblSeleccionado.Text = "Texto seleccionado";
            // 
            // btnActualizar
            // 
            this.btnActualizar.Location = new System.Drawing.Point(371, 203);
            this.btnActualizar.Name = "btnActualizar";
            this.btnActualizar.Size = new System.Drawing.Size(75, 23);
            this.btnActualizar.TabIndex = 5;
            this.btnActualizar.Text = "Actualizar";
            this.btnActualizar.UseVisualStyleBackColor = true;
            this.btnActualizar.Click += new System.EventHandler(this.btnActualizar_Click);
            // 
            // btnBorrar
            // 
            this.btnBorrar.Location = new System.Drawing.Point(474, 188);
            this.btnBorrar.Name = "btnBorrar";
            this.btnBorrar.Size = new System.Drawing.Size(75, 23);
            this.btnBorrar.TabIndex = 6;
            this.btnBorrar.Text = "Borrar elemento";
            this.btnBorrar.UseVisualStyleBackColor = true;
            this.btnBorrar.Click += new System.EventHandler(this.btnBorrar_Click);
            // 
            // comboLibros
            // 
            this.comboLibros.FormattingEnabled = true;
            this.comboLibros.Location = new System.Drawing.Point(353, 444);
            this.comboLibros.Name = "comboLibros";
            this.comboLibros.Size = new System.Drawing.Size(121, 21);
            this.comboLibros.TabIndex = 7;
            // 
            // comboPelis
            // 
            this.comboPelis.FormattingEnabled = true;
            this.comboPelis.Location = new System.Drawing.Point(502, 444);
            this.comboPelis.Name = "comboPelis";
            this.comboPelis.Size = new System.Drawing.Size(121, 21);
            this.comboPelis.TabIndex = 8;
            // 
            // Principal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(713, 616);
            this.Controls.Add(this.comboPelis);
            this.Controls.Add(this.comboLibros);
            this.Controls.Add(this.btnBorrar);
            this.Controls.Add(this.btnActualizar);
            this.Controls.Add(this.lblSeleccionado);
            this.Controls.Add(this.btnLimpiar);
            this.Controls.Add(this.gbGrupos);
            this.Controls.Add(this.txtbCaja);
            this.Controls.Add(this.miListView);
            this.Name = "Principal";
            this.Text = "Bibliofilmoteca";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.gbGrupos.ResumeLayout(false);
            this.gbGrupos.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListView miListView;
        private System.Windows.Forms.TextBox txtbCaja;
        private System.Windows.Forms.GroupBox gbGrupos;
        private System.Windows.Forms.RadioButton rbLibros;
        private System.Windows.Forms.RadioButton rbPelis;
        private System.Windows.Forms.Button btnAdicionar;
        private System.Windows.Forms.Button btnLimpiar;
        private System.Windows.Forms.Label lblSeleccionado;
        private System.Windows.Forms.Button btnActualizar;
        private System.Windows.Forms.Button btnBorrar;
        private System.Windows.Forms.ComboBox comboLibros;
        private System.Windows.Forms.ComboBox comboPelis;
    }
}

