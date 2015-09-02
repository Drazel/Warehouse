using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Warehouse.Data.Enum;

namespace Warehouse.Models.ProductList
{
    public class OutProductListModel
    {
        public DateTime Date { get; set; }
        public List<ProductSumModel> Products { get; set; }
        public eDateStatus DateStatus
        {
            get
            {
                var result = eDateStatus.Now;
                if (Date < DateTime.Now.Date)
                    result = eDateStatus.Outstanding;
                else if (Date > DateTime.Now.Date)
                    result = eDateStatus.Futer;
                return result;
            }
        }

        public string PanelType
        {
            get
            {
                var result = string.Empty;
                switch (DateStatus)
                {
                    case eDateStatus.Outstanding:
                        result = "panel-danger";
                        break;
                    case eDateStatus.Now:
                        result = "panel-warning";
                        break;
                    case eDateStatus.Futer:
                        result = "panel-primary";
                        break;
                }
                return result;
            }
        }
    }
}