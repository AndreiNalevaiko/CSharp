using System;

namespace Aula1005_POO {
    class Program {
        static void Main(string[] args)
        {
            /*Cliente c = new Cliente();
            c.Nome = "Andrei"; //set
            string nomeC = c.Nome; //get

            c.Cpf = "12345678909"; // set
            string cpfCliente = c.Cpf; //get

            Console.WriteLine(c.Nome);
            Console.WriteLine(c.Cpf);*/

            // utilizando os construtores parametrizados
            Cliente c1 = new Cliente("Jucicreuda");
            Console.WriteLine(c1.Nome);

            Cliente c2 = new Cliente("Juciliuda", "123456789");
            c2.DataNasc = new DateTime(1998, 05, 15);

            Console.WriteLine(c2.Nome + " Nasceu em: " + c2.DataNasc.Date);
            Console.WriteLine(c2.Nome + " tem " + c2.Idade);

            //Pessoa p = new Pessoas(); ERRO: classes abstratas nao podem ser instanciadas

            Console.ReadKey();

        }
    }
}
