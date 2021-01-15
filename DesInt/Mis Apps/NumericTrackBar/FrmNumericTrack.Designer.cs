
namespace NumericTrackBar
{
    partial class FrmNumericTrack
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
            this.lblPersonas = new System.Windows.Forms.Label();
            this.lblDinero = new System.Windows.Forms.Label();
            this.numericUpDownDinero = new System.Windows.Forms.NumericUpDown();
            this.trackbarPersonas = new System.Windows.Forms.TrackBar();
            this.lblPersonasMostrar = new System.Windows.Forms.Label();
            this.progressBar1 = new System.Windows.Forms.ProgressBar();
            this.btnValidar = new System.Windows.Forms.Button();
            this.lblMostrarPersonas = new System.Windows.Forms.Label();
            this.timerBarra = new System.Windows.Forms.Timer(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownDinero)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackbarPersonas)).BeginInit();
            this.SuspendLayout();
            // 
            // lblPersonas
            // 
            this.lblPersonas.AutoSize = true;
            this.lblPersonas.Font = new System.Drawing.Font("Microsoft YaHei", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPersonas.Location = new System.Drawing.Point(47, 114);
            this.lblPersonas.Name = "lblPersonas";
            this.lblPersonas.Size = new System.Drawing.Size(165, 19);
            this.lblPersonas.TabIndex = 0;
            this.lblPersonas.Text = "Indique el nº de personas";
            // 
            // lblDinero
            // 
            this.lblDinero.AutoSize = true;
            this.lblDinero.Font = new System.Drawing.Font("Microsoft YaHei", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDinero.Location = new System.Drawing.Point(47, 174);
            this.lblDinero.Name = "lblDinero";
            this.lblDinero.Size = new System.Drawing.Size(238, 19);
            this.lblDinero.TabIndex = 2;
            this.lblDinero.Text = "Indique el dinero que pueden aportar";
            // 
            // numericUpDownDinero
            // 
            this.numericUpDownDinero.Location = new System.Drawing.Point(314, 173);
            this.numericUpDownDinero.Name = "numericUpDownDinero";
            this.numericUpDownDinero.Size = new System.Drawing.Size(45, 20);
            this.numericUpDownDinero.TabIndex = 3;
            // 
            // trackbarPersonas
            // 
            this.trackbarPersonas.Location = new System.Drawing.Point(289, 114);
            this.trackbarPersonas.Minimum = 1;
            this.trackbarPersonas.Name = "trackbarPersonas";
            this.trackbarPersonas.Size = new System.Drawing.Size(228, 45);
            this.trackbarPersonas.TabIndex = 4;
            this.trackbarPersonas.Value = 1;
            this.trackbarPersonas.Scroll += new System.EventHandler(this.trackbarPersonas_Scroll);
            // 
            // lblPersonasMostrar
            // 
            this.lblPersonasMostrar.AutoSize = true;
            this.lblPersonasMostrar.Font = new System.Drawing.Font("Microsoft YaHei", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPersonasMostrar.Location = new System.Drawing.Point(604, 120);
            this.lblPersonasMostrar.Name = "lblPersonasMostrar";
            this.lblPersonasMostrar.Size = new System.Drawing.Size(0, 19);
            this.lblPersonasMostrar.TabIndex = 5;
            // 
            // progressBar1
            // 
            this.progressBar1.Location = new System.Drawing.Point(12, 400);
            this.progressBar1.Name = "progressBar1";
            this.progressBar1.Size = new System.Drawing.Size(577, 23);
            this.progressBar1.TabIndex = 6;
            // 
            // btnValidar
            // 
            this.btnValidar.Location = new System.Drawing.Point(219, 275);
            this.btnValidar.Name = "btnValidar";
            this.btnValidar.Size = new System.Drawing.Size(140, 39);
            this.btnValidar.TabIndex = 7;
            this.btnValidar.Text = "Validar";
            this.btnValidar.UseVisualStyleBackColor = true;
            this.btnValidar.Click += new System.EventHandler(this.btnValidar_Click);
            // 
            // lblMostrarPersonas
            // 
            this.lblMostrarPersonas.AutoSize = true;
            this.lblMostrarPersonas.Location = new System.Drawing.Point(538, 118);
            this.lblMostrarPersonas.Name = "lblMostrarPersonas";
            this.lblMostrarPersonas.Size = new System.Drawing.Size(51, 13);
            this.lblMostrarPersonas.TabIndex = 8;
            this.lblMostrarPersonas.Text = "Personas";
            // 
            // timerBarra
            // 
            this.timerBarra.Tick += new System.EventHandler(this.timerBarra_Tick);
            // 
            // FrmNumericTrack
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(611, 453);
            this.Controls.Add(this.lblMostrarPersonas);
            this.Controls.Add(this.btnValidar);
            this.Controls.Add(this.progressBar1);
            this.Controls.Add(this.lblPersonasMostrar);
            this.Controls.Add(this.trackbarPersonas);
            this.Controls.Add(this.numericUpDownDinero);
            this.Controls.Add(this.lblDinero);
            this.Controls.Add(this.lblPersonas);
            this.Name = "FrmNumericTrack";
            this.Text = "Formulario";
            this.Load += new System.EventHandler(this.FrmNumericTrack_Load);
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownDinero)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackbarPersonas)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblPersonas;
        private System.Windows.Forms.Label lblDinero;
        private System.Windows.Forms.NumericUpDown numericUpDownDinero;
        private System.Windows.Forms.TrackBar trackbarPersonas;
        private System.Windows.Forms.Label lblPersonasMostrar;
        private System.Windows.Forms.ProgressBar progressBar1;
        private System.Windows.Forms.Button btnValidar;
        private System.Windows.Forms.Label lblMostrarPersonas;
        private System.Windows.Forms.Timer timerBarra;
    }
}

