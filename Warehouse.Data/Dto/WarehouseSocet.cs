﻿using System.Collections.Generic;
using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;
using MongoDB.Driver;
using Warehouse.Data.Attribute;

namespace Warehouse.Data.Dto
{
    [BsonCollection("WarehouseSocet")]  
    public class WarehouseSocet
    {
        #region Properties

        public ObjectId Id { get; set; }

        [BsonElementAttribute("Row")]
        public int RowBookstand { get; set; }

        [BsonElementAttribute("Shelf")]
        public int ShelfBookstand { get; set; }

        [BsonElementAttribute("SocetNumber")]
        public int SocetNumber { get; set; }

        [BsonElementAttribute("SocetBarcode")]
        public string SocetBarcode { get { return string.Format("{0}{1}{2}", RowBookstand.ToString().PadLeft(4, '0'), ShelfBookstand.ToString().PadLeft(4, '0'), SocetNumber.ToString().PadLeft(12, '0')); } }

        [BsonElementAttribute("Width")]
        public int Width { get; set; }

        [BsonElementAttribute("Height")]
        public int Height { get; set; }

        [BsonElementAttribute("Length")]
        public int Length { get; set; }

        [BsonElementAttribute("MaxWeight")]
        public double MaxWeight { get; set; }

        [BsonElementAttribute("MaxVolume")]
        public int MaxVolume { get { return Width * Height * Length; } }

        [BsonElementAttribute("UseWeight")]
        public double UseWeight { get; set; }

        [BsonElementAttribute("UseVolume")]
        public int UseVolume { get; set; }

        [BsonElementAttribute("FreeWeight")]
        public double FreeWeight { get { return MaxWeight - UseWeight; } }

        [BsonElementAttribute("FreeVolume")]
        public int FreeVolume { get { return MaxVolume - UseVolume; } }

        #endregion

    }
}