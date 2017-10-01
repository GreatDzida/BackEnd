using Microsoft.EntityFrameworkCore;    
using System;  
using System.Collections.Generic;  
using System.Linq;
using PartyTime.Core;
using System.Threading.Tasks;

namespace PartyTime.Infastructure
{  
    public class Repository<T> : IRepository<T> where T : BaseEntity  
    {  
        private readonly ApplicationContext context;  
        private DbSet<T> entities;  
        string errorMessage = string.Empty;  
  
        public Repository(ApplicationContext context)  
        {  
            this.context = context;  
            //entities = context.Set<T>();  
        }  
        public IEnumerable<T> GetAll()  
        {  
            return entities.AsEnumerable();  
        }  
  
        public T Get(long id)  
        {  
            return entities.SingleOrDefault(s => s.Id == id);  
        }  
        public async Task Insert(T entity)  
        {  
            if (entity == null)  
            {  
                throw new ArgumentNullException("entity");  
            }  
            context.Add(entity);  
            context.SaveChanges();
            await Task.CompletedTask;
        }  
  
        public void Update(T entity)  
        {  
            if (entity == null)  
            {  
                throw new ArgumentNullException("entity");  
            }  
            context.SaveChanges();  
        }  
  
        public void Delete(T entity)  
        {  
            if (entity == null)  
            {  
                throw new ArgumentNullException("entity");  
            }  
            entities.Remove(entity);  
            context.SaveChanges();  
        }  
        public void Remove(T entity)  
        {  
            if (entity == null)  
            {  
                throw new ArgumentNullException("entity");  
            }  
            entities.Remove(entity);              
        }  
  
        public void SaveChanges()  
        {  
            context.SaveChanges();  
        }  
    }  
}  