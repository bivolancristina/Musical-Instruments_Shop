using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace MusicData.Models
{
    public class Drums : Instrument
    {
        [Required]
        public string DrumMeshMaterial { get; set; }

        [Required]
        public string DrumType { get; set; }
    }
}
