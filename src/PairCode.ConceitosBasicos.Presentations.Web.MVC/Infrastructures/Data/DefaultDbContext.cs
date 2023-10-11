using Microsoft.EntityFrameworkCore;
using WebTest.Web.Models;

namespace PairCode.ConceitosBasicos.Presentations.Web.MVC.Infrastructures.Data
{
    public class DefaultDbContext : DbContext
    {
        public DbSet<UsuarioModel> Usuarios { get; set; }
        protected DefaultDbContext()
        {
            if (Database.IsRelational())
            {
                Database.Migrate();
            }
        }

        public DefaultDbContext(DbContextOptions<DefaultDbContext> options) : base(options)
        {
            if (Database.IsRelational())
            {
                Database.Migrate();
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.HasDefaultSchema("default");

            modelBuilder.Entity<UsuarioModel>(builder =>
            {
                builder
                    .Property<int>(p => p.Id)
                    .HasColumnType("INT")
                    .HasColumnName("ID")
                    .ValueGeneratedOnAdd()
                    .UseIdentityColumn()
                    .IsRequired(true);

                builder
                    .Property<string>(p => p.Username)
                    .HasColumnType("VARCHAR(64)")
                    .HasColumnName("USERNAME")
                    .IsRequired(false);

                builder
                    .Property<string>(p => p.Password)
                    .HasColumnType("VARCHAR(32)")
                    .HasColumnName("PASSWORD")
                    .IsRequired(false);

                builder
                    .HasKey(p => p.Id);

                builder
                    .ToTable("TB_USUARIOS");
            });
        }
    }
}
