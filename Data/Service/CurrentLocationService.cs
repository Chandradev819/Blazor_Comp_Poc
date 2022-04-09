namespace Blazor_Comp_Poc.Data.Service
{
    public interface ICurrentLocation
    {
        public Task<LocaltionDetails> GetLocaltionDetails();
    }

    public class CurrentLocationService : ICurrentLocation
    {
        private readonly HttpClient httpClient;

        public CurrentLocationService(HttpClient httpClient)
        {
            this.httpClient = httpClient;
        }

        public async Task<LocaltionDetails> GetLocaltionDetails()
        {
            var result = await httpClient.GetFromJsonAsync<LocaltionDetails>("https://ipinfo.io/json");
            return result;
        }
    }
}
