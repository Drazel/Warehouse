using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Warehouse.Data.Helper;

namespace Warehouse.Data.Attribute
{
    public class BsonCollection : System.Attribute
    {
        public string Name { get; set; }

        public BsonCollection(string name)
        {
            this.Name = name;
        }
    }
}
