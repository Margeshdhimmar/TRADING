using Microsoft.EntityFrameworkCore;
using MVC_TUTORIAL_5_12_23.Models;

namespace MVC_TUTORIAL_5_12_23.Data
{
      public class DataContext : DbContext
      {
            public DataContext(DbContextOptions options) : base(options)
            {

            }
            public DbSet<Employee> Employees { get; set; }  

            public DbSet<Book> Books {  get; set; } 

            public DbSet<Comment> Comments { get; set; }  

            public DbSet<Traderecord> Traderecords { get; set; }  
        
            public DbSet<SignInModel> signInModels { get; set; }

            public DbSet<Register> NewUser { get; set; }
      }
}

