using System;
using System.Collections.Generic;
using System.Text;

namespace Service.Enums
{
    public static class MyEnumHelper
    {
        public static string GetEnumName<T>(this int enumTypeId)
        {
            return Enum.GetName(typeof(T), enumTypeId);
        }

        public static EnumModel[] GetEnumList<T>()
        {
            var arrays = Enum.GetValues(typeof(T));
            List<EnumModel> lists = new List<EnumModel>();
            foreach (var item in arrays)
            {
                lists.Add(new EnumModel { Id = (int)item, Name = item.ToString().Replace("0", "、").Replace("1", "（").Replace("2", "）") });
            }
            return lists.ToArray();
        }

        public class EnumModel
        {
            public int Id { get; set; }
            public string Name { get; set; }
        }
    }
}
