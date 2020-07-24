using System;
using System.Collections.Generic;
using System.Text;

namespace Restaurante.Domain.Interfaces.Repositories
{
    public interface IRepository<T> where T : class
    {
        void Cadastrar(T entity);
        void Excluir(T entity);
        void Atualizar(T entity);
        T PesquisarPorId(Guid Id);
        IEnumerable<T> ListarTodos();

    }
}
