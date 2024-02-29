namespace CountriesRESTAPI.Services
{
    public class DataFilesGenerator : IDataFilesGenerator
    {
        public void GenerateCountryDataFiles(List<Country> countries)
        {
            if (countries is null || !countries.Any())
            {
                throw new Exception("Countries not found");
            }

            foreach (var country in countries)
            {
                var fileName = $"Files/{country.Name.Common}.txt";

                using (var writer = new StreamWriter(fileName))
                {
                    writer.WriteLine($"Region: {country.Region}");
                    writer.WriteLine($"Subregion: {country.Subregion}");
                    writer.WriteLine($"Latlng: {string.Join(", ", country.Latlng)}");
                    writer.WriteLine($"Area: {country.Area}");
                    writer.WriteLine($"Population: {country.Population}");
                }

            }
        }

        
    }
}
