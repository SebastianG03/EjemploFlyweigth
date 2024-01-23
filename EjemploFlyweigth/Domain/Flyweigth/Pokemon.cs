namespace EjemploFlyweigth.Domain.Flyweigth
{
    public class Pokemon : IPokemon
    {
        public TipoPokemon TipoPokemon { get; set; }
        public string Apodo { get; set; }
        public int Nivel { get; set; }
        public int PuntosSalud { get; set; }
        public int PuntosAtaque { get; set; }


        public Pokemon() { }

        // Establece la parte extrínseca
        public Pokemon(string apodo, int nivel, int puntosSalud, int puntosAtaque, TipoPokemon tipoPokemon)
        {
            Apodo = apodo;
            Nivel = nivel;
            PuntosSalud = puntosSalud;
            PuntosAtaque = puntosAtaque;
            TipoPokemon = tipoPokemon;
        }

        public void MostrarInformacion()
        {

            Console.WriteLine($"Tipo de Pokemon: {TipoPokemon}");
        }


        public void MostrarInformacionBatalla()
        {

            Console.WriteLine($"Nivel: {Nivel}, Puntos de Salud: {PuntosSalud}, Puntos de Ataque: {PuntosAtaque}");
        }
    }
}

