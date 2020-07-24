using Microsoft.EntityFrameworkCore;
using Restaurante.Domain.Interfaces.Repositories;
using Restaurante.Infra.Data.Config;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Restaurante.Infra.Data.Repositories
{
    public class Repository<T> : IRepository<T>, IDisposable where T : class
    {

        private readonly RestauranteDbContext _context;
        public Repository(RestauranteDbContext context)
        {
            _context = context;
        }
        public void Atualizar(T obj)
        {
            try
            {
                _context.Set<T>().Update(obj);
                _context.SaveChanges();
            }
            catch (Exception)
            {

                throw;
            }
        }

        public void Cadastrar(T obj)
        {
            try
            {
                _context.Set<T>().Add(obj);
                _context.SaveChanges();
            }
            catch (Exception)
            {

                throw;
            }
        }

        public void Dispose()
        {
            _context.Dispose();
        }

        public void Excluir(T obj)
        {
            try
            {
                _context.Set<T>().Remove(obj);
                _context.SaveChanges();
            }
            catch (Exception)
            {

                throw;
            }
        }

        public virtual IEnumerable<T> ListarTodos()
        {
            try
            {
                var result = _context.Set<T>().AsNoTracking().ToList();
                return result;
            }
            catch (Exception)
            {

                throw;
            }
        }

        public virtual T PesquisarPorId(Guid id)
        {
            try
            {
                return _context.Set<T>().Find(id);
            }
            catch (Exception)
            {

                throw;
            }
        }

    }
}
