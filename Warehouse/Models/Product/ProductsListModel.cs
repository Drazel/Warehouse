using System.Collections.Generic;

namespace Warehouse.Models.Product
{
    public class ProductsListModel
    {
        #region Properties

        public List<ProductModel> Products { get; set; }

        #endregion

        #region Constructors

        public ProductsListModel()
        {
            Products = new List<ProductModel>();
        }

        public ProductsListModel(List<ProductModel> products)
        {
            Products = products;
        }

        #endregion
    }
}