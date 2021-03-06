using Microsoft.EntityFrameworkCore;
using TwitterCloneBackend.DDD.Models;

namespace TwitterCloneBackend.DDD
{
    public class DataContext : DbContext
    {
        // DbSets

        public DbSet<User> Users { get; set; }

        public DbSet<Profile> Profiles { get; set; }

        public DbSet<Location> Locations { get; set; }

        public DbSet<City> Cities { get; set; }

        public DbSet<Country> Countries { get; set; }

        public DbSet<Tweet> Tweets { get; set; }

        public DbSet<Replies> Replies { get; set; }

        // Db path
        public string DbPath { get; }

        public DataContext()
        {
            //var folder = Environment.SpecialFolder.LocalApplicationData;
            //var path = Environment.GetFolderPath(folder);
            //var path = Environment.CurrentDirectory;
            //DbPath = Path.Join(path, "twitterClone.db");
        }

        protected override void OnConfiguring(DbContextOptionsBuilder options)
        {
            //options.UseSqlite($"Data Source = {DbPath}");
            //options.UseSqlServer(@"Server=(localdb)\mssqllocaldb;Database=TwitterClone;Trusted_Connection=True");
            options.UseSqlServer(@"Server=.\SQLEXPRESS;Database=TwitterClone;Trusted_Connection=True;");
        }
    }
}
