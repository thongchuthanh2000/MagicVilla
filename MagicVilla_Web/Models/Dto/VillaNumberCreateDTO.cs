using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace MagicVilla_Web.Models.Dto
{
    public class VillaNumberCreateDTO
    {
        [Required]
        public int VillaNo { get; set; }

        [Required]
        public int VillaID { get; set; }

        [Required]
        public string SpecialDetails { get; set; }
    }
}
