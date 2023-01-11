using System.Collections.Generic;
using WebApplication1.Models;

namespace WebApplication1.Services
{
    public class Rewards : IRewards
    {
        public void CalculateRewards(Customer customer)
        {
            customer.PointsEarnedPerMonth = new Dictionary<string, decimal>();
            customer.TotalPointsEarned = 0;
            foreach (var transaction in customer.Transactions)
            {
                var month = transaction.Date.ToString("MMMM");
                if (!customer.PointsEarnedPerMonth.ContainsKey(month))
                {
                    customer.PointsEarnedPerMonth[month] = 0;
                }
                decimal points = 0;
                if (transaction.Amount > 50 && transaction.Amount <= 100)
                {
                    points += transaction.Amount - 50;
                }
                else if (transaction.Amount > 100)
                {
                    points += (transaction.Amount-100)*2+50;
                }
                customer.PointsEarnedPerMonth[month] += points;
                customer.TotalPointsEarned += points;
            }
        }
    }
}
