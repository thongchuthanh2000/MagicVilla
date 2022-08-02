using MagicVilla_VillaAPI.Models.Dto;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MagicVilla_VillaAPI.Data
{
    public static class VillaStore
    {
        public static List<VillaDTO> villaList = new List<VillaDTO>
            {
                new VillaDTO{ Id = 1, Name = "Pool View", Sqft = 100, Occupancy = 1000},
                new VillaDTO{ Id = 2,Name = "Beach View", Sqft = 200, Occupancy = 1500}
            };
    }
}
