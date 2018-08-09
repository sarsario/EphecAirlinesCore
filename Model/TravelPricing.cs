using System;
using System.Collections.Generic;
using System.Text;

namespace Model
{
    public class TravelPricing
    {
        public int Id { get; set; }

        public int TravelId { get; set; }

        public int PricingId { get; set; }

        public DateTime ValidFrom { get; set; }

        public DateTime ValidTo { get; set; }

    }
}
