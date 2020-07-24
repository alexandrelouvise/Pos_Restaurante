using Restaurante.Domain.Interfaces.Repositories;
using Restaurante.Domain.Interfaces.Services;
using System;
using System.Collections.Generic;
using System.Text;

namespace Restaurante.Domain.Services
{
    public class Service<T> : IService<T> where T : class
    {

        private readonly IRepository<T> _repository;
        public Service(IRepository<T> repository)
        {
            _repository = repository;
        }
        public void Atualizar(T entity)
        {
            _repository.Atualizar(entity);
        }

        public void Cadastrar(T entity)
        {
            _repository.Cadastrar(entity);
        }

        public void Excluir(T entity)
        {
            _repository.Excluir(entity);
        }

        public IEnumerable<T> ListarTodos()
        {
            return _repository.ListarTodos();
        }

        public T PesquisarPorId(Guid Id)
        {
            return _repository.PesquisarPorId(Id);
        }
    }
}
