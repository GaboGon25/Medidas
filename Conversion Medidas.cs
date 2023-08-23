using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Medidas
{
    public partial class Conversion_Medidas : Form
    {
        public Conversion_Medidas()
        {
            InitializeComponent();
        }

        private void btnConvertir_Click(object sender, EventArgs e)
        {
            double mtr, ctm, yd, pul, ft;

            mtr = double.Parse(txtMetros.Text);

            ctm = (mtr * 100);

            txtCentimetros.Text = ctm.ToString();

            pul = (ctm / 2.54);

            txtPulgadas.Text = pul.ToString();

            ft = (pul / 12);

            txtPies.Text = ft.ToString();

            yd = (ft / 3);

            txtYardas.Text = yd.ToString();

        }

        private void btnNuevo_Click(object sender, EventArgs e)
        {
            txtMetros.Clear();
            txtCentimetros.Clear();
            txtPulgadas.Clear();
            txtPies.Clear();
            txtYardas.Clear();
        }
    }
}
