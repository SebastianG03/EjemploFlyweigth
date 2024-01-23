namespace EjemploFlyweigth.Domain.Services
{
    public class ApiService
    {
        private readonly HttpClient _httpClient = new HttpClient();
        private static ApiService? instance;
        private readonly String _url = "";
        

        private ApiService() { }

        public static ApiService Singleton()
        {
            if (instance == null)
            {
                instance = new ApiService();
            }
            return instance;
        }
/*
        public async Task<List<Remote>> GetRemotes()
        {
            try
            {
                var res = await _httpClient.GetFromJsonAsync<List<Remote>>(_urlRemote);
                Console.WriteLine(res);
                return res!;
            }
            catch (HttpRequestException e)
            {
                Console.WriteLine(e.Message);
                throw;
            }
        }


        public async Task<List<Device>> GetDevices()
        {
            try
            {
                var res = await _httpClient.GetFromJsonAsync<List<Device>>(_urlDevice);
                Console.WriteLine(res);
                return res!;
            }
            catch (HttpRequestException e)
            {
                Console.WriteLine(e.Message);
                throw;
            }
        }*/

    }
}
