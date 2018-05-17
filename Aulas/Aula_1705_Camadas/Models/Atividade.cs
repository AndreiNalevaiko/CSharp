using System;

namespace Aula_1705_Camadas.Models
{
    class Atividade
    {
        //controller - código
        //
        //view - estrutura de formularios    
        public int AtividadeID { get; set; }

        public string Nome { get; set; }

        public bool Ativo { get; set; }
    }
}