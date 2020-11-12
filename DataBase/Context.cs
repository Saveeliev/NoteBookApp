using DataBase.Models;
using Microsoft.EntityFrameworkCore;

namespace DataBase
{
    public class Context : DbContext
    {
        public DbSet<UserDb> Users { get; set; }
        public DbSet<NoteDb> Notes { get; set; }
        public DbSet<FavoriteDb> Favorites { get; set; }
        public DbSet<LikeDb> Likes { get; set; }

        public Context()
        {

        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<LikeDb>()
                .HasIndex(u => new { u.NoteId, u.UserId })
                .IsUnique();

            modelBuilder.Entity<FavoriteDb>()
                .HasIndex(u => new { u.NoteId, u.UserId })
                .IsUnique();

            modelBuilder.Entity<LikeDb>()
            .HasOne(p => p.User)
            .WithMany(t => t.Likes)
            .OnDelete(DeleteBehavior.NoAction);

            modelBuilder.Entity<LikeDb>()
            .HasOne(p => p.Note)
            .WithMany(t => t.Likes)
            .OnDelete(DeleteBehavior.NoAction);

            modelBuilder.Entity<FavoriteDb>()
            .HasOne(p => p.User)
            .WithMany(t => t.Favorites)
            .OnDelete(DeleteBehavior.NoAction);
        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Server = (localdb)\\mssqllocaldb; Database = NoteBook1Db; Trusted_Connection = True;");
        }
    }
}