using Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Interfaces
{
    public interface IProductRepository
    {
        Task<Product?> GetByIdAsync(int id);
        Task<List<Product>> ListAllAsync();
        void Add(Product product);
        void Update(Product product);
        void Remove(Product product);
        Task<bool> SaveAllAsync();
    }
}
