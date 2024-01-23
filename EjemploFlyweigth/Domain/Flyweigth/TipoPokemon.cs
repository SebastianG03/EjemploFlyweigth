namespace EjemploFlyweigth.Domain.Flyweigth
{
    public class TipoPokemon : ITipoPokemon
    {
        // Parte intrínseca
        public string nombre { get; }
        public string tipo { get; }


        public TipoPokemon(string nombre, string tipo)
        {

            this.nombre = nombre;
            this.tipo = tipo;
        }


        public void MostrarInformacion()
        {

            Console.WriteLine($"Pokemon: {nombre}, Tipo: {tipo}");
        }



    }
}
