namespace Сотрудники
{
    using System;
    using System.Data.Entity;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Linq;

    public partial class Model1 : DbContext
    {
        public Model1()
            : base("name=Model1")
        {
        }

        public virtual DbSet<Должности> Должности { get; set; }
        public virtual DbSet<Категории> Категории { get; set; }
        public virtual DbSet<Сотрудники_НИИ> Сотрудники_НИИ { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Категории>()
                .HasMany(e => e.Должности)
                .WithRequired(e => e.Категории)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Сотрудники_НИИ>()
                .Property(e => e.Пол)
                .IsFixedLength();

            modelBuilder.Entity<Сотрудники_НИИ>()
                .Property(e => e.Ученная_степень)
                .IsFixedLength();

            modelBuilder.Entity<Сотрудники_НИИ>()
                .Property(e => e.Телефон)
                .IsFixedLength();
        }
    }
}
