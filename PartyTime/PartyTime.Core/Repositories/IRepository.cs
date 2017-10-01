using System.Collections.Generic;
using System.Threading.Tasks;

namespace PartyTime.Core
{
    public interface IRepository<T> where T : BaseEntity  
    {  
        IEnumerable<T> GetAll();  
        T Get(long id);  
        Task Insert(T entity);  
        void Update(T entity);  
        void Delete(T entity);  
        void Remove(T entity);  
        void SaveChanges();
        //Task AddAsync(T user);
    }  
}
