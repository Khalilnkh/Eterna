using System.Collections.Generic;

namespace Eterna.Models
{
    public class Pricing
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public double Price { get; set; }
        public List<PricingService> PricingServices { get; set; }
    }
}
