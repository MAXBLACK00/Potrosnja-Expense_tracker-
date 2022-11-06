using Microsoft.EntityFrameworkCore;

namespace Potrosnja_Expense_tracker_.Models.Entities
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions  options) : base(options)  
        {
               
        }
        public DbSet<Category> Transactions { get; set; }
        public  DbSet <Transaction> Categories{ get; set; }
    }
}
