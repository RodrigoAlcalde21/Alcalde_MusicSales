
public class MusicSale
{
    private decimal songCost;
    private decimal totalPayment;

    public string SongName {  get; set; }

    public int NumberOfPlays {  get; set; }

    public decimal SongCost
    {
        get { return songCost; }
        set
        {
            if (value >  0)
            {
                songCost = value;
            }
        }
    }

    public decimal TotalPayment
    {
        get { return totalPayment; }
        private set
        {
            if (value > 0)
            {
                totalPayment = value;
            }
        }
    }

    public MusicSale()
    {
        SongName = "";
    }

    public MusicSale(string songName, int numberOfPlays, decimal songCost)
    {
        SongName = songName;
        NumberOfPlays = numberOfPlays;
        SongCost = songCost;
    }

    public void CalculateTotalPayment()
    {
        TotalPayment = SongCost * NumberOfPlays;
    }

    //ToString method
    public override string ToString()
    {
        return "Song Name: " + SongName +
            "\nNumber of Plays: " + NumberOfPlays.ToString("N0") +
            "\nSong Cost: " + SongCost.ToString("C") +
            "\nTotal Payment: " + TotalPayment.ToString("C");
    }
}
