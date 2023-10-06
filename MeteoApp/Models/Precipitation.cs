using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MeteoApp.Models
{
    public enum Precipitation
    {
        [Description("Дождь")]
        Дождь,
        [Description("Снег")]
        Снег,
        [Description("Град")]
        Град,
        [Description("Ясно")]
        Ясно,
        [Description("Облачно")]
        Облачно,
        [Description("Туман")]
        Туман
    }
}
