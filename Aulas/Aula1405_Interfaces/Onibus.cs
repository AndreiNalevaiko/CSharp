using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aula1405_Interfaces
{
    class Onibus : IMeioTransporte
    {
        public int Velocidade { get; set; }

        public string Modelo { get; set; }

        public int MarcaID { get; set; }

        public virtual Marca _Marca { get; set; }

        public void Acelerar()
        {
            Velocidade += 7;
        }

        public void Desacelar()
        {
            Velocidade -= 2;
        }

        public string ImprimirInfo()
        {
            return "Onibus, velocidade atual: " + Velocidade;
        }
    }
}
