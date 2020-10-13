namespace AppTrivial
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
            this.lblSuperior = new System.Windows.Forms.Label();
            this.lblInferior = new System.Windows.Forms.Label();
            this.txtCancionLibro = new System.Windows.Forms.TextBox();
            this.txtCorreccion = new System.Windows.Forms.TextBox();
            this.txtOpcion1 = new System.Windows.Forms.TextBox();
            this.txtOpcion2 = new System.Windows.Forms.TextBox();
            this.txtOpcion3 = new System.Windows.Forms.TextBox();
            this.txtOpcion4 = new System.Windows.Forms.TextBox();
            this.btnSiguiente = new System.Windows.Forms.Button();
            this.btnSalir = new System.Windows.Forms.Button();
            this.txtPorcentaje = new System.Windows.Forms.TextBox();
            this.partidaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.nuevaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.salirToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.opcionesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.nombreGruposToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.nombreLibrosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.múltiplesOpcionesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.escribirRespuestaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblSuperior
            // 
            this.lblSuperior.AutoSize = true;
            this.lblSuperior.Location = new System.Drawing.Point(22, 35);
            this.lblSuperior.Name = "lblSuperior";
            this.lblSuperior.Size = new System.Drawing.Size(49, 13);
            this.lblSuperior.TabIndex = 0;
            this.lblSuperior.Text = "Canción:";
            // 
            // lblInferior
            // 
            this.lblInferior.AutoSize = true;
            this.lblInferior.Location = new System.Drawing.Point(22, 145);
            this.lblInferior.Name = "lblInferior";
            this.lblInferior.Size = new System.Drawing.Size(39, 13);
            this.lblInferior.TabIndex = 1;
            this.lblInferior.Text = "Grupo:";
            // 
            // txtCancionLibro
            // 
            this.txtCancionLibro.Location = new System.Drawing.Point(73, 64);
            this.txtCancionLibro.Multiline = true;
            this.txtCancionLibro.Name = "txtCancionLibro";
            this.txtCancionLibro.Size = new System.Drawing.Size(259, 46);
            this.txtCancionLibro.TabIndex = 2;
            // 
            // txtCorreccion
            // 
            this.txtCorreccion.Location = new System.Drawing.Point(122, 142);
            this.txtCorreccion.Multiline = true;
            this.txtCorreccion.Name = "txtCorreccion";
            this.txtCorreccion.ReadOnly = true;
            this.txtCorreccion.Size = new System.Drawing.Size(156, 45);
            this.txtCorreccion.TabIndex = 3;
            this.txtCorreccion.TextChanged += new System.EventHandler(this.txtCorreccion_TextChanged);
            // 
            // txtOpcion1
            // 
            this.txtOpcion1.BackColor = System.Drawing.SystemColors.Control;
            this.txtOpcion1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtOpcion1.ForeColor = System.Drawing.SystemColors.WindowText;
            this.txtOpcion1.Location = new System.Drawing.Point(54, 250);
            this.txtOpcion1.Multiline = true;
            this.txtOpcion1.Name = "txtOpcion1";
            this.txtOpcion1.ReadOnly = true;
            this.txtOpcion1.Size = new System.Drawing.Size(278, 46);
            this.txtOpcion1.TabIndex = 4;
            this.txtOpcion1.Click += new System.EventHandler(this.txtOpcion1_Click);
            // 
            // txtOpcion2
            // 
            this.txtOpcion2.Location = new System.Drawing.Point(54, 318);
            this.txtOpcion2.Multiline = true;
            this.txtOpcion2.Name = "txtOpcion2";
            this.txtOpcion2.ReadOnly = true;
            this.txtOpcion2.Size = new System.Drawing.Size(278, 46);
            this.txtOpcion2.TabIndex = 5;
            this.txtOpcion2.Click += new System.EventHandler(this.TxtOpcion2_Click);
            this.txtOpcion2.TextChanged += new System.EventHandler(this.txtOpcion2_TextChanged);
            // 
            // txtOpcion3
            // 
            this.txtOpcion3.Location = new System.Drawing.Point(54, 385);
            this.txtOpcion3.Multiline = true;
            this.txtOpcion3.Name = "txtOpcion3";
            this.txtOpcion3.ReadOnly = true;
            this.txtOpcion3.Size = new System.Drawing.Size(278, 46);
            this.txtOpcion3.TabIndex = 6;
            this.txtOpcion3.Click += new System.EventHandler(this.TxtOpcion3_Click);
            this.txtOpcion3.TextChanged += new System.EventHandler(this.txtOpcion3_TextChanged);
            // 
            // txtOpcion4
            // 
            this.txtOpcion4.Location = new System.Drawing.Point(54, 458);
            this.txtOpcion4.Multiline = true;
            this.txtOpcion4.Name = "txtOpcion4";
            this.txtOpcion4.ReadOnly = true;
            this.txtOpcion4.Size = new System.Drawing.Size(278, 46);
            this.txtOpcion4.TabIndex = 7;
            this.txtOpcion4.Click += new System.EventHandler(this.TxtOpcion4_Click);
            this.txtOpcion4.TextChanged += new System.EventHandler(this.txtOpcion4_TextChanged);
            // 
            // btnSiguiente
            // 
            this.btnSiguiente.Location = new System.Drawing.Point(73, 543);
            this.btnSiguiente.Name = "btnSiguiente";
            this.btnSiguiente.Size = new System.Drawing.Size(121, 34);
            this.btnSiguiente.TabIndex = 8;
            this.btnSiguiente.Text = "Siguiente";
            this.btnSiguiente.UseVisualStyleBackColor = true;
            this.btnSiguiente.Click += new System.EventHandler(this.button1_Click);
            // 
            // btnSalir
            // 
            this.btnSalir.Location = new System.Drawing.Point(73, 583);
            this.btnSalir.Name = "btnSalir";
            this.btnSalir.Size = new System.Drawing.Size(121, 34);
            this.btnSalir.TabIndex = 9;
            this.btnSalir.Text = "Salir";
            this.btnSalir.UseVisualStyleBackColor = true;
            this.btnSalir.Click += new System.EventHandler(this.btnSalir_Click);
            // 
            // txtPorcentaje
            // 
            this.txtPorcentaje.Location = new System.Drawing.Point(238, 565);
            this.txtPorcentaje.Multiline = true;
            this.txtPorcentaje.Name = "txtPorcentaje";
            this.txtPorcentaje.ReadOnly = true;
            this.txtPorcentaje.Size = new System.Drawing.Size(62, 38);
            this.txtPorcentaje.TabIndex = 10;
            this.txtPorcentaje.TextChanged += new System.EventHandler(this.TxtPorcentaje_TextChanged);
            // 
            // partidaToolStripMenuItem
            // 
            this.partidaToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.nuevaToolStripMenuItem,
            this.toolStripSeparator1,
            this.salirToolStripMenuItem});
            this.partidaToolStripMenuItem.Name = "partidaToolStripMenuItem";
            this.partidaToolStripMenuItem.Size = new System.Drawing.Size(56, 20);
            this.partidaToolStripMenuItem.Text = "Partida";
            // 
            // nuevaToolStripMenuItem
            // 
            this.nuevaToolStripMenuItem.Name = "nuevaToolStripMenuItem";
            this.nuevaToolStripMenuItem.Size = new System.Drawing.Size(108, 22);
            this.nuevaToolStripMenuItem.Text = "Nueva";
            this.nuevaToolStripMenuItem.Click += new System.EventHandler(this.nuevaToolStripMenuItem_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(105, 6);
            // 
            // salirToolStripMenuItem
            // 
            this.salirToolStripMenuItem.Name = "salirToolStripMenuItem";
            this.salirToolStripMenuItem.Size = new System.Drawing.Size(108, 22);
            this.salirToolStripMenuItem.Text = "Salir";
            this.salirToolStripMenuItem.Click += new System.EventHandler(this.SalirToolStripMenuItem_Click);
            // 
            // opcionesToolStripMenuItem
            // 
            this.opcionesToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.nombreGruposToolStripMenuItem,
            this.nombreLibrosToolStripMenuItem,
            this.toolStripSeparator2,
            this.múltiplesOpcionesToolStripMenuItem,
            this.escribirRespuestaToolStripMenuItem});
            this.opcionesToolStripMenuItem.Name = "opcionesToolStripMenuItem";
            this.opcionesToolStripMenuItem.Size = new System.Drawing.Size(69, 20);
            this.opcionesToolStripMenuItem.Text = "Opciones";
            // 
            // nombreGruposToolStripMenuItem
            // 
            this.nombreGruposToolStripMenuItem.Checked = true;
            this.nombreGruposToolStripMenuItem.CheckOnClick = true;
            this.nombreGruposToolStripMenuItem.CheckState = System.Windows.Forms.CheckState.Checked;
            this.nombreGruposToolStripMenuItem.Name = "nombreGruposToolStripMenuItem";
            this.nombreGruposToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.nombreGruposToolStripMenuItem.Text = "Modo Grupos ";
            this.nombreGruposToolStripMenuItem.Click += new System.EventHandler(this.nombreGruposToolStripMenuItem_Click);
            // 
            // nombreLibrosToolStripMenuItem
            // 
            this.nombreLibrosToolStripMenuItem.CheckOnClick = true;
            this.nombreLibrosToolStripMenuItem.Name = "nombreLibrosToolStripMenuItem";
            this.nombreLibrosToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.nombreLibrosToolStripMenuItem.Text = "Modo Libros";
            this.nombreLibrosToolStripMenuItem.Click += new System.EventHandler(this.nombrePaísesToolStripMenuItem_Click);
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(177, 6);
            // 
            // múltiplesOpcionesToolStripMenuItem
            // 
            this.múltiplesOpcionesToolStripMenuItem.CheckOnClick = true;
            this.múltiplesOpcionesToolStripMenuItem.Name = "múltiplesOpcionesToolStripMenuItem";
            this.múltiplesOpcionesToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.múltiplesOpcionesToolStripMenuItem.Text = "Múltiples Opciones";
            this.múltiplesOpcionesToolStripMenuItem.Click += new System.EventHandler(this.múltiplesOpcionesToolStripMenuItem_Click);
            // 
            // escribirRespuestaToolStripMenuItem
            // 
            this.escribirRespuestaToolStripMenuItem.CheckOnClick = true;
            this.escribirRespuestaToolStripMenuItem.Name = "escribirRespuestaToolStripMenuItem";
            this.escribirRespuestaToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.escribirRespuestaToolStripMenuItem.Text = "Escribir Respuesta";
            this.escribirRespuestaToolStripMenuItem.Click += new System.EventHandler(this.escribirRespuestaToolStripMenuItem_Click);
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.partidaToolStripMenuItem,
            this.opcionesToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(382, 24);
            this.menuStrip1.TabIndex = 11;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(382, 663);
            this.Controls.Add(this.txtPorcentaje);
            this.Controls.Add(this.btnSalir);
            this.Controls.Add(this.btnSiguiente);
            this.Controls.Add(this.txtOpcion4);
            this.Controls.Add(this.txtOpcion3);
            this.Controls.Add(this.txtOpcion2);
            this.Controls.Add(this.txtOpcion1);
            this.Controls.Add(this.txtCorreccion);
            this.Controls.Add(this.txtCancionLibro);
            this.Controls.Add(this.lblInferior);
            this.Controls.Add(this.lblSuperior);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.Text = "Trivial";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblSuperior;
        private System.Windows.Forms.Label lblInferior;
        private System.Windows.Forms.TextBox txtCancionLibro;
        private System.Windows.Forms.TextBox txtCorreccion;
        private System.Windows.Forms.TextBox txtOpcion1;
        private System.Windows.Forms.TextBox txtOpcion2;
        private System.Windows.Forms.TextBox txtOpcion3;
        private System.Windows.Forms.TextBox txtOpcion4;
        private System.Windows.Forms.Button btnSiguiente;
        private System.Windows.Forms.Button btnSalir;
        private System.Windows.Forms.TextBox txtPorcentaje;
        private System.Windows.Forms.ToolStripMenuItem partidaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem nuevaToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripMenuItem salirToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem opcionesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem nombreGruposToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem nombreLibrosToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.ToolStripMenuItem múltiplesOpcionesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem escribirRespuestaToolStripMenuItem;
        private System.Windows.Forms.MenuStrip menuStrip1;
    }
}

