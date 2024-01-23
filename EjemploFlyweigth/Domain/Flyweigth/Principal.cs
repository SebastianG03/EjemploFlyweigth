namespace EjemploFlyweigth.Domain.Flyweigth
{
    public class Principal
    {
        static void Main()
        {

            List<IPokemon> listaPokemon = new List<IPokemon>();

            TipoPokemon tipoPokemon = new TipoPokemon("Pikachu", "eléctrico");
            Pokemon pokemon1 = new Pokemon("", 1, 2, 3, tipoPokemon);

            Pokemon pokemon2 = new Pokemon("", 1, 4, 5, tipoPokemon);


            foreach (var pokemon in listaPokemon)
            {
                pokemon.MostrarInformacion();
                pokemon.MostrarInformacionBatalla();
                Console.WriteLine();
            }
        }
    }
}
