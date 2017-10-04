using Microsoft.EntityFrameworkCore;
using PartyTime.Core;
using PartyTime.Infastructure;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace PartyTime.Infrastructure.Repositories
{
    public class TestRepository<T> : IRepository<T> where T : BaseEntity
    {
        private readonly ApplicationContext context;
        private DbSet<T> entities;
        string errorMessage = string.Empty;

        public TestRepository(ApplicationContext context)
        {
            this.context = context;
            //entities = context.Set<T>();  
        }

        public void Delete(T entity)
        {
            throw new NotImplementedException();
        }

        public T Get(long id)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<T> GetAll()
        {
            throw new NotImplementedException();
        }

        public Task Insert(T entity)
        {
            throw new NotImplementedException();
        }

        public void Remove(T entity)
        {
            throw new NotImplementedException();
        }

        public void SaveChanges()
        {
            throw new NotImplementedException();
        }

        public void Update(T entity)
        {
            throw new NotImplementedException();
        }
    }
}
