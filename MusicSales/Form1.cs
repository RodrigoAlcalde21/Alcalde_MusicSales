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
            //create object
            MusicSale sale = new MusicSale();


            //input
            sale.SongName = txtSongName.Text.Trim();
            sale.NumberOfPlays = int.Parse(txtNumberOfPlays.Text);
            sale.SongCost = .5m;


            //processing
            sale.CalculateTotalPayment();
            btnClear.Focus();

            //output
            lstOut.Items.Add("Song Name: " + sale.SongName);
            lstOut.Items.Add("Number of Plays: " + sale.NumberOfPlays.ToString("N0"));
            lstOut.Items.Add("Song Cost: " + sale.SongCost.ToString("C"));
            lstOut.Items.Add("Total Payment: " + sale.TotalPayment.ToString("C"));
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
