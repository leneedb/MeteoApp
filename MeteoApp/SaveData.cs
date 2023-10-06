using MeteoApp.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace MeteoApp
{
    public class SaveData
    {
        

        public static void SaveFile(MeteoData data, string pathsave)
        {
            DateTime date = DateTime.Now;
            StreamWriter file = new StreamWriter(pathsave + "\\Погода от " + date.ToString("dd.MM.yyyy hh.mm.ss") + ".txt");

            file.WriteLine($"ID: {data.Id}");
            file.WriteLine($"Дата и время: {data.Created.ToString("dd.MM.yyyy hh:mm:ss")}");
            file.WriteLine($"Температура: {data.TempCel}");
            file.WriteLine($"Погодные условия: {data.Precipitation}");
            file.WriteLine($"Заметки: \n{data.Comment}");
            file.Close();
        }

        public static void SaveFileJSON(MeteoData data, string pathsave)
        {
            DateTime date = DateTime.Now;
            using (FileStream fs = new FileStream(pathsave+"\\Погода от " + date.ToString("dd.MM.yyyy hh.mm.ss") + ".json", FileMode.OpenOrCreate))
            {
                JsonSerializer.Serialize(fs, data);
            }
        }

        public static void SaveFileXML(MeteoData data, string pathsave)
        {
            DateTime date = DateTime.Now;

            XDocument xdoc = new XDocument(new XElement("MeteoData",
                new XElement("Data",
                    new XElement("TemperatureCel",data.TempCel),
                    new XElement("Precipitation",data.Precipitation),
                    new XElement("Comment",data.Comment),
                    new XElement("DateTime",data.Created.ToString("dd.MM.yyyy hh:mm:ss")))));
                xdoc.Save(pathsave+"\\Погода от " + date.ToString("dd.MM.yyyy hh.mm.ss") + ".xml");
        }

        public static string ViewMet(MeteoData data)
        {
            return $"Дата и время:\n{data.Created.ToString("dd.MM.yyyy hh:mm:ss")}\n\nТемпература: {data.TempCel}\nПогодные условия: {data.Precipitation}\nЗаметки:\n{data.Comment}"; 
        }

        public static bool ValidTemp(MeteoData data)
        {
            char[] tc= data.TempCel.ToCharArray();
            if (!tc[0].Equals("-") || !tc[0].Equals("+"))
            {
                if (tc[0] == '0')
                    return true;
                else return false;
            }
            else return true;
            
        }


    }
}
