using System;

namespace prova03_sistAnimal
{
    class Program
    {
        static void Main(string[] args)
        {
            Animal animal = new Animal();

            Console.WriteLine("Informe a Raca do Animal:");
            animal.raca = Console.ReadLine();

            Console.WriteLine("Informe o Nome do Animal:");
            animal.nome = Console.ReadLine();

            Console.WriteLine("Raca: {0} Nome: {1}", animal.defineRaca(), animal.defineNome());
        }
    }
}
