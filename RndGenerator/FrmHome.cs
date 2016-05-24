using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using RndGen.Generators;

namespace RndGenerator
{
    public partial class FrmHome : Form
    {
        public FrmHome()
        {
            InitializeComponent();
        }

        private void rbText_CheckedChanged(object sender, EventArgs e)
        {
            // enabling the required/optional textboxes

            if (rbText.Checked)
            {
                tbLowerLimitString.Enabled = true;
                tbNumberString.Enabled = true;
                tbUpperLimitString.Enabled = true;
            }
        }

        private void rbWord_CheckedChanged(object sender, EventArgs e)
        {
            if (rbWord.Checked)
            {
                tbLowerLimitString.Enabled = true;
                tbUpperLimitString.Enabled = true;
                tbNumberString.Enabled = false;
            }
        }

        private void btnGenerateString_Click(object sender, EventArgs e)
        {
            if (rbText.Checked)
            {
                if (!string.IsNullOrEmpty(tbNumberString.Text))
                {
                    if (!string.IsNullOrEmpty(tbUpperLimitString.Text) && !string.IsNullOrEmpty(tbLowerLimitString.Text))
                    {
                        rtbResult.Text = StringGenerator.TextGenerator(Convert.ToInt32(tbNumberString.Text), Convert.ToInt32(tbLowerLimitString.Text),
                            Convert.ToInt32(tbUpperLimitString.Text));
                    }
                    else
                    {
                        rtbResult.Text = StringGenerator.TextGenerator(Convert.ToInt32(tbNumberString.Text));
                    }
                }
            }
        }
    }
}
