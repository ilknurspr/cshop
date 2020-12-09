using Microsoft.EntityFrameworkCore;
using Infrastructure.Data;
using Core.Entities;

namespace Infrastructure.Data
{
    public class StoreContext : DbContext
    {
        public StoreContext(DbContextOptions<StoreContext> options) : base(options)
        {
        }

        public DbSet<Product> Products {get;set;}
    }
}