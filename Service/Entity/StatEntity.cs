using System;

namespace Service.Service
{
    public class StatEntity : BaseEntity
    {
        public int ItemId { get; set; }
        public int TypeId { get; set; }
        public decimal QuarterNumber { get; set; }
        public decimal QuarterAmount { get; set; }
        public decimal YearNumber { get; set; }
        public decimal YearAmount { get; set; }
        public decimal TotalNumber { get; set; }
        public decimal TotalAmount { get; set; }
    }
}
