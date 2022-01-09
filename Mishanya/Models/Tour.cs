using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mishanya.Models
{
    public class Tour
    {
        public string Name { get; set; }
        public DateTime Date { get; set; }
        public int Duration { get; set; }
        public string Transport { get; set; }
        public decimal Price { get; set; }
        public string Address { get; set; }
        public TripType Type { get; set; }
    }

    public enum TripType
    {
        Tourist,
        Excursion,
        Cruise
    }

}
