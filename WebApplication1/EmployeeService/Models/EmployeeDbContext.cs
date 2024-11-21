using Microsoft.EntityFrameworkCore;
using System.Reflection.Metadata;

namespace EmployeeService.Models
{
    public class EmployeeDbContext : DbContext
    {
        public EmployeeDbContext(DbContextOptions<EmployeeDbContext> dbContextOptions)
            : base(dbContextOptions)
        {
            
        }
        public DbSet<Employee> tbl_employees { get; set; }
        public DbSet<User> tbl_users { get; set; }
        public DbSet<UserProfile> tbl_profiles {  get; set; }

        public DbSet<Order> tbl_orders {  get; set; }
        public DbSet<OrderItem> tbl_orderitems { get; set; }

        public DbSet<Student> tbl_students { get; set; }
        public DbSet<Course> tbl_courses { get; set; }
        public DbSet<Enrollment> tbl_enrollments { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);         

            modelBuilder.Entity<Enrollment>()
            .HasKey(en => new { en.StudentId, en.CourseId });
        }
    }
}
