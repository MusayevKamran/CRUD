using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MVC.Interfaces.Core
{
    public interface IGeneric<T> where T : class
    {
        void Create(T model);
        void Delete(T model);
        List<T> GetAll();
        Task<List<T>> GetAllAsync();
        T GetById(int? Id);
        Task<T> GetByIdAsync(int? Id);
        void Update(T model);
        int SaveChanges();
        Task<int> SaveChangesAsync();
    }
}
