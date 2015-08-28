using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Warehouse.ServiceClient.Clients
{
    public class ServiceService
    {
        public int Ping(DateTime date)
        {
            return ServiceManager.Call<WarehouseService.ServiceClient, int>(c => c.Ping(date));
        }
    }
}
