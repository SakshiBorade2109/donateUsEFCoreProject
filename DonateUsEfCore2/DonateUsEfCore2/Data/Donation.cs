namespace DonateUsEfCore2.Data
{
    public class Donation
    {
        public int uid { get; set; }
        public int id { get; set; }
        public double amount { get; set; }

        public DateTime createdOn { get; set; }

        public int donationAreaId { get; set; }
        public int charityId { get; set; }

      
    }
}
