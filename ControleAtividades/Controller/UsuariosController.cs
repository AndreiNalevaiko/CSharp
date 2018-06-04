using Controller.Base;
using Controller.DAL;
using Modelos;
using System;
using System.Collections.Generic;

namespace Controller
{
    public class UsuariosController : IBaseController<Usuario>
    {
        //Fazer bastante commit
        //Criar um projeto de sua escolha
        //Proposta
        //titulo, descrição, funcionalidade
        Contexto contexto = new Contexto();
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
            throw new NotImplementedException();
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
