
using Microsoft.EntityFrameworkCore;
using modelBindingExampleMvc.Models.Entities;

namespace modelBindingExampleMvc.Models.Context
{
    public class StudentsContext:DbContext
    {
        public DbSet<Student> Students { get; set; }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(@"Data Source=(LocalDB)\MSSQLLocalDB;Initial Catalog=SchoolDb;Integrated Security=true");
        }
    }
}
