using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TourPlanner.Models
{
    public class TourLog
    {
        private string tourName;
        private DateTime date;
        private DateTime duration;
        private long distance;

        public string TourName { get => tourName; set => tourName = value; }
        public DateTime Date { get => date; set => date = value; }
        public DateTime Duration { get => duration; set => duration = value; }
        public long Distance { get => distance; set => distance = value; }
    }
}
