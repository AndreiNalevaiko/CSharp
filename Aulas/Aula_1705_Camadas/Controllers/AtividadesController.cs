using Aula_1705_Camadas.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aula_1705_Camadas.Controllers
{
    class AtividadesController
    {
        //Lista
        public List<Atividade> ListaAtividades { get; set; }

        //Salvar
        public void Salvar(Atividade atividade  )
        {
            ListaAtividades.Add(atividade); //pega a lista e salva
        }

        //Listar
        public List<Atividade> Listar()
        {
            return ListaAtividades;
        }

        //BuscarPorID
        public Atividade BuscarPorID(int id)
        {
            foreach (Atividade a in ListaAtividades)
            {
                if(a.AtividadeID == id)
                {
                    return a;
                }
            }

            return null; //se ele nao entrar no if, quer dizer que ele nao achou atividade
        }

        //Editar

        //Exclui

    }
}
