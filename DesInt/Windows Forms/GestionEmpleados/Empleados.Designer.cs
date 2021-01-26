
namespace GestionEmpleados
{
    partial class Empleados
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Empleados));
            this.listBoxDepartamento = new System.Windows.Forms.ListBox();
            this.listBoxLocalizacion = new System.Windows.Forms.ListBox();
            this.lblDepart = new System.Windows.Forms.Label();
            this.lblLocalizacion = new System.Windows.Forms.Label();
            this.lblApellidos = new System.Windows.Forms.Label();
            this.lblOficio = new System.Windows.Forms.Label();
            this.lblSalario = new System.Windows.Forms.Label();
            this.lblFechaAlta = new System.Windows.Forms.Label();
            this.lblComision = new System.Windows.Forms.Label();
            this.textBoxApellidos = new System.Windows.Forms.TextBox();
            this.textBoxOficio = new System.Windows.Forms.TextBox();
            this.textBoxSalario = new System.Windows.Forms.TextBox();
            this.textBoxFechaAlta = new System.Windows.Forms.TextBox();
            this.textBoxComision = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.listBoxBuscarpor = new System.Windows.Forms.ListBox();
            this.label9 = new System.Windows.Forms.Label();
            this.tbBuscarPor = new System.Windows.Forms.TextBox();
            this.imageList1 = new System.Windows.Forms.ImageList(this.components);
            this.btnGuardar = new System.Windows.Forms.Button();
            this.btnBorrar = new System.Windows.Forms.Button();
            this.btnNuevo = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.listViewape = new System.Windows.Forms.ListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.listViewOfi = new System.Windows.Forms.ListView();
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.listViewSalario = new System.Windows.Forms.ListView();
            this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.listViewFechaAlta = new System.Windows.Forms.ListView();
            this.columnHeader4 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.listViewComision = new System.Windows.Forms.ListView();
            this.columnHeader5 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.listBox2 = new System.Windows.Forms.ListBox();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.btnSubir = new System.Windows.Forms.Button();
            this.btnBajar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // listBoxDepartamento
            // 
            this.listBoxDepartamento.FormattingEnabled = true;
            this.listBoxDepartamento.Location = new System.Drawing.Point(92, 59);
            this.listBoxDepartamento.Name = "listBoxDepartamento";
            this.listBoxDepartamento.Size = new System.Drawing.Size(120, 95);
            this.listBoxDepartamento.TabIndex = 0;
            this.listBoxDepartamento.SelectedIndexChanged += new System.EventHandler(this.listBoxDepartamento_SelectedIndexChanged);
            // 
            // listBoxLocalizacion
            // 
            this.listBoxLocalizacion.FormattingEnabled = true;
            this.listBoxLocalizacion.Location = new System.Drawing.Point(270, 59);
            this.listBoxLocalizacion.Name = "listBoxLocalizacion";
            this.listBoxLocalizacion.Size = new System.Drawing.Size(120, 95);
            this.listBoxLocalizacion.TabIndex = 1;
            // 
            // lblDepart
            // 
            this.lblDepart.AutoSize = true;
            this.lblDepart.Location = new System.Drawing.Point(99, 26);
            this.lblDepart.Name = "lblDepart";
            this.lblDepart.Size = new System.Drawing.Size(74, 13);
            this.lblDepart.TabIndex = 2;
            this.lblDepart.Text = "Departamento";
            // 
            // lblLocalizacion
            // 
            this.lblLocalizacion.AutoSize = true;
            this.lblLocalizacion.Location = new System.Drawing.Point(267, 26);
            this.lblLocalizacion.Name = "lblLocalizacion";
            this.lblLocalizacion.Size = new System.Drawing.Size(66, 13);
            this.lblLocalizacion.TabIndex = 3;
            this.lblLocalizacion.Text = "Localización";
            // 
            // lblApellidos
            // 
            this.lblApellidos.AutoSize = true;
            this.lblApellidos.Location = new System.Drawing.Point(89, 181);
            this.lblApellidos.Name = "lblApellidos";
            this.lblApellidos.Size = new System.Drawing.Size(49, 13);
            this.lblApellidos.TabIndex = 4;
            this.lblApellidos.Text = "Apellidos";
            // 
            // lblOficio
            // 
            this.lblOficio.AutoSize = true;
            this.lblOficio.Location = new System.Drawing.Point(186, 181);
            this.lblOficio.Name = "lblOficio";
            this.lblOficio.Size = new System.Drawing.Size(34, 13);
            this.lblOficio.TabIndex = 5;
            this.lblOficio.Text = "Oficio";
            // 
            // lblSalario
            // 
            this.lblSalario.AutoSize = true;
            this.lblSalario.Location = new System.Drawing.Point(284, 181);
            this.lblSalario.Name = "lblSalario";
            this.lblSalario.Size = new System.Drawing.Size(39, 13);
            this.lblSalario.TabIndex = 6;
            this.lblSalario.Text = "Salario";
            // 
            // lblFechaAlta
            // 
            this.lblFechaAlta.AutoSize = true;
            this.lblFechaAlta.Location = new System.Drawing.Point(382, 181);
            this.lblFechaAlta.Name = "lblFechaAlta";
            this.lblFechaAlta.Size = new System.Drawing.Size(58, 13);
            this.lblFechaAlta.TabIndex = 7;
            this.lblFechaAlta.Text = "Fecha Alta";
            // 
            // lblComision
            // 
            this.lblComision.AutoSize = true;
            this.lblComision.Location = new System.Drawing.Point(478, 181);
            this.lblComision.Name = "lblComision";
            this.lblComision.Size = new System.Drawing.Size(49, 13);
            this.lblComision.TabIndex = 8;
            this.lblComision.Text = "Comisión";
            // 
            // textBoxApellidos
            // 
            this.textBoxApellidos.Location = new System.Drawing.Point(92, 332);
            this.textBoxApellidos.Name = "textBoxApellidos";
            this.textBoxApellidos.Size = new System.Drawing.Size(81, 20);
            this.textBoxApellidos.TabIndex = 14;
            // 
            // textBoxOficio
            // 
            this.textBoxOficio.Location = new System.Drawing.Point(189, 332);
            this.textBoxOficio.Name = "textBoxOficio";
            this.textBoxOficio.Size = new System.Drawing.Size(72, 20);
            this.textBoxOficio.TabIndex = 15;
            // 
            // textBoxSalario
            // 
            this.textBoxSalario.Location = new System.Drawing.Point(287, 332);
            this.textBoxSalario.Name = "textBoxSalario";
            this.textBoxSalario.Size = new System.Drawing.Size(72, 20);
            this.textBoxSalario.TabIndex = 16;
            // 
            // textBoxFechaAlta
            // 
            this.textBoxFechaAlta.Location = new System.Drawing.Point(385, 332);
            this.textBoxFechaAlta.Name = "textBoxFechaAlta";
            this.textBoxFechaAlta.Size = new System.Drawing.Size(75, 20);
            this.textBoxFechaAlta.TabIndex = 17;
            // 
            // textBoxComision
            // 
            this.textBoxComision.Location = new System.Drawing.Point(481, 332);
            this.textBoxComision.Name = "textBoxComision";
            this.textBoxComision.Size = new System.Drawing.Size(75, 20);
            this.textBoxComision.TabIndex = 18;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(92, 424);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(58, 13);
            this.label8.TabIndex = 19;
            this.label8.Text = "Buscar por";
            // 
            // listBoxBuscarpor
            // 
            this.listBoxBuscarpor.FormattingEnabled = true;
            this.listBoxBuscarpor.Location = new System.Drawing.Point(169, 392);
            this.listBoxBuscarpor.Name = "listBoxBuscarpor";
            this.listBoxBuscarpor.Size = new System.Drawing.Size(81, 82);
            this.listBoxBuscarpor.TabIndex = 20;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(270, 423);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(21, 24);
            this.label9.TabIndex = 21;
            this.label9.Text = "=";
            // 
            // tbBuscarPor
            // 
            this.tbBuscarPor.Location = new System.Drawing.Point(297, 427);
            this.tbBuscarPor.Name = "tbBuscarPor";
            this.tbBuscarPor.Size = new System.Drawing.Size(100, 20);
            this.tbBuscarPor.TabIndex = 22;
            // 
            // imageList1
            // 
            this.imageList1.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imageList1.ImageStream")));
            this.imageList1.TransparentColor = System.Drawing.Color.DarkGray;
            this.imageList1.Images.SetKeyName(0, "Busqueda.png");
            this.imageList1.Images.SetKeyName(1, "estrella.png");
            this.imageList1.Images.SetKeyName(2, "guardar.png");
            this.imageList1.Images.SetKeyName(3, "prohibido.png");
            this.imageList1.Images.SetKeyName(4, "descarga.jpg");
            this.imageList1.Images.SetKeyName(5, "images.png");
            // 
            // btnGuardar
            // 
            this.btnGuardar.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnGuardar.ImageIndex = 2;
            this.btnGuardar.ImageList = this.imageList1;
            this.btnGuardar.Location = new System.Drawing.Point(617, 281);
            this.btnGuardar.Name = "btnGuardar";
            this.btnGuardar.Size = new System.Drawing.Size(75, 55);
            this.btnGuardar.TabIndex = 26;
            this.btnGuardar.Text = "Guardar";
            this.btnGuardar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btnGuardar.UseVisualStyleBackColor = true;
            this.btnGuardar.Click += new System.EventHandler(this.button4_Click);
            // 
            // btnBorrar
            // 
            this.btnBorrar.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnBorrar.ImageKey = "prohibido.png";
            this.btnBorrar.ImageList = this.imageList1;
            this.btnBorrar.Location = new System.Drawing.Point(617, 342);
            this.btnBorrar.Name = "btnBorrar";
            this.btnBorrar.Size = new System.Drawing.Size(75, 55);
            this.btnBorrar.TabIndex = 25;
            this.btnBorrar.Text = "Borrar";
            this.btnBorrar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btnBorrar.UseVisualStyleBackColor = true;
            this.btnBorrar.Click += new System.EventHandler(this.button3_Click);
            // 
            // btnNuevo
            // 
            this.btnNuevo.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnNuevo.ImageKey = "estrella.png";
            this.btnNuevo.ImageList = this.imageList1;
            this.btnNuevo.Location = new System.Drawing.Point(617, 403);
            this.btnNuevo.Name = "btnNuevo";
            this.btnNuevo.Size = new System.Drawing.Size(75, 55);
            this.btnNuevo.TabIndex = 24;
            this.btnNuevo.Text = "Nuevo";
            this.btnNuevo.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btnNuevo.UseVisualStyleBackColor = true;
            this.btnNuevo.Click += new System.EventHandler(this.button2_Click);
            // 
            // button1
            // 
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button1.ImageIndex = 0;
            this.button1.ImageList = this.imageList1;
            this.button1.Location = new System.Drawing.Point(439, 409);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 55);
            this.button1.TabIndex = 23;
            this.button1.Text = "Buscar\r\n";
            this.button1.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // listViewape
            // 
            this.listViewape.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1});
            this.listViewape.HeaderStyle = System.Windows.Forms.ColumnHeaderStyle.None;
            this.listViewape.HideSelection = false;
            this.listViewape.Location = new System.Drawing.Point(92, 221);
            this.listViewape.Name = "listViewape";
            this.listViewape.Size = new System.Drawing.Size(81, 82);
            this.listViewape.TabIndex = 27;
            this.listViewape.UseCompatibleStateImageBehavior = false;
            this.listViewape.View = System.Windows.Forms.View.Details;
            this.listViewape.Click += new System.EventHandler(this.listViewape_Click);
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "";
            this.columnHeader1.Width = 77;
            // 
            // listViewOfi
            // 
            this.listViewOfi.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader2});
            this.listViewOfi.HeaderStyle = System.Windows.Forms.ColumnHeaderStyle.None;
            this.listViewOfi.HideSelection = false;
            this.listViewOfi.Location = new System.Drawing.Point(189, 221);
            this.listViewOfi.Name = "listViewOfi";
            this.listViewOfi.Size = new System.Drawing.Size(81, 82);
            this.listViewOfi.TabIndex = 28;
            this.listViewOfi.UseCompatibleStateImageBehavior = false;
            this.listViewOfi.View = System.Windows.Forms.View.Details;
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "";
            this.columnHeader2.Width = 77;
            // 
            // listViewSalario
            // 
            this.listViewSalario.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader3});
            this.listViewSalario.HeaderStyle = System.Windows.Forms.ColumnHeaderStyle.None;
            this.listViewSalario.HideSelection = false;
            this.listViewSalario.Location = new System.Drawing.Point(287, 221);
            this.listViewSalario.Name = "listViewSalario";
            this.listViewSalario.Size = new System.Drawing.Size(81, 82);
            this.listViewSalario.TabIndex = 29;
            this.listViewSalario.UseCompatibleStateImageBehavior = false;
            this.listViewSalario.View = System.Windows.Forms.View.Details;
            // 
            // columnHeader3
            // 
            this.columnHeader3.Text = "";
            this.columnHeader3.Width = 77;
            // 
            // listViewFechaAlta
            // 
            this.listViewFechaAlta.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader4});
            this.listViewFechaAlta.HeaderStyle = System.Windows.Forms.ColumnHeaderStyle.None;
            this.listViewFechaAlta.HideSelection = false;
            this.listViewFechaAlta.Location = new System.Drawing.Point(385, 221);
            this.listViewFechaAlta.Name = "listViewFechaAlta";
            this.listViewFechaAlta.Size = new System.Drawing.Size(81, 82);
            this.listViewFechaAlta.TabIndex = 30;
            this.listViewFechaAlta.UseCompatibleStateImageBehavior = false;
            this.listViewFechaAlta.View = System.Windows.Forms.View.Details;
            // 
            // columnHeader4
            // 
            this.columnHeader4.Text = "";
            this.columnHeader4.Width = 77;
            // 
            // listViewComision
            // 
            this.listViewComision.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader5});
            this.listViewComision.HeaderStyle = System.Windows.Forms.ColumnHeaderStyle.None;
            this.listViewComision.HideSelection = false;
            this.listViewComision.Location = new System.Drawing.Point(481, 221);
            this.listViewComision.Name = "listViewComision";
            this.listViewComision.Size = new System.Drawing.Size(81, 82);
            this.listViewComision.TabIndex = 31;
            this.listViewComision.UseCompatibleStateImageBehavior = false;
            this.listViewComision.View = System.Windows.Forms.View.Details;
            // 
            // columnHeader5
            // 
            this.columnHeader5.Text = "";
            this.columnHeader5.Width = 77;
            // 
            // listBox2
            // 
            this.listBox2.FormattingEnabled = true;
            this.listBox2.Location = new System.Drawing.Point(12, 59);
            this.listBox2.Name = "listBox2";
            this.listBox2.Size = new System.Drawing.Size(58, 95);
            this.listBox2.TabIndex = 33;
            // 
            // btnSubir
            // 
            this.btnSubir.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnSubir.ImageKey = "images.png";
            this.btnSubir.ImageList = this.imageList1;
            this.btnSubir.Location = new System.Drawing.Point(617, 210);
            this.btnSubir.Name = "btnSubir";
            this.btnSubir.Size = new System.Drawing.Size(75, 47);
            this.btnSubir.TabIndex = 34;
            this.btnSubir.Text = "Subir";
            this.btnSubir.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btnSubir.UseVisualStyleBackColor = true;
            // 
            // btnBajar
            // 
            this.btnBajar.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnBajar.ImageKey = "descarga.jpg";
            this.btnBajar.ImageList = this.imageList1;
            this.btnBajar.Location = new System.Drawing.Point(617, 146);
            this.btnBajar.Name = "btnBajar";
            this.btnBajar.Size = new System.Drawing.Size(75, 48);
            this.btnBajar.TabIndex = 35;
            this.btnBajar.Text = "Bajar";
            this.btnBajar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btnBajar.UseVisualStyleBackColor = true;
            this.btnBajar.Click += new System.EventHandler(this.btnBajar_Click);
            // 
            // Empleados
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 502);
            this.Controls.Add(this.btnBajar);
            this.Controls.Add(this.btnSubir);
            this.Controls.Add(this.listBox2);
            this.Controls.Add(this.listViewComision);
            this.Controls.Add(this.listViewFechaAlta);
            this.Controls.Add(this.listViewSalario);
            this.Controls.Add(this.listViewOfi);
            this.Controls.Add(this.listViewape);
            this.Controls.Add(this.btnGuardar);
            this.Controls.Add(this.btnBorrar);
            this.Controls.Add(this.btnNuevo);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.tbBuscarPor);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.listBoxBuscarpor);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.textBoxComision);
            this.Controls.Add(this.textBoxFechaAlta);
            this.Controls.Add(this.textBoxSalario);
            this.Controls.Add(this.textBoxOficio);
            this.Controls.Add(this.textBoxApellidos);
            this.Controls.Add(this.lblComision);
            this.Controls.Add(this.lblFechaAlta);
            this.Controls.Add(this.lblSalario);
            this.Controls.Add(this.lblOficio);
            this.Controls.Add(this.lblApellidos);
            this.Controls.Add(this.lblLocalizacion);
            this.Controls.Add(this.lblDepart);
            this.Controls.Add(this.listBoxLocalizacion);
            this.Controls.Add(this.listBoxDepartamento);
            this.Name = "Empleados";
            this.Text = "Gestión Empleados";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox listBoxDepartamento;
        private System.Windows.Forms.ListBox listBoxLocalizacion;
        private System.Windows.Forms.Label lblDepart;
        private System.Windows.Forms.Label lblLocalizacion;
        private System.Windows.Forms.Label lblApellidos;
        private System.Windows.Forms.Label lblOficio;
        private System.Windows.Forms.Label lblSalario;
        private System.Windows.Forms.Label lblFechaAlta;
        private System.Windows.Forms.Label lblComision;
        private System.Windows.Forms.TextBox textBoxApellidos;
        private System.Windows.Forms.TextBox textBoxOficio;
        private System.Windows.Forms.TextBox textBoxSalario;
        private System.Windows.Forms.TextBox textBoxFechaAlta;
        private System.Windows.Forms.TextBox textBoxComision;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.ListBox listBoxBuscarpor;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox tbBuscarPor;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.ImageList imageList1;
        private System.Windows.Forms.Button btnNuevo;
        private System.Windows.Forms.Button btnBorrar;
        private System.Windows.Forms.Button btnGuardar;
        private System.Windows.Forms.ListView listViewape;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ListView listViewOfi;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.ListView listViewSalario;
        private System.Windows.Forms.ColumnHeader columnHeader3;
        private System.Windows.Forms.ListView listViewFechaAlta;
        private System.Windows.Forms.ColumnHeader columnHeader4;
        private System.Windows.Forms.ListView listViewComision;
        private System.Windows.Forms.ColumnHeader columnHeader5;
        private System.Windows.Forms.ListBox listBox2;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.Button btnSubir;
        private System.Windows.Forms.Button btnBajar;
    }
}

