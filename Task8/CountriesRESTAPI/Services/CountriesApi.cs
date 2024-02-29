namespace CountriesRESTAPI.Services
{
    public class CountriesApi : ICountriesApi
    {
        private readonly HttpClient _httpClient;

        public CountriesApi(HttpClient httpClient)
        {
            _httpClient = httpClient;
        }

        public async Task<List<Country>> GetCountriesAsync(CancellationToken cancellationToken)
        {

            var countries =await  _httpClient.GetFromJsonAsync<List<Country>>("https://restcountries.com/v3.1/all").ConfigureAwait(false);
            return countries;
        }
    }
}
