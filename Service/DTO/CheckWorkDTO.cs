using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Service.DTO
{
    public class CheckWorkDTO
    {
        public long Id { get; set; }
        public string ItemName { get; set; }
        public int ItemId { get; set; }
        public int TypeId { get; set; }
        public string TypeName { get; set; }
        public decimal Number { get; set; }
        public decimal Amount { get; set; }
        public DateTime CreateTime { get; set; }
    }

    public class CheckWorkSearchResult
    {
        public CheckWorkDTO[] List { get; set; }
        public long PageCount { get; set; }
    }
}
