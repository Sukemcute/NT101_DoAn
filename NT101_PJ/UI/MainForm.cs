using NT101_PJ.UI;

namespace NT101_PJ
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
            this.FormClosed += (sender, e) => Application.Exit();
        }

        private void btPlayFair_Click(object sender, EventArgs e)
        {
            this.Hide();
            PlayFairForm playFairForm = new PlayFairForm();
            playFairForm.Show();
        }

        private void btnRSA_Click(object sender, EventArgs e)
        {
            this.Hide();
            ChooseRSA chooseRSA = new ChooseRSA();
            chooseRSA.Show();
        }

        private void label5_Click(object sender, EventArgs e)
        {

        }
    }
}
