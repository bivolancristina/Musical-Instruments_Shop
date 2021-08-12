using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace MusicData.Models
{
    public class Guitar : Instrument
    {
        [Required]
        public int NumberOfStrings { get; set; }

        [Required]
        public string GuitarType { get; set; }
    }
}
