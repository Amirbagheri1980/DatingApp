using DatingApp.ApI.Model;
using Microsoft.EntityFrameworkCore;

namespace DatingApp.ApI.Data
{
    public class DataContext : DbContext
    {
        public DataContext(DbContextOptions<DataContext> options) : base (options){}
        
        public DbSet<Value> Values { get; set; }
    }
}