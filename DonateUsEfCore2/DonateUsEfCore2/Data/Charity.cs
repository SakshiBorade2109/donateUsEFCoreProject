namespace DonateUsEfCore2.Data
{
    public class Charity
    {
        public int id {  get; set; }
        public string trustName {  get; set; }

        public ICollection<Donation> donations { get; set; }
       
    }
}
