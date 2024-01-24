using EjemploFlyweigth.Domain.Flyweigth;
using EjemploFlyweigth.Domain.Models;
using System.Net.Http;

namespace EjemploFlyweigth.Domain.Services
{
    public class ApiService
    {
        private readonly HttpClient client = new HttpClient();
        private static ApiService? instance;
        private readonly String _url = "https://pokemonapi20240123161306.azurewebsites.net/api/Pokemon";

        private ApiService() { }

        public static ApiService Singleton()
        {
            if (instance == null)
            {
                instance = new ApiService();
            }
            return instance;
        }

        public async Task<List<PokemonServiceModel>> GetPokemons()
        {
            try
            {
                var res = await client.GetFromJsonAsync<List<PokemonServiceModel>>(_url);
                Console.WriteLine(res);
                return res;
            }
            catch (HttpRequestException e)
            {
                Console.WriteLine(e.Message);
                throw;
            }
        }

        public async Task<bool> PostPokemon(PokemonModel pokemon)
        {
            try
            {
                PokemonServiceModel model = new PokemonServiceModel
                {
                    Id = 0,
                    Apodo = pokemon.Apodo,
                    Nivel = pokemon.Nivel,
                    Nombre = pokemon.TipoPokemon.nombre,
                    Ps = pokemon.PuntosSalud,
                    Pp = pokemon.PuntosAtaque,
                    Tipo = pokemon.TipoPokemon.tipo
                };

                var res = await client.PostAsJsonAsync<PokemonServiceModel>(_url, model);
                Console.WriteLine(res);
                return true;
            }
            catch (HttpRequestException e)
            {
                Console.WriteLine(e.Message);
                throw;
            }
        }
    }
}
