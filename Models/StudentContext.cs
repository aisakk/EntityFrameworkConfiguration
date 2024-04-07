
using Microsoft.EntityFrameworkCore;
using Pomelo.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.SqlServer;
public class StudentContext : DbContext
{
    public DbSet<Alumno> alumnos {get; set;}
    public DbSet<Curso> cursos {get;set;}
    
    
     protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
        //var connectionString = "server=localhost;user=root;password=;database=Example";
        //optionsBuilder.UseMySql(connectionString, ServerVersion.AutoDetect(connectionString));
         IConfigurationRoot configuration = new ConfigurationBuilder()
            .SetBasePath(AppDomain.CurrentDomain.BaseDirectory)
            .AddJsonFile("appsettings.json")
            .Build();
        optionsBuilder.UseSqlServer(configuration.GetConnectionString("Example"));
    }
    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
         modelBuilder.Entity<Curso>()
            .HasOne(e => e.Alumnos)
            .WithMany(e => e.Cursos)
            .HasForeignKey(e => e.IDAlumno)
            .IsRequired();
      
    }
}