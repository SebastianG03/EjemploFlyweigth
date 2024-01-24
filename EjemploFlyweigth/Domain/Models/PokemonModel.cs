using EjemploFlyweigth.Domain.Flyweigth;

namespace EjemploFlyweigth.Domain.Models
{
    public class PokemonModel
    {
        public TipoPokemon TipoPokemon { get; set; }
        public string Apodo { get; set; }
        public int Nivel { get; set; }
        public int PuntosSalud { get; set; }
        public int PuntosAtaque { get; set; }
    }
}
