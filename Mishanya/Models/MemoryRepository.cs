using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mishanya.Models
{
    public interface IRepository
    {
        IEnumerable<Tour> Tours { get; }
        void AddTour(Tour tour);
    }

    public class MemoryRepository : IRepository
    {
        private List<Tour> tours = new List<Tour>
        {
            new Tour{Name = "Тур поездка \"Огонек\"", Date = DateTime.Now, Duration = 10, Price = 1500M, Transport = "Автобус", Address = "г. Челябинск", Type = TripType.Tourist },
            new Tour{Name = "Титаник", Date = DateTime.Now, Duration = 34, Price = 220000M, Transport = "Лайнер", Address = "г. Керчь", Type = TripType.Cruise },
            new Tour{Name = "Музей ВолгГТУ", Date = DateTime.Now, Duration = 2, Price = 100M, Transport = "Самолет", Address = "г. Волгоград", Type = TripType.Excursion },
            new Tour{Name = "Путешествие в Меловые горы", Date = DateTime.Now, Duration = 5, Price = 3000M, Transport = "Автобус", Address = "г. Иловля", Type = TripType.Tourist },
            new Tour{Name = "Спуск по Волге", Date = DateTime.Now, Duration = 12, Price = 10000M, Transport = "Теплоход", Address = "г. Нижний Новгород", Type = TripType.Cruise },
            new Tour{Name = "Музей Минералов", Date = DateTime.Now, Duration = 2, Price = 500M, Transport = "Автобус", Address = "г. Москва", Type = TripType.Excursion },

        };

        public IEnumerable<Tour> Tours => tours;
        public void AddTour(Tour tour) => tours.Add(tour);
    }
}
