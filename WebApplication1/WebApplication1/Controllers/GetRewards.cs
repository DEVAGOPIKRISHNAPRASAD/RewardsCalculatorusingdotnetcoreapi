﻿using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebApplication1.Models;
using WebApplication1.Services;

namespace WebApplication1.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class GetRewards : ControllerBase
    {
        private readonly IRewards _rewardsService;

        public GetRewards(IRewards rewards)
        {
            _rewardsService = rewards;
        }
        [HttpGet]
        public ActionResult<Customer> GetRewardsforCustomer()
        {
            //Consider the below customer for an example
            var customer = new Customer
            {
                Name = "Gopi",
                Transactions = new List<Transaction>
            {
                new Transaction { Date = new DateTime(2022,3, 10), Amount =120 },
                new Transaction { Date = new DateTime(2022, 4, 11), Amount =55},
                new Transaction { Date = new DateTime(2022, 5, 12), Amount =85},
                new Transaction { Date = new DateTime(2022, 6, 13), Amount =35}
            }
            };
            //calling the service to get the calculated rewards.
            _rewardsService.CalculateRewards(customer);
            return Ok(customer);
        }
    }
}
