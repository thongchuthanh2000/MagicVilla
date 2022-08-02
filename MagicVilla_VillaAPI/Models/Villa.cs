using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MagicVilla_VillaAPI.Models
{
    public class Villa
    {
        public int Id { get; set; }

        public string Name { get; set; }

        public DateTime CreatedTime { get; set; }

        public int Sqft { get; set; }

        public int Occupancy { get; set; }
    }
}
