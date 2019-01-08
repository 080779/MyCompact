using Service.Service;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Service
{
    public class MyDbContext:DbContext
    {
        public MyDbContext() : base("name=connStr")
        { }
        public DbSet<PersonEntity> Persons { get; set; }
    }
}
