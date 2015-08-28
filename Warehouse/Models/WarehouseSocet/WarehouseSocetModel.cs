using System.ComponentModel.DataAnnotations;
using System.IO;
using WarehouseResource;

namespace Warehouse.Models.WarehouseSocet
{
    public class WarehouseSocetModel
    {
        public string Id { get; set; }

        [Required]
        [Display(Name = "RowBookstand", ResourceType = typeof(ResSocet))]
        public int RowBookstand { get; set; }

        [Required]
        [Display(Name = "ShelfBookstand", ResourceType = typeof(ResSocet))]
        public int ShelfBookstand { get; set; }

        [Required]
        [Display(Name = "SocetNumber", ResourceType = typeof(ResSocet))]
        public int SocetNumber { get; set; }

        [Required]
        [Display(Name = "Width", ResourceType = typeof(ResSocet))]
        public int Width { get; set; }

        [Required]
        [Display(Name = "Height", ResourceType = typeof(ResSocet))]
        public int Height { get; set; }

        [Required]
        [Display(Name = "Length", ResourceType = typeof(ResSocet))]
        public int Length { get; set; }

        [Required]
        [Display(Name = "MaxWeight", ResourceType = typeof(ResSocet))]
        public int MaxWeight { get; set; }

        public int UseWeight { get; set; }

        public int MaxVolume { get { return Width * Height * Length; } }

        [Display(Name = "UseVolume", ResourceType = typeof(ResSocet))]
        public int UseVolume { get; set; }
    }
}