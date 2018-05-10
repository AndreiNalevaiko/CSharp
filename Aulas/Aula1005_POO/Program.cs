using System;

namespace Aula1005_POO {
    class Program {
        static void Main(string[] args)
        {
            Cliente c = new Cliente();
            c.Nome = "Andrei"; //set
            string nomeC = c.Nome; //get

            c.Cpf = "12345678909"; // set
            string cpfCliente = c.Cpf; //get

            Console.WriteLine(c.Nome);
            Console.WriteLine(c.Cpf);



            Console.ReadKey();

        }
    }
}
