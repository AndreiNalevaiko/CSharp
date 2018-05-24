using Controller.Base;
using Modelos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Controller
{
    public class UsuariosController : IBaseController<Usuario>
    {
        private static List<Usuario> Lista { get; set; } = new List<Usuario>();

        public void Adicionar(Usuario entity)
        {
            throw new NotImplementedException();
        }

        public void Atualizar(int id, Usuario entity)
        {
            throw new NotImplementedException();
        }

        public Usuario BuscarPorID(int id)
        {
            foreach (Usuario a in Lista)
            {
                if (a.UsuarioID == id)
                {
                    return a;
                }
            }

            return null;
        }

        public void Excluir(Usuario entity)
        {
            throw new NotImplementedException();
        }

        public IList<Usuario> ListarPorNome()
        {
            throw new NotImplementedException();
        }

        public IList<Usuario> ListarTodos()
        {
            throw new NotImplementedException();
        }
    }
}
