using DietX.DAL.Configurations;
using DietX.Entities.Entities;
using DietX.Entities.Entities.Base;
using DietX.Entities.Entities.UserEntities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.ChangeTracking;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DietX.DAL.AppDbContext
{
    public class DietXDbContext : DbContext
    {
        public DbSet<Food> Foods { get; set; }
        public DbSet<Category> Categories { get; set; }
        public DbSet<Meal> Meals { get; set; }
        public DbSet<User> Users { get; set; }
        public DbSet<UserMealReport> UserMealReports { get; set; }


        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Server=FATMANUR\\SQLEXPRESS;Database=DietX_Revize;Trusted_Connection=True;Encrypt=True;TrustServerCertificate=True");
            base.OnConfiguring(optionsBuilder);
        }



        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfigurationsFromAssembly(typeof(IEntityConfiguration).Assembly);
            base.OnModelCreating(modelBuilder);
        }

        public override int SaveChanges()
        {
            SetBaseProperties();
            return base.SaveChanges();
        }

        private void SetBaseProperties()
        {
            var entries = ChangeTracker.Entries<BaseEntity>();

            foreach (var entry in entries)
            {
                SetIfAdded(entry);
                SetIfModified(entry);
                SetIfDeleted(entry);
            }
        }

        private void SetIfDeleted(EntityEntry<BaseEntity> entry)
        {
            if (entry.State == EntityState.Deleted)
            {
                entry.State = EntityState.Modified;
                entry.Entity.Status = Entities.Enums.Status.Deleted;
                entry.Entity.DeletedDate = DateTime.Now;
            }
        }

        private void SetIfModified(EntityEntry<BaseEntity> entry)
        {
            if (entry.State == EntityState.Modified)
            {
                entry.Entity.Status = Entities.Enums.Status.Modified;
                entry.Entity.ModifiedDate = DateTime.Now;
            }
        }

        private void SetIfAdded(EntityEntry<BaseEntity> entry)
        {
            if (entry.State == EntityState.Added)
            {
                entry.Entity.Status = Entities.Enums.Status.Added;
                entry.Entity.CreatedDate = DateTime.Now;
            }
        }
    }
}
