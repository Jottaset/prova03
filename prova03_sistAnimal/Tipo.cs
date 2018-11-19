using System;
namespace prova03_sistAnimal
{
    public class Tipo
    {
        public string Raca;
        public string Nome;

        public void Define()
        {
            Console.WriteLine("Informe a Raca do Animal: ");
            Raca = Console.ReadLine();

            Console.WriteLine("Informe o Nome do {0}: ", Raca);
            Nome = Console.ReadLine();
            Console.WriteLine("")


        }

        public Tipo()
        {
        }
    }
}
