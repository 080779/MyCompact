using Service.Service;
using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Service.Config
{
    class CheckWorkConfig : EntityTypeConfiguration<CheckWorkEntity>
    {
        public CheckWorkConfig()
        {
            ToTable("tb_checkWorks");
        }
    }
}
