using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Testing.Models
{
    public class Pessoa
    {
        public string? Nome { get; set; }
        public string? NomeRepresentanteLegal { get; set; }
        public int Idade { get; set; }

        public void Apresentar()
        {
            Console.WriteLine($"Olá, meu nome é {Nome},\ne tenho {Idade} anos de idade.");
        }
    }
}
