using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MeteoApp
{
    static class DataSetting
    {
        public static string Path = Environment.GetFolderPath(Environment.SpecialFolder.DesktopDirectory);
        public static bool Stanart = true;
        public static bool JSON = false;
        public static bool XML = false;
    }
}
