using System.ComponentModel.DataAnnotations;
using WarehouseResource;

namespace Warehouse.Models.Product
{
    public class ProductModel
    {
        #region Properties

        public string Id { get; set; }

        [Required]
        [Display(Name = "Name", ResourceType = typeof (ResGlobal))]
        public string Name { get; set; }

        [Required]
        [Display(Name = "Ean", ResourceType = typeof (ResProduct))]
        public string Ean { get; set; }

        [Required]
        [Display(Name = "Width", ResourceType = typeof (ResGlobal))]
        public int Width { get; set; }

        [Required]
        [Display(Name = "Height", ResourceType = typeof (ResGlobal))]
        public int Height { get; set; }

        [Required]
        [Display(Name = "Length", ResourceType = typeof (ResGlobal))]
        public int Length { get; set; }

        [Required]
        [Display(Name = "Weight", ResourceType = typeof (ResGlobal))]
        public double Weight { get; set; }

        #endregion
    }
}