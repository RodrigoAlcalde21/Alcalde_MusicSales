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
            DialogResult result;

            result = MessageBox.Show(
                "Are you sure you want to quit?",
                "Quit",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Question);

            if (result == DialogResult.Yes)
            {
                this.Close();
            }
        }

        private void btnCal_Click(object sender, EventArgs e)
        {
            lstOut.Items.Clear();

            string songName;
            decimal songCost = .5m;
            int numberOfPlays;
            bool numberOfPlaysValid;



            //input
            songName = txtSongName.Text.Trim();

            numberOfPlaysValid = int.TryParse(txtNumberOfPlays.Text, out numberOfPlays);

            if (numberOfPlaysValid)
            {
                //create object
                MusicSale sale = new MusicSale(songName, numberOfPlays, songCost);

                //output
                lstOut.Items.Add("Song Name: " + sale.SongName);
                lstOut.Items.Add("Number of Plays: " + sale.NumberOfPlays.ToString("N0"));
                lstOut.Items.Add("Song Cost: " + sale.SongCost.ToString("C"));
                lstOut.Items.Add("Total Payment: " + sale.TotalPayment.ToString("C"));
            }
            else
            {
                lstOut.Items.Add("Error: Number of Plays must be a valid number.");
            }

            btnClear.Focus();
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
