using CountriesRESTAPI.Services;
using Microsoft.AspNetCore.Mvc;

namespace CountriesRESTAPI.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class CountryController : ControllerBase
    {
        private readonly ICountriesApi _countriesApi;
        private readonly IDataFilesGenerator _filesGenerator;
        private readonly ILogger<CountryController> _logger;

        public CountryController(ILogger<CountryController> logger, ICountriesApi countriesApi, IDataFilesGenerator filesGenerator)
        {
            _logger = logger;
            _countriesApi = countriesApi;
            _filesGenerator = filesGenerator;
        }

        [HttpPost(Name = "GenerateCountryDataFiles")]
        public async Task<IActionResult> GenerateCountryDataFiles(CancellationToken cancellationToken)
        {
            var countries= await _countriesApi.GetCountriesAsync(cancellationToken);
            _filesGenerator.GenerateCountryDataFiles(countries);
            return Ok(countries);
        }
    }
}