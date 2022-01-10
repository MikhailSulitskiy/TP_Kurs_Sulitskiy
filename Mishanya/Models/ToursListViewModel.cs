using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mishanya.Models
{
    public class ToursListViewModel
    {
        public IEnumerable<Tour> Tours { get; set; }
        public TripType CurrentType { get; set; }
        public decimal TotalPrice { get; set; }
    }
}
