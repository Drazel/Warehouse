using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using Warehouse.Data.Dto;
using Warehouse.Data.Helper;
using Warehouse.Data.Repository;

namespace TestConsole
{
    class Program
    {
        static void Main(string[] args)
        {
            var socect = new WarehouseSocet
                         {
                             Length = 10,
                             Height = 10, MaxWeight = 10,
                             RowBookstand = 1,
                             ShelfBookstand = 10,
                             SocetNumber = 123,
                             UseVolume = 0,
                             UseWeight = 0,
                             Width = 12
                         };

            var rep = new WarehouseSocetRepository();
            socect = rep.GetById("55e0816e546c551fb48775ff");

            rep.Update(socect);

        }
    }
}
