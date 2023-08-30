using CountriesApplicationExample.Models;
using CountriesApplicationExample.Services;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics.Eventing.Reader;

namespace CountriesApplicationExample.Controllers
{
    public class CountriesController : Controller
    {   
        public FetchCountriesService fetch { get; set; }
        public CountriesController(FetchCountriesService fetch)
        {
            this.fetch = fetch;
        }

        public IActionResult DisplayAllCountries(int pagenumber = 1)
        {
            var countries = this.fetch.FetchAllCountries()
                .Skip(10*(pagenumber - 1))
                .Take(10)
            .ToList();
            return View(countries);
        }

		public IActionResult DisplayRestrictedCountries(int pagenumber=1)
        {
			var countries = this.fetch.FetchResCountries()
				.Skip(10 * (pagenumber - 1))
				.Take(10)
			.ToList();
			return View(countries);
		}

        public IActionResult DisplayAllowedCountries( int pagenumber=1)
        {
            var countries = this.fetch.FetchAllowedCountries()
                .Skip(10 * (pagenumber - 1))
                .Take(10)
                .ToList();
            return View(countries);
        }
		public IActionResult CheckAllowed(string countryName)
		{
			this.fetch.ModifyCountryStatus(countryName, true);
			return RedirectToAction("DisplayAllowedCountries");
		}

		public IActionResult CheckNotAllowed(string countryName)
		{
			this.fetch.ModifyCountryStatus(countryName, false);
			return RedirectToAction("DisplayRestrictedCountries");
		}




	}
}
