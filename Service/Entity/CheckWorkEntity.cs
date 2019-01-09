using System;

namespace Service.Service
{
    public class CheckWorkEntity: BaseEntity
    {
        public int ItemId { get; set; }
        public int TypeId { get; set; }
        public decimal Number { get; set; }
        public decimal Amount { get; set; }
        public DateTime CreateTime { get; set; } = DateTime.Now;
    }
}
