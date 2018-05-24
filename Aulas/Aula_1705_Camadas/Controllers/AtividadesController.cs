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
        // simulando tabela
        private static List<Atividade> ListaAtividades { get; set; } = new List<Atividade>();

        private static int ContadorAtividade = 1;

        //Salvar
        public void Salvar(Atividade atividade  )
        {
            atividade.AtividadeID = ContadorAtividade++;
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
        public void Editar(int id, Atividade atividadeAtualizada)
        {
            Atividade atividadeAntiga = BuscarPorID(id);
            if(atividadeAntiga != null)
            {
                atividadeAntiga.Nome = atividadeAtualizada.Nome;
                atividadeAntiga.Ativo = atividadeAtualizada.Ativo;
            }
        }

        //Excluir
        public void Excluir(int id)
        {
            Atividade atividade = BuscarPorID(id);
            if(atividade != null)
            {
                ListaAtividades.Remove(atividade);
            }
        }

        public List<Atividade> BuscarPorNome(string nome)
        {
            IEnumerable<Atividade> atividadeSelecionadas = new List<Atividade>();

   

            atividadeSelecionadas = from x in ListaAtividades where x.Nome.ToLower().Contains(nome.ToLower()) select x;

            return atividadeSelecionadas.ToList(); //se ele nao entrar no if, quer dizer que ele nao achou atividade
        }

        public void BuscarPorStatus()
        {
            IEnumerable<Atividade> Lista = new List<Atividade>();

            Lista = 
        }
    }
}
