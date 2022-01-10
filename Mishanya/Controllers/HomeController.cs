using Microsoft.AspNetCore.Mvc;
using Mishanya.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mishanya.Controllers
{
    public class HomeController : Controller
    {
        private IRepository repository;
        public HomeController(IRepository repository) => this.repository = repository;

        public ViewResult Index(string currentType)
        {
            var toursListViewModel = new ToursListViewModel();
            if (currentType != null)
            {
                TripType tripType = (TripType)Enum.Parse(typeof(TripType), currentType, true);
                toursListViewModel.Tours = repository.Tours.Where(x => x.Type == tripType);
            }
            else
            {
                toursListViewModel.Tours = repository.Tours;
            }
            toursListViewModel.TotalPrice = toursListViewModel.Tours.Sum(x => x.Price);
            return View(toursListViewModel);
        }
    }
}
