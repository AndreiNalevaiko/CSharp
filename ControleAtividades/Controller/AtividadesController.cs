using Controller.Base;
using Modelos;
using System.Collections.Generic;
using System.Linq;
using System;
using Controller.DAL;

namespace Controller
{
    class AtividadesController : IBaseController<Atividade>
    {
        private Contexto contexto = new Contexto();

        private static List<Atividade> Lista { get; set; } = new List<Atividade>();

        public void Adicionar(Atividade entity)
        {
            contexto.Atividades.Add(entity);
            contexto.SaveChanges();
           // Lista.Add(atividade);
        }

        public void Atualizar(Atividade entity)
        {
            contexto.Entry(entity).State = System.Data.Entity.EntityState.Modified;

            contexto.SaveChanges();
        }

        public Atividade BuscarPorID(int id)
        {
            return contexto.Atividades.Find(id);
        }

        public void Excluir(int idAtividade)
        {
            Atividade a = BuscarPorID(idAtividade);

            if(a != null)
            {
                // contexto.Atividades.Remove(a);
                contexto.Entry(a).State = System.Data.Entity.EntityState.Deleted;
                contexto.SaveChanges();
            }
            
        }

        public IList<Atividade> ListarPorNome(string nome)
        {
            /* var lista = from atividade in contexto.Atividades where atividade.Nome == nome select atividade;
             return lista.ToList(); */

            return contexto.Atividades.Where(atividade >= atividade.Nome == nome).ToList();   
        }

        public IList<Atividade> ListarTodos()
        {
            return contexto.Ativdades.ToList();
        }
    }
}
