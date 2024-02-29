namespace CountriesRESTAPI.Services
{
    public interface ICountriesApi
    {
        Task<List<Country>> GetCountriesAsync(CancellationToken cancellationToken);
    }
}
