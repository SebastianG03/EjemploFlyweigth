namespace EjemploFlyweigth.Domain.Flyweigth
{
    public class Pokemon : IPokemon
    {
        public TipoPokemon tipoPokemon { get; set; }
        public int nivel {  get; set; }
        public int puntosSalud { get; set; }
        public int puntosAtaque { get; set; }


        // Establece la parte extrínseca
        public Pokemon(int nivel, int puntosSalud, int puntosAtaque, TipoPokemon tipoPokemon)
        {
            this.nivel = nivel;
            this.puntosSalud = puntosSalud;
            this.puntosAtaque = puntosAtaque;
            this.tipoPokemon = tipoPokemon;
        }

        public void MostrarInformacion()
        {

            Console.WriteLine($"Tipo de Pokemon: {tipoPokemon}");
        }


        public void MostrarInformacionBatalla()
        {

            Console.WriteLine($"Nivel: {nivel}, Puntos de Salud: {puntosSalud}, Puntos de Ataque: {puntosAtaque}");
        }
    }

}
