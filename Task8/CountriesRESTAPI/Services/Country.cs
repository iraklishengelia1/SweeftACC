using Newtonsoft.Json;
using System.Text.Json;

namespace CountriesRESTAPI.Services
{
    public class Country
    {
        public Name Name { get; set; }
        public string Region { get; set; }
        public string Subregion { get; set; }
        public List<double> Latlng { get; set; }
        public double Area { get; set; }
        public int Population { get; set; }
    }

    public class Name
    {
        public string Common { get; set; }
        public string official { get; set; }
    }
}