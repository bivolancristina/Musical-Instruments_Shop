using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using MIShop.Models.CatalogModels;
using MusicData.Interfaces;
using System.Linq;

namespace MIShop.Controllers
{
    public class CatalogController : Controller
    {
        private IInstrument _instruments;

        public CatalogController(IInstrument instruments)
        {
            _instruments = instruments;
        }
        public IActionResult Index()
        {
            var instrumentModels = _instruments.GetAll();

            var listingResult = instrumentModels
                .Select(result => new InstrumentIndexListingModel
                {
                    Id = result.Id,
                    ImageUrl = result.ImageUrl,
                    BrandName = result.BrandName,
                    BrandModel = result.BrandModel,
                    Type = _instruments.GetType(result.Id),
                    Characteristic = _instruments.GetCharacteristic(result.Id)
                });

            var model = new InstrumentIndexModel()
            {
                Instruments = listingResult
            };

            return View(model);
        }

        public IActionResult Detail(int id)
        {
            var instrument = _instruments.GetById(id);

            var model = new InstrumentDetailModel
            {
                AssetId = id,
                BrandName = instrument.BrandName,
                BrandModel = instrument.BrandModel,
                Type = _instruments.GetType(instrument.Id),
                Characteristic = _instruments.GetCharacteristic(instrument.Id),
                Price = instrument.Price,
                Stock = instrument.Stock,
                ImageUrl = instrument.ImageUrl,
                Description = instrument.Description
        };

            return View(model);
        }

        public IActionResult ShowGuitars()
        {
            var instrumentModels = _instruments.GetAll("Guitars");

            var listingResult = instrumentModels
                .Select(result => new InstrumentIndexListingModel
                {
                    Id = result.Id,
                    ImageUrl = result.ImageUrl,
                    BrandName = result.BrandName,
                    BrandModel = result.BrandModel,
                    Type = _instruments.GetType(result.Id),
                    Characteristic = _instruments.GetCharacteristic(result.Id)
                });

            var model = new InstrumentIndexModel()
            {
                Instruments = listingResult
            };

            return View(model);
        }

        public IActionResult ShowDrums()
        {
            var instrumentModels = _instruments.GetAll("Drums");

            var listingResult = instrumentModels
                .Select(result => new InstrumentIndexListingModel
                {
                    Id = result.Id,
                    ImageUrl = result.ImageUrl,
                    BrandName = result.BrandName,
                    BrandModel = result.BrandModel,
                    Type = _instruments.GetType(result.Id),
                    Characteristic = _instruments.GetCharacteristic(result.Id)
                });

            var model = new InstrumentIndexModel()
            {
                Instruments = listingResult
            };

            return View(model);
        }

        public IActionResult ShowViolins()
        {
            var instrumentModels = _instruments.GetAll("Violins");

            var listingResult = instrumentModels
                .Select(result => new InstrumentIndexListingModel
                {
                    Id = result.Id,
                    ImageUrl = result.ImageUrl,
                    BrandName = result.BrandName,
                    BrandModel = result.BrandModel,
                    Type = _instruments.GetType(result.Id),
                    Characteristic = _instruments.GetCharacteristic(result.Id)
                });

            var model = new InstrumentIndexModel()
            {
                Instruments = listingResult
            };

            return View(model);
        }

        public IActionResult ShowFlutes()
        {
            var instrumentModels = _instruments.GetAll("Flutes");

            var listingResult = instrumentModels
                .Select(result => new InstrumentIndexListingModel
                {
                    Id = result.Id,
                    ImageUrl = result.ImageUrl,
                    BrandName = result.BrandName,
                    BrandModel = result.BrandModel,
                    Type = _instruments.GetType(result.Id),
                    Characteristic = _instruments.GetCharacteristic(result.Id)
                });

            var model = new InstrumentIndexModel()
            {
                Instruments = listingResult
            };

            return View(model);
        }

        [Authorize(Roles = "Admin")]
        public IActionResult DeleteItem(int id)
        {
            _instruments.DeleteItem(_instruments.GetById(id));

            return RedirectToAction("Index", "Catalog");
        }

        public IActionResult CreateProduct(int id)
        {
            return View();
        }
    }

}
