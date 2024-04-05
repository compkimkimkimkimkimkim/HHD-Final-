using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity;
using System.Linq;

namespace HHD.Model
{
    public partial class DbBase : DbContext
    {
        public DbBase()
            : base("name=DbBase")
        {
        }

        public virtual DbSet<AboutU> AboutUs { get; set; }
        public virtual DbSet<Category> Categories { get; set; }
        public virtual DbSet<Community> Communities { get; set; }
        public virtual DbSet<CommunityCategory> CommunityCategories { get; set; }
        public virtual DbSet<CommunityCollection> CommunityCollections { get; set; }
        public virtual DbSet<CommunityComment> CommunityComments { get; set; }
        public virtual DbSet<CommunityPicture> CommunityPictures { get; set; }
        public virtual DbSet<EventList> EventLists { get; set; }
        public virtual DbSet<Home> Homes { get; set; }
        public virtual DbSet<LevelMary> LevelMaries { get; set; }
        public virtual DbSet<Localtion> Localtions { get; set; }
        public virtual DbSet<ManagerCommunity> ManagerCommunities { get; set; }
        public virtual DbSet<Orientation> Orientations { get; set; }
        public virtual DbSet<PSBC> PSBCs { get; set; }
        public virtual DbSet<StudentClub> StudentClubs { get; set; }
        public virtual DbSet<TitleImage> TitleImages { get; set; }
        public virtual DbSet<UoN> UoNs { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<AboutU>()
                .Property(e => e.Images)
                .IsUnicode(false);

            modelBuilder.Entity<EventList>()
                .Property(e => e.EventPoster)
                .IsUnicode(false);

            modelBuilder.Entity<Home>()
                .Property(e => e.Image)
                .IsUnicode(false);

            modelBuilder.Entity<LevelMary>()
                .Property(e => e.filePath)
                .IsUnicode(false);

            modelBuilder.Entity<Localtion>()
                .Property(e => e.LineColour)
                .IsUnicode(false);

            modelBuilder.Entity<Localtion>()
                .Property(e => e.BusNumbers)
                .IsUnicode(false);

            modelBuilder.Entity<Localtion>()
                .Property(e => e.Images)
                .IsUnicode(false);

            modelBuilder.Entity<Orientation>()
                .Property(e => e.Images)
                .IsUnicode(false);

            modelBuilder.Entity<PSBC>()
                .Property(e => e.Images)
                .IsUnicode(false);

            modelBuilder.Entity<StudentClub>()
                .Property(e => e.Images)
                .IsUnicode(false);

            modelBuilder.Entity<UoN>()
                .Property(e => e.Images)
                .IsUnicode(false);
        }
        
    }
    public class DbBase<T> where T : class
    {
        public DbSet<T> DBBase { get; set; }
        public virtual List<T> SelectAll()
        {
            using (var context = new DbBase())
            {
                return context.Set<T>().ToList();
            }
        }
        public T SelectByID(object ID)
        {
            using (var context = new DbBase())
            {
                return context.Set<T>().Find(ID);
            }
        }

        public virtual void Insert(T entity)
        {
            using (var context = new DbBase())
            {
                context.Entry(entity).State = EntityState.Added;
                context.SaveChanges();
            }
        }

        public virtual void Update(T entity)
        {
            using (var context = new DbBase())
            {
                context.Entry(entity).State = EntityState.Modified;
                context.SaveChanges();
            }
        }

        public virtual void Delete(T entity)
        {
            using (var context = new DbBase())
            {
                context.Entry(entity).State = EntityState.Deleted;
                context.SaveChanges();
            }
        }
    }
}
