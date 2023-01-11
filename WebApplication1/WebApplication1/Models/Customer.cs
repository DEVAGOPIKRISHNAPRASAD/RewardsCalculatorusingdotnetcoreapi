using System.Collections.Generic;


namespace WebApplication1.Models
{
    public class Customer
    {
        public string Name { get; set; }
        public List<Transaction> Transactions { get; set; }
        public Dictionary<string, decimal> PointsEarnedPerMonth { get; set; }
        public decimal TotalPointsEarned { get; set; }
    }
}
