﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MIShop.Models.CatalogModels
{
    public class InstrumentIndexListingModel
    {
        public int Id { get; set; }
        public string ImageUrl { get; set; }
        public string BrandName { get; set; }
        public string BrandModel { get; set; }
        public string Type { get; set; }
        public string Characteristic { get; set; }
    }
}
