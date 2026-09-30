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
            //input
            string songName;
            decimal songCost = .5m;
            int numberOfPlays;

            songName = txtSongName.Text.Trim();

            numberOfPlays = int.Parse(txtNumberOfPlays.Text);

            //processing
            btnClear.Focus();

            //output
            lstOut.Items.Add("Song Name: " + songName);
            lstOut.Items.Add("Song Cost: " + songCost.ToString("C"));
            lstOut.Items.Add("Number of Plays: " + numberOfPlays.ToString("N0"));
        }

        private void txtSongName_Enter(object sender, EventArgs e)
        {
            txtSongName.BackColor = Color.LightYellow;
        }

        private void txtSongName_Leave(object sender, EventArgs e)
        {
            txtSongName.BackColor = Color.White;
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void lblNumberOfPlays_Click(object sender, EventArgs e)
        {

        }

        private void txtNumberOfPlays_Enter(object sender, EventArgs e)
        {
            txtNumberOfPlays.BackColor = Color.LightYellow;
        }

        private void txtNumberOfPlays_Leave(object sender, EventArgs e)
        {
            txtNumberOfPlays.BackColor = Color.White;
        }
    }
}
