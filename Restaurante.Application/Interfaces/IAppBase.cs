using System;
using System.Collections.Generic;
using System.Text;

namespace Restaurante.Application.Interfaces
{
    public interface IAppBase<T> where T : class
    {
        void Cadastrar(T entity);
        void Excluir(T entity);
        void Atualizar(T entity);
        T PesquisarPorId(Guid Id);
        IEnumerable<T> ListarTodos();
    }
}
