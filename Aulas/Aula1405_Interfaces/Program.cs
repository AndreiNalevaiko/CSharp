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

            Console.WriteLine();
            Console.WriteLine();

            Onibus o = new Onibus();

            Console.WriteLine("Velocidade do Bus: " + o.Velocidade);
            o.Acelerar();
            o.Acelerar();
            o.Acelerar();
            o.Desacelar();
            Console.WriteLine("Velocidade do Bus, depois de sair do terminal: " + o.Velocidade);

            AcelerarBastante(car);
            Console.WriteLine(car.ImprimirInfo());

            AcelerarBastante(o);
            Console.WriteLine(o.ImprimirInfo());

            Console.ReadKey();

        }

        static void AcelerarBastante(IMeioTransporte meioTransporte)
        {
            for(int i = 0; i < 20; i++)
            {
                meioTransporte.Acelerar();
            }
        }

        static void CriarRelacionamento()
        {
            Carro c = new Carro();
            c.Modelo = "Astra";

            Marca m = new Marca();
            m.Nome = "Chevrolet";

            c._Marca = m;

            Onibus o = new Onibus();
            o.Modelo = "3100";
            o._Marca = m;
        }
    }
        
}
