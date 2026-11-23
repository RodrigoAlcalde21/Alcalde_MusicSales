using System.IO;
namespace MusicSales
{
    public partial class Form1 : Form
    {
        private string saleType = "";
        private string fileName = "MusicSalesLog.txt";
        private string configFileName = "MusicSalesConfig.txt";

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
            rdoStandard.Checked = true;
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

            string songName;
            int numberOfPlays;
            bool numberOfPlaysValid;

            //input
            songName = txtSongName.Text.Trim();

            numberOfPlaysValid = int.TryParse(txtNumberOfPlays.Text, out numberOfPlays);

            if (numberOfPlaysValid)
            {


                //create object
                MusicSale sale = new MusicSale(songName, numberOfPlays, saleType);

                //output
                WriteTransaction(sale);
            }
            else
            {
                lstOut.Items.Add("Error: Number of Plays must be a valid number.");
            }

            btnClear.Focus();
        }

        private void WriteTransaction(MusicSale sale)
        {
            StreamWriter sw;

            sw = File.AppendText(fileName);

            sw.WriteLine("----- New Transaction -----");
            sw.WriteLine("Date and Time: " + DateTime.Now.ToString());
            sw.WriteLine("Sale Type: " + saleType);
            sw.WriteLine("Song Name: " + sale.SongName);
            sw.WriteLine("Number of Plays: " + sale.NumberOfPlays.ToString("N0"));
            sw.WriteLine("Song Cost: " + sale.SongCost.ToString("C"));
            sw.WriteLine("Total Payment: " + sale.TotalPayment.ToString("C"));
            sw.WriteLine("");

            sw.Close();

            lstOut.Items.Add("----- New Transaction -----");
            lstOut.Items.Add("Date and Time: " + DateTime.Now.ToString());
            lstOut.Items.Add("Sale Type: " + saleType);
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
            rdoStandard.Checked = true;

            StreamReader? sr = null;

            if (!File.Exists(configFileName))
            {
                MessageBox.Show(
                    "The configuration file was not found. Please select the file.",
                    "Configuration File");

                DialogResult result = openFileDialog1.ShowDialog();

                if (result == DialogResult.OK)
                {
                    configFileName = openFileDialog1.FileName;
                }
                else
                {
                    MessageBox.Show(
                        "A configuration file is required. The program will close.");

                    this.Close();
                    return;
                }
            }

            try
            {
                sr = File.OpenText(configFileName);

                decimal standard;
                decimal premium;
                decimal exclusive;

                bool standardValid = decimal.TryParse(sr.ReadLine(), out standard);
                bool premiumValid = decimal.TryParse(sr.ReadLine(), out premium);
                bool exclusiveValid = decimal.TryParse(sr.ReadLine(), out exclusive);

                if (standardValid && premiumValid && exclusiveValid &&
                    standard > 0 && premium > 0 && exclusive > 0)
                {
                    MusicSale.StandardCost = standard;
                    MusicSale.PremiumCost = premium;
                    MusicSale.ExclusiveCost = exclusive;
                }
                else
                {
                    MessageBox.Show(
                        "The configuration file contains invalid prices.",
                        "Configuration Error");

                    this.Close();
                    return;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(
                    "Error reading configuration file: " + ex.Message,
                    "File Error");

                this.Close();
            }
            finally
            {
                if (sr != null)
                {
                    sr.Close();
                }
            }
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

        private void rdoStandard_CheckedChanged(object sender, EventArgs e)
        {
            if (rdoStandard.Checked)
            {
                saleType = MusicSale.STANDARD_TYPE;
            }
        }

        private void rdoPremium_CheckedChanged(object sender, EventArgs e)
        {
            if (rdoPremium.Checked)
            {
                saleType = MusicSale.PREMIUM_TYPE;
            }
        }

        private void rdoExclusive_CheckedChanged(object sender, EventArgs e)
        {
            if (rdoExclusive.Checked)
            {
                saleType = MusicSale.EXCLUSIVE_TYPE;
            }
        }
    }
}
