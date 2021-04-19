using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TourPlanner.Models
{
    public class Tour
    {
        private string name;
        private string description;
        private string route;
        private string distance;

        public string Name { get => name; set => name = value; }
        public string Description { get => description; set => description = value; }
        public string Route { get => route; set => route = value; }
        public string Distance { get => distance; set => distance = value; }
    }
}
