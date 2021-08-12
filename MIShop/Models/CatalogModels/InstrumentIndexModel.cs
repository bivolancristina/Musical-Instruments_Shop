using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MIShop.Models.CatalogModels
{
    public class InstrumentIndexModel
    {
        public IEnumerable<InstrumentIndexListingModel> Instruments { get; set; }
    }
}
