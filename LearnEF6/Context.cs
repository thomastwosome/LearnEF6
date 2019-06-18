using LearnEF6.Models;
using System.Data.Entity;

namespace LearnEF6
{
    public class Context : DbContext
    {
        public Context()
            : base("DefaultConnection")
        {
            Configuration.LazyLoadingEnabled = false;
        }

        public DbSet<Person> People { get; set; }
        public DbSet<OfficeAssignment> OfficeAssignments { get; set; }
        public DbSet<Location> Locations { get; set; }
        public DbSet<Course> Courses { get; set; }
    }
}