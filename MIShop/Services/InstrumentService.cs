using MIShop.Data;
using MusicData.Interfaces;
using MusicData.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MIShop.Services
{
    public class InstrumentService : IInstrument
    {

        private ApplicationDbContext _context;

        public InstrumentService(ApplicationDbContext context)
        {
            _context = context;
        }
        public void Add(Instrument newInstrument)
        {
            _context.Add(newInstrument);
            _context.SaveChanges();
        }

        public void DeleteItem(Instrument instrument)
        {
            _context.Remove(instrument);
            _context.SaveChanges();
        }

        public IEnumerable<Instrument> GetAll()
        {
            return _context.Instruments;
        }

        public IEnumerable<Instrument> GetAll(string category)
        {
            switch(category)
            {
                case "Guitars":
                    return _context.Guitars;
                case "Drums":
                    return _context.Drums;
                case "Violins":
                    return _context.Violins;
                case "Flutes":
                    return _context.Flutes;
                default:
                    return _context.Instruments;
            }
        }

        public Instrument GetById(int id)
        {
            return
                GetAll()
                .FirstOrDefault(instrument => instrument.Id == id);
        }

        public string GetCharacteristic(int id)
        {
            var isGuitar = _context.Instruments.OfType<Guitar>()
                .Where(a => a.Id == id).Any();

            var isDrums = _context.Instruments.OfType<Drums>()
                .Where(a => a.Id == id).Any();

            var isViolin = _context.Instruments.OfType<Violin>()
                .Where(a => a.Id == id).Any();

            var isFlute = _context.Instruments.OfType<Flute>()
                .Where(a => a.Id == id).Any();

            if (isGuitar)
            {
                return _context.Guitars.FirstOrDefault(guitar => guitar.Id == id).NumberOfStrings.ToString() + " Strings";
            }
            else if (isDrums)
            {
                return _context.Drums.FirstOrDefault(drums => drums.Id == id).DrumMeshMaterial;
            }
            else if (isViolin)
            {
                return _context.Violins.FirstOrDefault(violin => violin.Id == id).BowMaterial;
            }
            else if (isFlute)
            {
                return _context.Flutes.FirstOrDefault(flute => flute.Id == id).Material;
            }
            else
            {
                return "";
            }
        }

        public string GetType(int id)
        {
            var isGuitar = _context.Instruments.OfType<Guitar>()
                .Where(a => a.Id == id).Any();

            var isDrums = _context.Instruments.OfType<Drums>()
                .Where(a => a.Id == id).Any();

            var isViolin = _context.Instruments.OfType<Violin>()
                .Where(a => a.Id == id).Any();

            var isFlute = _context.Instruments.OfType<Flute>()
                .Where(a => a.Id == id).Any();

            if (isGuitar)
            {
                return _context.Guitars.FirstOrDefault(guitar => guitar.Id == id).GuitarType;
            }
            else if (isDrums)
            {
                return _context.Drums.FirstOrDefault(drums => drums.Id == id).DrumType;
            }
            else if (isViolin)
            {
                return _context.Violins.FirstOrDefault(violin => violin.Id == id).ViolinType;
            }
            else if (isFlute)
            {
                return _context.Flutes.FirstOrDefault(flute => flute.Id == id).FluteType;
            }
            else
            {
                return "";
            }

        }
    }
}
