using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Service.Service
{
    [Table("tb_persons")]
    public class PersonEntity
    {
        public long Id { get; set; }
        public string Name { get; set; }
    }
}
