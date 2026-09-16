namespace MusicSales
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void txtNumberOfPlays_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            txtSongName.Clear();
            txtSongCost.Clear();
            txtNumberOfPlays.Clear();
            lstOut.Items.Clear();
            txtSongName.Focus();
        }

        private void lblSongName_Click(object sender, EventArgs e)
        {

        }

        private void btnQuit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnCal_Click(object sender, EventArgs e)
        {
       //     lstOut.Items.Add((5 + 5) / 2);
            btnClear.Focus();
        }
    }
}
