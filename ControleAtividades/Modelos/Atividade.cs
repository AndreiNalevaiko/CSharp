﻿
namespace Modelos
{
    public class Atividade
    {

        //só validações. Exemplo: CPF, RG...
        public int AtividadeID { get; set; }
        public string Nome { get; set; }
        public bool Ativo { get; set; }
        public string Descricao { get; set; }
        public int CategoriaID { get; set; }
        public int UsuarioID { get; set; }
    }
}
