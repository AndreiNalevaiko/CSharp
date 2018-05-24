using Controller.Base;
using Modelos;
using System.Collections.Generic;
using System.Linq;
using System;

namespace Controller
{
    class AtividadesController : IBaseController<Atividade>
    {
        private static List<Atividade> Lista { get; set; } = new List<Atividade>();

        public void Adicionar(Atividade atividade)
        {
            Lista.Add(atividade);
        }

        public void Atualizar(int id, Atividade atividadeAtualizada)
        {
            Atividade atividadeAntiga = BuscarPorID(id);
            if (atividadeAntiga != null)
            {
                atividadeAntiga.Nome = atividadeAtualizada.Nome;
                atividadeAntiga.Ativo = atividadeAtualizada.Ativo;
            }
        }

        public Atividade BuscarPorID(int id)
        {
            foreach (Atividade a in Lista)
            {
                if (a.AtividadeID == id)
                {
                    return a;
                }
            }

            return null;
        }

        public void Excluir(Atividade atividade)
        {
            Lista.Remove(atividade);
        }

        public IList<Atividade> ListarPorNome()
        {
            throw new NotImplementedException();
        }

        public IList<Atividade> ListarPorNome(string nome)
        {
            IEnumerable<Atividade> atividadeSelecionadas = new List<Atividade>();
            atividadeSelecionadas = from x in Lista where x.Nome.ToLower().Contains(nome.ToLower()) select x;
            return atividadeSelecionadas.ToList();
        }

        public IList<Atividade> ListarTodos()
        {
            return Lista;
        }
    }
}
