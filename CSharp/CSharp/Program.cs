using System;
using Classes;
using Primeiro;
using Interface;
using Enum;

namespace CSharp
{ 
    class Program
    {
        static void Main(string[] args)
        {
            var pessoa = (Pessoas)0;
            Pessoas pessoa2 = Pessoas.João;
            Pessoas pessoa3 = (Pessoas)4;

            Animal animal = new Animal();

            animal.Nome = "Rex";
            animal.nomeDono = "Pedro";
            animal.Especie = "Cachorro";

            Pessoa person = new Pessoa();

            person.Nome = "Giovanna";
            person.Idade = 18;
            person.Estado = "SP";

            Pessoa person2 = new Pessoa();

            person2.Nome = "Julia";
            person2.Idade = 23;
            person2.Estado = "MG";

            var classe = new Classe();
            var classe2 = new Segundo.Classe();

            Console.WriteLine(pessoa3);
        }
    }
}