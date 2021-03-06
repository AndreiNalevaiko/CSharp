﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Controller.Base
{
    public interface IBaseController<T> where T : class
    {
        void Adicionar(T entity);
        IList<T> ListarTodos();
        IList<T> ListarPorNome();
        T BuscarPorID(int id);
        void Atualizar(int id, T entity);
        void Excluir(T entity);
    }
}
