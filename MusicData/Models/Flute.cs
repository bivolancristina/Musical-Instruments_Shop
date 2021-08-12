using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace MusicData.Models
{
    public class Flute : Instrument
    {
        [Required]
        public string FluteType { get; set; }

        public string Material { get; set; }
    }
}
