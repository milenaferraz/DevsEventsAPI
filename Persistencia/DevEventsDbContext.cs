using DevEventsAPI.Entity;
using Microsoft.EntityFrameworkCore;


namespace DevEventsAPI.Persistencia
{
    public class DevEventsDbContext : DbContext
    {
        public DevEventsDbContext(DbContextOptions<DevEventsDbContext> options) : base(options)
        {

        }

        public DbSet<Evento> Eventos { get; set; }
        public DbSet<Categoria> Categorias { get; set; }
        public DbSet<Usuario> Usuarios{ get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            /* modelBuilder.Entity<Evento>()
                  .ToTable("tb_Evento");  - Defini o nome da tabela

               modelBuilder.Entity<Evento>()
                  .Propety(e=> e.Descricao); -- Acrescenta dado na tabela
                  .HasMaxLength(100); -- Define o numero max de 100 caracteres
                  .HasColumnName --Define o nome da Coluna
                  .HasDefaultValue -- Define o valor padrão da propriedade
            */

            modelBuilder.Entity<Evento>()
                .HasKey(e=> e.Id);

            modelBuilder.Entity<Evento>()
                .HasOne(e => e.Categoria)
                .WithMany() // Defini varios eventos de categoria
                .HasForeignKey(e => e.Id);

            modelBuilder.Entity<Evento>()
                .HasOne(e => e.Usuario)
                .WithMany() // Defini varios eventos de categoria
                .HasForeignKey(e => e.Id); //Defini a Forekey 

            modelBuilder.Entity<Usuario>()
                .HasKey(e => e.Id);

            modelBuilder.Entity<Categoria>()
                .HasKey(e => e.Id);
        }
    }
}
