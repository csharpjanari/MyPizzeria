using Microsoft.EntityFrameworkCore;
using MyPizzeria.Models;

namespace MyPizzeria.Data
{
    public class ApplicationDbContext : DbContext
    {
        public DbSet<PizzaOrder> PizzaOrders { get; set; }

        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
        {

        }
    }
}
