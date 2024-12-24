using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace NT101_PJ.UI
{
    public partial class ChooseRSA : Form
    {
        public ChooseRSA()
        {
            InitializeComponent();
        }

        private void ChooseRSA_Load(object sender, EventArgs e)
        {

        }

        private void btnRSAPem_Click(object sender, EventArgs e)
        {
            this.Hide();
            RSAForm rsaForm = new RSAForm();
            rsaForm.Show();
        }

        private void ChooseRSA_FormClosed(object sender, FormClosedEventArgs e)
        {
            var MainForm = new MainForm();
            MainForm.Show();
        }

        private void btnRSAwKey_Click(object sender, EventArgs e)
        {
            this.Hide();
            RSAwKey rsawKey = new RSAwKey();
            rsawKey.Show();
        }
    }
}
