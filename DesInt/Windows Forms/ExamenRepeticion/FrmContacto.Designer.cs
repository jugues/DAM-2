
namespace ExamenRepeticion
{
    partial class FrmContacto
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmContacto));
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.tsbBorrar = new System.Windows.Forms.ToolStripButton();
            this.tsbEditar = new System.Windows.Forms.ToolStripButton();
            this.lblContacto = new System.Windows.Forms.Label();
            this.lblCiudad = new System.Windows.Forms.Label();
            this.cbCiudad = new System.Windows.Forms.ComboBox();
            this.btnBuscarContacto = new System.Windows.Forms.Button();
            this.listViewContactos = new System.Windows.Forms.ListView();
            this.chNombre = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.chTipo = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.chTelefono = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.chCiudad = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.chContacto = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.tbContacto = new System.Windows.Forms.TextBox();
            this.toolStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // toolStrip1
            // 
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsbBorrar,
            this.tsbEditar});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(800, 25);
            this.toolStrip1.TabIndex = 0;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // tsbBorrar
            // 
            this.tsbBorrar.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.tsbBorrar.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.tsbBorrar.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbBorrar.Name = "tsbBorrar";
            this.tsbBorrar.Size = new System.Drawing.Size(43, 22);
            this.tsbBorrar.Text = "Borrar";
            this.tsbBorrar.TextImageRelation = System.Windows.Forms.TextImageRelation.Overlay;
            // 
            // tsbEditar
            // 
            this.tsbEditar.Image = ((System.Drawing.Image)(resources.GetObject("tsbEditar.Image")));
            this.tsbEditar.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbEditar.Name = "tsbEditar";
            this.tsbEditar.Size = new System.Drawing.Size(57, 22);
            this.tsbEditar.Text = "Editar";
            // 
            // lblContacto
            // 
            this.lblContacto.AutoSize = true;
            this.lblContacto.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblContacto.Location = new System.Drawing.Point(29, 66);
            this.lblContacto.Name = "lblContacto";
            this.lblContacto.Size = new System.Drawing.Size(104, 16);
            this.lblContacto.TabIndex = 1;
            this.lblContacto.Text = "Buscar contacto";
            // 
            // lblCiudad
            // 
            this.lblCiudad.AutoSize = true;
            this.lblCiudad.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCiudad.Location = new System.Drawing.Point(465, 66);
            this.lblCiudad.Name = "lblCiudad";
            this.lblCiudad.Size = new System.Drawing.Size(51, 16);
            this.lblCiudad.TabIndex = 2;
            this.lblCiudad.Text = "Ciudad";
            // 
            // cbCiudad
            // 
            this.cbCiudad.FormattingEnabled = true;
            this.cbCiudad.Location = new System.Drawing.Point(542, 67);
            this.cbCiudad.Name = "cbCiudad";
            this.cbCiudad.Size = new System.Drawing.Size(180, 21);
            this.cbCiudad.TabIndex = 3;
            // 
            // btnBuscarContacto
            // 
            this.btnBuscarContacto.Location = new System.Drawing.Point(381, 66);
            this.btnBuscarContacto.Name = "btnBuscarContacto";
            this.btnBuscarContacto.Size = new System.Drawing.Size(52, 21);
            this.btnBuscarContacto.TabIndex = 5;
            this.btnBuscarContacto.Text = ">";
            this.btnBuscarContacto.UseVisualStyleBackColor = true;
            this.btnBuscarContacto.Click += new System.EventHandler(this.btnBuscarContacto_Click);
            // 
            // listViewContactos
            // 
            this.listViewContactos.Activation = System.Windows.Forms.ItemActivation.OneClick;
            this.listViewContactos.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.chNombre,
            this.chTipo,
            this.chTelefono,
            this.chCiudad,
            this.chContacto});
            this.listViewContactos.HideSelection = false;
            this.listViewContactos.HotTracking = true;
            this.listViewContactos.HoverSelection = true;
            this.listViewContactos.Location = new System.Drawing.Point(26, 132);
            this.listViewContactos.Name = "listViewContactos";
            this.listViewContactos.Size = new System.Drawing.Size(751, 276);
            this.listViewContactos.TabIndex = 6;
            this.listViewContactos.UseCompatibleStateImageBehavior = false;
            this.listViewContactos.View = System.Windows.Forms.View.Details;
            // 
            // chNombre
            // 
            this.chNombre.Text = "Nombre";
            this.chNombre.Width = 115;
            // 
            // chTipo
            // 
            this.chTipo.Text = "Tipo";
            this.chTipo.Width = 93;
            // 
            // chTelefono
            // 
            this.chTelefono.Text = "Teléfono";
            this.chTelefono.Width = 97;
            // 
            // chCiudad
            // 
            this.chCiudad.Text = "Ciudad";
            this.chCiudad.Width = 117;
            // 
            // chContacto
            // 
            this.chContacto.Text = "Contacto";
            this.chContacto.Width = 109;
            // 
            // tbContacto
            // 
            this.tbContacto.Location = new System.Drawing.Point(153, 67);
            this.tbContacto.Name = "tbContacto";
            this.tbContacto.Size = new System.Drawing.Size(202, 20);
            this.tbContacto.TabIndex = 7;
            // 
            // FrmContacto
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.tbContacto);
            this.Controls.Add(this.listViewContactos);
            this.Controls.Add(this.btnBuscarContacto);
            this.Controls.Add(this.cbCiudad);
            this.Controls.Add(this.lblCiudad);
            this.Controls.Add(this.lblContacto);
            this.Controls.Add(this.toolStrip1);
            this.Name = "FrmContacto";
            this.Text = "FrmContacto";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FrmContacto_FormClosing);
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton tsbBorrar;
        private System.Windows.Forms.ToolStripButton tsbEditar;
        private System.Windows.Forms.Label lblContacto;
        private System.Windows.Forms.Label lblCiudad;
        private System.Windows.Forms.ComboBox cbCiudad;
        private System.Windows.Forms.Button btnBuscarContacto;
        private System.Windows.Forms.ListView listViewContactos;
        private System.Windows.Forms.ColumnHeader chNombre;
        private System.Windows.Forms.ColumnHeader chTipo;
        private System.Windows.Forms.ColumnHeader chTelefono;
        private System.Windows.Forms.ColumnHeader chCiudad;
        private System.Windows.Forms.ColumnHeader chContacto;
        private System.Windows.Forms.TextBox tbContacto;
    }
}