using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;
using WarehouseResource;

namespace Warehouse.Models.Package
{
    public class PackageModel
    {
        public string Id { get; set; }

        [Required]
        [Display(Name = "Name", ResourceType = typeof(ResGlobal))]
        public string Name { get; set; }

        [Required]
        [Display(Name = "Width", ResourceType = typeof(ResGlobal))]
        public int Width { get; set; }

        [Required]
        [Display(Name = "Height", ResourceType = typeof(ResGlobal))]
        public int Height { get; set; }

        [Required]
        [Display(Name = "Length", ResourceType = typeof(ResGlobal))]
        public int Length { get; set; }
    }
}