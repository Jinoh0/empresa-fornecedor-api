using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;

public class ApplicationDbContext : DbContext
{
    public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options) { }

    public DbSet<Empresa> Empresas { get; set; }
    public DbSet<Fornecedor> Fornecedores { get; set; }
    public DbSet<FornecedorEmpresa> FornecedorEmpresas { get; set; }

    public class DesignTimeDbContextFactory : IDesignTimeDbContextFactory<ApplicationDbContext>
    {
        public ApplicationDbContext CreateDbContext(string[] args)
        {
            var optionsBuilder = new DbContextOptionsBuilder<ApplicationDbContext>();
            // optionsBuilder.UseMySql("Server=localhost;Database=empresa_fornecedor;User Id=${DB_USER};Password=${DB_PASSWORD};", 
            optionsBuilder.UseMySql("Server=localhost;Database=empresa_fornecedor;User Id=jinoho;Password=@Sql04061004;", 
                                    new MySqlServerVersion(new Version(8, 0, 21)));

            return new ApplicationDbContext(optionsBuilder.Options);
        }
    }

protected override void OnModelCreating(ModelBuilder modelBuilder)
{
    modelBuilder.Entity<Empresa>()
        .ToTable("empresas"); 

    modelBuilder.Entity<Fornecedor>()
        .ToTable("fornecedores"); 

    modelBuilder.Entity<FornecedorEmpresa>()
        .ToTable("fornecedorempresas");

    modelBuilder.Entity<FornecedorEmpresa>()
        .HasKey(fe => new { fe.EmpresaId, fe.FornecedorId });

    modelBuilder.Entity<FornecedorEmpresa>()
        .HasOne(fe => fe.Empresa)
        .WithMany(e => e.Fornecedores)
        .HasForeignKey(fe => fe.EmpresaId);

    modelBuilder.Entity<FornecedorEmpresa>()
        .HasOne(fe => fe.Fornecedor)
        .WithMany(f => f.Empresas)
        .HasForeignKey(fe => fe.FornecedorId);
}
}
