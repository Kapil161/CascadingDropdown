using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CascadingDropdown.Models
{
    public class City
    {
        public int Id { get; set; }
        public string CityName { get; set; }
        public State State { get; set; }
    }
}
