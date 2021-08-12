using MusicData.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace MusicData.Interfaces
{
    public interface IInstrument
    {
        IEnumerable<Instrument> GetAll();
        IEnumerable<Instrument> GetAll(string category);
        Instrument GetById(int id);
        void Add(Instrument newInstrument);
        public string GetType(int id);
        public string GetCharacteristic(int id);

        public void DeleteItem(Instrument instrument);
    }
}
