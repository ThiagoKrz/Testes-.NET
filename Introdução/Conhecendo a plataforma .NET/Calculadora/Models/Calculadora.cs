using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Calculadora.Models
{
    public class Calculador
    {
       
                public void Somar(int x, int y)
        {
            Console.WriteLine($"{x} + {y} é = {x+y}");
        }
        public void Subtrair(int x, int y)
        {
            Console.WriteLine($"{x} - {y} é = {x-y}");
        }
        public void Multiplicar(int x, int y)
        {
            Console.WriteLine($"{x} multiplicado por {y} é = {x*y}");
        }
        public void Dividir(int x, int y)
        {
            Console.WriteLine($"{x} dividido por {y} é = {x/y}");
        }

        public void Potencia(int x, int y)
        {
            double pot = Math.Pow(x,y);
            Console.WriteLine($"{x}^{y} = {pot}");
        }
    }
}