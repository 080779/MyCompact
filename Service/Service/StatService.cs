using Service;
using Service.DTO;
using Service.Enums;
using Service.Service;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IMS.Service.Service
{
    public class StatService
    {
        public StatDTO ToDTO(StatEntity entity)
        {
            StatDTO dto = new StatDTO();
            dto.ItemName = entity.ItemId.GetEnumName<ItemEnum>().Replace("0", "、").Replace("1", "（").Replace("2", "）");
            dto.Id = entity.Id;
            dto.TypeId = entity.TypeId;
            dto.ItemId = entity.ItemId;
            dto.TypeName = entity.TypeId.GetEnumName<TypeEnum>().Replace("0", "、").Replace("1", "（").Replace("2", "）");
            dto.QuarterNumber = entity.QuarterNumber;
            dto.QuarterAmount = entity.QuarterAmount;
            dto.YearNumber = entity.YearNumber;
            dto.YearAmount = entity.YearAmount;
            dto.TotalNumber = entity.TotalNumber;
            dto.TotalAmount = entity.TotalAmount;
            return dto;
        }
        public long Add()
        {
            using (MyDbContext dbc = new MyDbContext())
            {
                if(dbc.GetAll<StatEntity>().AsNoTracking().Any())
                {
                    return -1;
                }
                var typeList = MyEnumHelper.GetEnumList<TypeEnum>();
                var itemList = MyEnumHelper.GetEnumList<ItemEnum>();
                StatEntity entity;
                foreach (var type in typeList)
                {
                    if (type.Id <= 3)
                    {
                        var items = itemList.Where(i => i.Id < 10);
                        foreach (var item in items)
                        {
                            entity = new StatEntity();
                            entity.ItemId = item.Id;
                            entity.TypeId = type.Id;
                            dbc.Stats.Add(entity);
                        }
                    }
                    if (type.Id == 4)
                    {
                        var items = itemList.Where(i => i.Id >= 10 && i.Id < 20);
                        foreach (var item in items)
                        {
                            entity = new StatEntity();
                            entity.ItemId = item.Id;
                            entity.TypeId = type.Id;
                            dbc.Stats.Add(entity);
                        }
                    }
                    if (type.Id == 5)
                    {
                        var items = itemList.Where(i => i.Id > 20);
                        foreach (var item in items)
                        {
                            entity = new StatEntity();
                            entity.ItemId = item.Id;
                            entity.TypeId = type.Id;
                            dbc.Stats.Add(entity);
                        }
                    }
                }
                dbc.SaveChanges();
                return 1;
            }
        }

        public long Calc()
        {
            using (MyDbContext dbc = new MyDbContext())
            {
                if (!dbc.GetAll<StatEntity>().AsNoTracking().Any())
                {
                    return -1;
                }
                var typeList = MyEnumHelper.GetEnumList<TypeEnum>();
                var itemList = MyEnumHelper.GetEnumList<ItemEnum>();
                DateTime time = DateTime.Now;
                StatEntity stat;
                IQueryable<CheckWorkEntity> result;
                foreach (var type in typeList)
                {
                    if (type.Id <= 3)
                    {
                        var items = itemList.Where(i => i.Id < 10);
                        foreach (var item in items)
                        {
                            result = dbc.GetAll<CheckWorkEntity>().AsNoTracking().Where(c => c.TypeId == type.Id && c.ItemId == item.Id);
                            if(result.Count()<=0)
                            {
                                continue;
                            }
                            stat = dbc.GetAll<StatEntity>().SingleOrDefault(s => s.TypeId == type.Id && s.ItemId == item.Id);
                            //if(time.Month)
                            //stat.QuarterNumber = result.Where(c=>c.CreateTime);
                            stat.QuarterAmount = 0;
                            stat.YearNumber = 0;
                            stat.YearAmount = 0;
                            stat.TotalNumber = 0;
                            stat.TotalAmount = 0;
                            dbc.SaveChanges();
                        }
                    }
                    if (type.Id == 4)
                    {
                        var items = itemList.Where(i => i.Id >= 10 && i.Id < 20);
                        foreach (var item in items)
                        {
                            stat = new StatEntity();
                            stat.ItemId = item.Id;
                            stat.TypeId = type.Id;
                            dbc.Stats.Add(stat);
                        }
                    }
                    if (type.Id == 5)
                    {
                        var items = itemList.Where(i => i.Id > 20);
                        foreach (var item in items)
                        {
                            stat = new StatEntity();
                            stat.ItemId = item.Id;
                            stat.TypeId = type.Id;
                            dbc.Stats.Add(stat);
                        }
                    }
                }
                dbc.SaveChanges();
                return 1;
            }
        }

        public bool Del(long id)
        {
            using (MyDbContext dbc = new MyDbContext())
            {
                StatEntity entity = dbc.GetAll<StatEntity>().SingleOrDefault(g => g.Id == id);
                if (entity == null)
                {
                    return false;
                }
                entity.IsDeleted = true;
                dbc.SaveChanges();
                return true;
            }
        }

        public StatDTO GetModel(long id)
        {
            using (MyDbContext dbc = new MyDbContext())
            {
                var entity = dbc.GetAll<StatEntity>().AsNoTracking().SingleOrDefault(a=>a.Id==id);
                if(entity==null)
                {
                    return null;
                }
                return ToDTO(entity);
            }
        }
        public StatSearchResult GetModelList(int? typeId,int? itemId,int pageIndex,int pageSize)
        {
            using (MyDbContext dbc = new MyDbContext())
            {
                StatSearchResult result = new StatSearchResult();
                var entities = dbc.GetAll<StatEntity>().AsNoTracking();
                if (typeId != null)
                {
                    entities = entities.Where(a => a.TypeId == typeId);
                }
                if (itemId != null)
                {
                    entities = entities.Where(a => a.ItemId == itemId);
                }
                result.PageCount = (int)Math.Ceiling((entities.LongCount()) * 1.0f / pageSize);
                var res = entities.OrderBy(a=>a.Id).Skip((pageIndex - 1) * pageSize).Take(pageSize).ToList();
                result.List = res.Select(a => ToDTO(a)).ToArray();
                return result;
            }
        }
    }
}
