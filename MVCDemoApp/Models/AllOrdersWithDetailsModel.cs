using DataLibrary.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MVCDemoApp.Models
{
    public class AllOrdersWithDetailsModel
    {
        public List<OrderModelWithFoodDetails> Orders { get; set; } = new List<OrderModelWithFoodDetails>();
    }
}
