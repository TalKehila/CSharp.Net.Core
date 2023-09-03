using CountriesApplicationExample.Models;
using System.Linq;
using System.Net;

namespace CountriesApplicationExample.Services
{
    public class FetchCountriesService
    {
        private List<Country> Allcountries;
        private List<Country> Allowedcountries;
        private List<Country> Restrectedcountries;

        public FetchCountriesService()
        {
            Allcountries = FetchAllCountries();
            Allowedcountries = new List<Country>();
            Restrectedcountries = new List<Country>();


        }
        public List<Country> FetchAllCountries()
        {

            WebClient webClient = new WebClient();
            string urlToAllCountries = "https://restcountries.com/v3.1/all?fields=name,flags";
            string resultStr = webClient.DownloadString(urlToAllCountries);

            List<Country> countries =
                 Newtonsoft.Json.JsonConvert.DeserializeObject<List<Country>>(resultStr);
            return countries;
        }

        public List<Country> FetchAllowedCountries()
        {
            List<Country> allowed = Allowedcountries;
            return allowed;
        }

        public List<Country> FetchResCountries()
        {
            List<Country> notallowed = Restrectedcountries;

            return notallowed;


        }


		public void ModifyCountryStatus(string countryName, bool allow)
		{
			var country = Allcountries.FirstOrDefault(country => country.Name.Common == countryName);

			if (country != null)
			{
				if (allow)
				{
					if (Restrectedcountries.Contains(country))
					{
						Restrectedcountries.Remove(country);
					}
					if (!Allowedcountries.Contains(country))
					{
						Allowedcountries.Add(country);
					}
				}
				else
				{
					if (Allowedcountries.Contains(country))
					{
						Allowedcountries.Remove(country);
					}
					if (!Restrectedcountries.Contains(country))
					{
						Restrectedcountries.Add(country);
					}
				}
			}
		}
	}
}
