using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Inlämning3_OOA.Models;
using Microsoft.EntityFrameworkCore;

namespace Inlämning3_OOA.Database
{
    class MusicListContext: DbContext
    {
            private const string DatabaseName = "AATop10Music";
            public DbSet<Music> Songs { get; set; }
            public DbSet<Artist> Artists { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Music>()
                        .HasOne<Artist>()
                        .WithMany()
                        .HasForeignKey(X => X.ArtistID);
        }


            protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
            {
                optionsBuilder.UseSqlServer($@"Server=localhost;Database={DatabaseName};Trusted_Connection=True;");
            }
        
    }
}
