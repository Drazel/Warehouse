using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;
using MongoDB.Driver;
using Warehouse.Data.Attribute;
using Warehouse.Data.Dto;

namespace Warehouse.Data.Helper
{
    public static class AttributeHelper
    {
        public static string GetBsonCollectionAttributeName(Type type)
        {
            var result = string.Empty;
            var attributeList = System.Attribute.GetCustomAttributes(type);
            var attribute = attributeList.OfType<BsonCollection>().FirstOrDefault();
            if (attribute != null)
                result = attribute.Name;
            return result;
        }

        public static Dictionary<string, object> GetBsonElementAttributeList(object obj)
        {
            var result = new Dictionary<string, object>();
            var type = obj.GetType();
            var properties = type.GetProperties();
            foreach (var item in properties)
            {
                var atributeList = System.Attribute.GetCustomAttributes(item);
                var atribute = atributeList.OfType<BsonElementAttribute>().FirstOrDefault();
                if (atribute != null)
                {
                    var name = atribute.ElementName;
                    if (item.PropertyType.Name == typeof (IList<MongoDBRef>).Name)
                    {
                        var list = (IList<MongoDBRef>) type.GetProperty(item.Name).GetValue(obj, null);
                        result.Add(name, list.Count == 0 ? new MongoDBRef[0] : list);
                    }
                    else
                    {
                        result.Add(name, type.GetProperty(item.Name).GetValue(obj, null));
                    }
                }

            }
          
            return result;
        }
    }
}
