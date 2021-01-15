using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace NumericTrackBar
{
    public partial class FrmNumericTrack : Form
    {
        public FrmNumericTrack()
        {
            InitializeComponent();
        }

        private void FrmNumericTrack_Load(object sender, EventArgs e)
        {
            lblPersonasMostrar.Text = trackbarPersonas.Value.ToString();
            this.numericUpDownDinero.DecimalPlaces = 2;
            this.numericUpDownDinero.ThousandsSeparator = true; //modificaciones para que permita dinero con decimales
        }

        private void trackbarPersonas_Scroll(object sender, EventArgs e)
        {
            lblPersonasMostrar.Text = trackbarPersonas.Value.ToString();
        }
    }
}
