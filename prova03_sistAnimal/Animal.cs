using System;
namespace prova03_sistAnimal
{
    public class Animal
    {
        public string raca { set; get; }
        public string nome {set; get;}

        public string defineRaca(){
            this.raca = raca;
            return this.raca;
        }

        public string defineNome()
        {
            this.nome = nome;
            return this.nome;
        }

        public Animal()
        {
        }
    }
}
