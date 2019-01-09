using Service.Service;
using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Service.Config
{
    class PersonConfig : EntityTypeConfiguration<PersonEntity>
    {
        public PersonConfig()
        {
            ToTable("tb_persons");
            Property(p => p.Name).HasMaxLength(100).IsRequired();
        }
    }
}
