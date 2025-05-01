using System.Data.Entity;
using System.Security.Principal;

using ProjetoLivros.Models;

namespace ProjetoLivros.Context
{   
    //todo context herda DbContext
    public class LivrosContext : DbContext
    {
        //cada tabela -> DbSet (tabela do banco de dados)

        public DbSet<Usuario> Usuarios { get; set; }

        public DbSet<TipoUsuario> TipoUsuarios { get; set; }

        public DbSet<Assinatura> Assinaturas { get; set; }

        public DbSet<Livro> Livros { get; set; }

        public DbSet<Categoria> Categorias { get; set; }

        public LivrosContext(DbContextOptions<LivrosContext> options) : base(options)
        {

        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            //String de conexão
            optionsBuilder.UseSqlServer("Data Source=NOTE08-S28\\SQLEXPRESS;Initial Catalog=Livros;User Id=sa;Password=Senai@134;TrustServerCertificate=true;");
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            modelBuilder.Entity<Usuario>(
                //representação da tabela
                entity =>
                {
                    //Primary Key
                    entity.HasKey(u => u.UsuarioId);

                    entity.Property(u => u.NomeCompleto)
                    .IsRequired()
                    .HasMaxLength(150)
                    .IsUnicode(false);

                    entity.Property(u => u.Email)
                    .IsRequired()
                    .IsUnicode(false)
                    .HasMaxLength(150);

                    //email é unico
                    entity.HasIndex(u => u.Email)
                    .IsUnique();

                    entity.Property(u => u.Senha)
                    .IsRequired()
                    .IsUnicode(false)
                    .HasMaxLength(255);

                    entity.Property(u => u.Telefone)
                    .IsUnicode(false)
                    .HasMaxLength(15);

                    entity.Property(u => u.DataCadastro)
                    .IsRequired();

                    entity.Property(u => u.DataAtualizacao)
                    .IsRequired();

                    entity.HasOne(u => u.TipoUsuario)
                    .WithMany(t => t.Usuarios)
                    .HasForeignKey(u => u.TipoUsuarioId)
                    .OnDelete(DeleteBehavior.Cascade);

                }

            );
        }
    }
}
