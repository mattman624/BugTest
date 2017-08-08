using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BugTest.Models;
using Highway.Data;
//using BugTest.Models;
//using Highway.Data;
using Microsoft.Data.Sqlite;
using Microsoft.EntityFrameworkCore;
using PCLStorage;

namespace BugTest
{
    public class BugTestContext : DataContext
    {
        private string filename => "Test.Test";
        public BugTestContext(DbContextOptions options) : base(options)
        {
            
        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            var path = FileSystem.Current.LocalStorage.Path;
            var connection = new SqliteConnection($"Data Source= {path}/{filename}");
            connection.Open();

            var command = connection.CreateCommand();
            command.CommandText = "PRAGMA key = 'password';";
            command.ExecuteNonQuery();

            optionsBuilder.UseSqlite(connection);

            // optionsBuilder.UseSqlite($"Filename= {path}/{filename}");

            base.OnConfiguring(optionsBuilder);
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Ship>();
            modelBuilder.Entity<Captain>();
            base.OnModelCreating(modelBuilder);
        }
    }
}
