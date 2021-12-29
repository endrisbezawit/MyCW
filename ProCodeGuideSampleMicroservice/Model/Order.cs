using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ProCodeGuideSampleMicroservice.Model
{
    public class Order
    {
        public string Id { get; set; }
        public string ProductId { get; set; }
        public double Cost { get; set; }
        public DateTime Placed { get; set; }
        public string CustomerId { get; set; }
        public string Status { get; set; }

    }
}
