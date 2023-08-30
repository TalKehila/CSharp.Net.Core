namespace CountriesApplicationExample.Models
{
    public class Country
    {
        public CountryName Name{ get; set; }
        public CountryFlag Flags { get; set; }
    }

    public class CountryName
    {
        public string Common{ get; set; }
    }

    public class CountryFlag
    {
        public string Png{ get; set; }
    }
}
