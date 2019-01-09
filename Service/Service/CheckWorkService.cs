using Service;
using Service.DTO;
using Service.Enums;
using Service.Service;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Data.Objects.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IMS.Service.Service
{
    public class CheckWorkService 
    {
        public CheckWorkDTO ToDTO(CheckWorkEntity entity)
        {
            CheckWorkDTO dto = new CheckWorkDTO();
            dto.ItemName = entity.ItemId.GetEnumName<ItemEnum>().Replace("0", "、").Replace("1", "（").Replace("2", "）");
            dto.Id = entity.Id;
            dto.TypeId = entity.TypeId;
            dto.ItemId = entity.ItemId;
            dto.TypeName = entity.TypeId.GetEnumName<TypeEnum>().Replace("0", "、").Replace("1", "（").Replace("2", "）");
            dto.Amount = entity.Amount;
            dto.Number = entity.Number;
            dto.CreateTime = entity.CreateTime;
            return dto;
        }
        public long Add(int typeId, int itemId, decimal number, decimal amount)
        {
            using (MyDbContext dbc = new MyDbContext())
            {
                CheckWorkEntity entity = new CheckWorkEntity();
                entity.ItemId = itemId;
                entity.TypeId = typeId;
                entity.Number = number;
                entity.Amount = amount;
                dbc.CheckWorks.Add(entity);
                dbc.SaveChanges();
                return entity.Id;
            }
        }

        public bool Del(long id)
        {
            using (MyDbContext dbc = new MyDbContext())
            {
                CheckWorkEntity entity = dbc.GetAll<CheckWorkEntity>().SingleOrDefault(g => g.Id == id);
                if (entity == null)
                {
                    return false;
                }
                entity.IsDeleted = true;
                dbc.SaveChanges();
                return true;
            }
        }

        public CheckWorkDTO GetModel(long id)
        {
            using (MyDbContext dbc = new MyDbContext())
            {
                var entity = dbc.GetAll<CheckWorkEntity>().AsNoTracking().SingleOrDefault(a=>a.Id==id);
                if(entity==null)
                {
                    return null;
                }
                return ToDTO(entity);
            }
        }
        public CheckWorkSearchResult GetModelList(int? typeId,int? itemId,DateTime? startTime,DateTime? endTime,int pageIndex,int pageSize)
        {
            using (MyDbContext dbc = new MyDbContext())
            {
                CheckWorkSearchResult result = new CheckWorkSearchResult();
                var entities = dbc.GetAll<CheckWorkEntity>().AsNoTracking();
                if (typeId != null)
                {
                    entities = entities.Where(a => a.TypeId == typeId);
                }
                if (itemId != null)
                {
                    entities = entities.Where(a => a.ItemId == itemId);
                }
                if (startTime != null)
                {
                    entities = entities.Where(a => a.CreateTime >= startTime);
                }
                if (endTime != null)
                {
                    entities = entities.Where(a => SqlFunctions.DateDiff("day", endTime, a.CreateTime) <= 0);
                }
                result.PageCount = (int)Math.Ceiling((entities.LongCount()) * 1.0f / pageSize);
                var res = entities.OrderByDescending(a => a.CreateTime).Skip((pageIndex - 1) * pageSize).Take(pageSize).ToList();
                result.List = res.Select(a => ToDTO(a)).ToArray();
                return result;
            }
        }
    }
}
