using MeteoApp.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MeteoApp.Model
{
    public class MeteoData
    {
        public int Id { get; set; }
        public string TempCel { get; set; }
        public string Precipitation { get; set; }
        public string? Comment { get; set; }
        public DateTime Created { get; set;}
    }
}
