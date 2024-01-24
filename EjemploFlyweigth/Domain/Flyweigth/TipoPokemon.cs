namespace EjemploFlyweigth.Domain.Flyweigth
{
    public class TipoPokemon : ITipoPokemon
    {
        // Parte intrínseca
        public string nombre { get; set; }
        public string tipo { get; set; }


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
