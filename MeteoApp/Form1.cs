using MeteoApp.Model;
using MeteoApp.Models;
using Microsoft.EntityFrameworkCore;

namespace MeteoApp
{
    public partial class Form1 : Form
    {
        MeteoDataContext db = new MeteoDataContext();

        public Form1()
        {
            InitializeComponent();
        }


        private void Form1_Load(object sender, EventArgs e)
        {
            foreach (var item in Enum.GetValues(typeof(Precipitation)))
            {
                weather.Items.Add(item);
            }
            //db.Database.EnsureDeleted();
            db.Database.EnsureCreated();

            db.MeteoDatas.Load();
            
        }

        private void maskedTextBox1_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }


        private void SaveInFile_Click(object sender, EventArgs e)
        {
            string path = DataSetting.Path;

            MeteoData data= new MeteoData();
            data.TempCel = TempCelForm.Text;
            data.Precipitation = weather.Text;
            data.Comment = Comt.Text;
            data.Created = DateTime.Now;

            if (SaveData.ValidTemp(data))
            {

                if (DataSetting.Stanart)
                {
                    SaveData.SaveFile(data, path);
                    MessageBox.Show($"Файл сохранён в {DataSetting.Path}");
                }
                else if (DataSetting.JSON)
                {
                    SaveData.SaveFileJSON(data, path);
                    MessageBox.Show($"Файл сохранён в {DataSetting.Path}");
                }
                else
                {
                    SaveData.SaveFileXML(data, path);
                    MessageBox.Show($"Файл сохранён в {DataSetting.Path}");
                }
            }
            else
            {
                MessageBox.Show("Не верно введена температура");
            }
        }

        private void View_Click(object sender, EventArgs e)
        {
            MeteoData data = new MeteoData();
            data.TempCel = TempCelForm.Text;
            data.Precipitation = weather.Text;
            data.Comment = Comt.Text;
            data.Created = DateTime.Now;

            if (SaveData.ValidTemp(data)) MessageBox.Show(SaveData.ViewMet(data));
            
            else MessageBox.Show("Не верно введена температура");

        }

        private void SaveDB_Click(object sender, EventArgs e)
        {
            MeteoData data = new MeteoData();
            data.TempCel = TempCelForm.Text;
            data.Precipitation = weather.Text;
            data.Comment = Comt.Text;
            data.Created = DateTime.Now;

            if (SaveData.ValidTemp(data))
            {
                db.Add(data);
                db.SaveChanges();
                MessageBox.Show("Файл сохранён");
            }
            else MessageBox.Show("Не верно введена температура");
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}