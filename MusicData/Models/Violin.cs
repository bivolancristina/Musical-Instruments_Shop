using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace MusicData.Models
{
    public class Violin : Instrument
    {
        [Required]
        public string ViolinType { get; set; }

        [Required]
        public string BowMaterial { get; set; }
    }
}
