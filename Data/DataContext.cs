using controle_escolar.Models;
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.ChangeTracking;


namespace controle_escolar.Data
{
    public class DataContext : DbContext
    {
        public DbSet<Aluno> Alunos { get; set; }
        public DbSet<Turma> Turmas { get; set; }
        public DbSet<Chamada> Chamada { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlite("Data Source=escolar.db; Cache=Shared");
            optionsBuilder.UseLazyLoadingProxies(true);
    }


}
}
