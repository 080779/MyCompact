using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Service.DTO
{
    public class StatDTO
    {
        public long Id { get; set; }
        public string TypeName { get; set; }
        public string ItemName { get; set; }
        public int TypeId { get; set; }
        public int ItemId { get; set; }
        public decimal QuarterNumber { get; set; }
        public decimal QuarterAmount { get; set; }
        public decimal YearNumber { get; set; }
        public decimal YearAmount { get; set; }
        public decimal TotalNumber { get; set; }
        public decimal TotalAmount { get; set; }
    }

    public class StatSearchResult
    {
        public StatDTO[] List { get; set; }
        public long PageCount { get; set; }
    }
}
