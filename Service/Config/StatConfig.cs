using Service.Service;
using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Service.Config
{
    class StatConfig : EntityTypeConfiguration<StatEntity>
    {
        public StatConfig()
        {
            ToTable("tb_stats");
        }
    }
}
