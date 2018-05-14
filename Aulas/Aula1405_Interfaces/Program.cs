using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aula1405_Interfaces
{
    class Program
    {
        static void Main(string[] args)
        {
            Carro car = new Carro();

            Console.WriteLine("Velocidade inicial:" + car.Velocidade);
            car.Acelerar();
            car.Acelerar();
            car.Desacelar();
            Console.WriteLine("Velocidade Atual: " + car.Velocidade);

            Onibus o = new Onibus();

            Console.WriteLine("Velocidade do Bus: " + o.Velocidade);
            o.Acelerar();
            o.Acelerar();
            o.Acelerar();
            o.Desacelar();
            Console.WriteLine("Velocidade do Bus, depois de sair do terminal: " + o.Velocidade);

            Console.ReadKey();

        }
    }
}
