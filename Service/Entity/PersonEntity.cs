using System.ComponentModel.DataAnnotations.Schema;

namespace Service.Service
{
    [Table("tb_persons")]
    public class PersonEntity
    {
        public long Id { get; set; }
        public string Name { get; set; }
    }
}
