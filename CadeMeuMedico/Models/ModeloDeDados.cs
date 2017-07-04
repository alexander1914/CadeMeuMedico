namespace CadeMeuMedico.Models
{
    using System;
    using System.Data.Entity;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Linq;

    public partial class ModeloDeDados : DbContext
    {
        public ModeloDeDados()
            : base("name=EntidadesModeloDeDados")
        {
        }

        //public virtual DbSet<BannersPublicitario> BannersPublicitarios { get; set; }
        public virtual DbSet<Cidades> Cidades { get; set; }
        public virtual DbSet<Especialidades> Especialidades { get; set; }
        public virtual DbSet<Medicos> Medicos { get; set; }
        public virtual DbSet<Usuarios> Usuarios { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            //modelBuilder.Entity<BannersPublicitario>()
            //    .Property(e => e.TituloCampanha)
            //    .IsUnicode(false);

            //modelBuilder.Entity<BannersPublicitario>()
            //    .Property(e => e.BannerCampanha)
            //    .IsUnicode(false);

            //modelBuilder.Entity<BannersPublicitario>()
            //    .Property(e => e.LinkBanner)
            //    .IsUnicode(false);

            modelBuilder.Entity<Cidades>()
                .Property(e => e.Nome)
                .IsUnicode(false);

            modelBuilder.Entity<Especialidades>()
                .Property(e => e.Nome)
                .IsUnicode(false);

            modelBuilder.Entity<Especialidades>()
                .HasMany(e => e.Medicos)
                .WithRequired(e => e.Especialidades)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Medicos>()
                .Property(e => e.CRM)
                .IsUnicode(false);

            modelBuilder.Entity<Medicos>()
                .Property(e => e.Nome)
                .IsUnicode(false);

            modelBuilder.Entity<Medicos>()
                .Property(e => e.Endereco)
                .IsUnicode(false);

            modelBuilder.Entity<Medicos>()
                .Property(e => e.Bairro)
                .IsUnicode(false);

            modelBuilder.Entity<Medicos>()
                .Property(e => e.Email)
                .IsUnicode(false);

            modelBuilder.Entity<Medicos>()
                .Property(e => e.WebsiteBlog)
                .IsUnicode(false);

            modelBuilder.Entity<Usuarios>()
                .Property(e => e.Nome)
                .IsUnicode(false);

            modelBuilder.Entity<Usuarios>()
                .Property(e => e.Login)
                .IsUnicode(false);

            modelBuilder.Entity<Usuarios>()
                .Property(e => e.Senha)
                .IsUnicode(false);

            modelBuilder.Entity<Usuarios>()
                .Property(e => e.Email)
                .IsUnicode(false);
        }
    }
}
