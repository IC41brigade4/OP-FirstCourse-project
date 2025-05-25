using Microsoft.EntityFrameworkCore;

namespace reservepp
{
    public class AppDbContext : DbContext
    {
        public DbSet<UserDto> Users { get; set; }
        public DbSet<Order> Orders { get; set; }

        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
        {
        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
                optionsBuilder.UseSqlite("Data Source=app.db");
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            // Налаштування для UserDto
            modelBuilder.Entity<UserDto>(entity =>
            {
                entity.ToTable("Users");
                entity.HasKey(u => u.DocID);
                entity.Property(u => u.FirstName).IsRequired().HasMaxLength(100);
                entity.Property(u => u.LastName).IsRequired().HasMaxLength(100);
                entity.Property(u => u.Role).IsRequired().HasMaxLength(50);
                entity.Property(u => u.City).HasMaxLength(100);
                entity.Property(u => u.ArmyUnit).HasMaxLength(100);
                entity.Property(u => u.MedicalExaminationResult).HasMaxLength(200);
            });

            // Налаштування для Order
            modelBuilder.Entity<Order>(entity =>
            {
                entity.ToTable("Orders");
                entity.HasKey(o => o.OrderID);
                entity.Property(o => o.OrderText).IsRequired();
                entity.Property(o => o.Status).IsRequired().HasMaxLength(50);
            });

            base.OnModelCreating(modelBuilder);
        }
    }
}