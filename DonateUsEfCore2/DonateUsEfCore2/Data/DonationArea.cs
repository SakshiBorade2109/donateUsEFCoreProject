namespace DonateUsEfCore2.Data
{
    public class DonationArea
    {
        public int id { get; set; }
        public string areaDesc { get; set; }

        public ICollection<Donation> donations { get; set; }
    }
}
