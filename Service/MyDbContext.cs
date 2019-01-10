using Service.Config;
using Service.Service;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Linq.Expressions;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace Service
{
    public class MyDbContext:DbContext
    {
        public MyDbContext() : base("name=connStr")
        { }
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            modelBuilder.Configurations.Add<PersonEntity>(new PersonConfig());
            modelBuilder.Configurations.Add<CheckWorkEntity>(new CheckWorkConfig());
            modelBuilder.Configurations.Add<StatEntity>(new StatConfig());
        }
        public IQueryable<T> GetAll<T>() where T : BaseEntity
        {
            return this.Set<T>().Where(e => e.IsDeleted == false);
        }

        public long GetEntityId<T>(Expression<Func<T, bool>> expression) where T : BaseEntity
        {
            return this.Set<T>().AsNoTracking().Where(e => e.IsDeleted == false).Where(expression).Select(e => e.Id).SingleOrDefault();
        }

        public string GetStringProperty<T>(Expression<Func<T, bool>> expression, Expression<Func<T, string>> parameterName) where T : BaseEntity
        {
            return this.Set<T>().AsNoTracking().Where(e => e.IsDeleted == false).Where(expression).Select(parameterName).SingleOrDefault();
        }

        public DbSet<PersonEntity> Persons { get; set; }
        public DbSet<CheckWorkEntity> CheckWorks { get; set; }
        public DbSet<StatEntity> Stats { get; set; }
    }
}
