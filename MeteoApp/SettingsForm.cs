using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MeteoApp
{
    public partial class SettingsForm : Form
    {

        string path = Environment.GetFolderPath(Environment.SpecialFolder.DesktopDirectory);
        public SettingsForm()
        {
            InitializeComponent();           
        }

        Form1 form1 = new Form1();

        private void PathSave_Click(object sender, EventArgs e)
        {
            using (var path_dialog = new FolderBrowserDialog())
                if (path_dialog.ShowDialog() == System.Windows.Forms.DialogResult.OK)
                {
                    //Путь к директории
                    path = path_dialog.SelectedPath;
                    PathSave.Text = path;
                }

        }

        private void Start_Click(object sender, EventArgs e)
        {
            DataSetting.Path = path;
            DataSetting.Stanart = Standart.Checked;
            DataSetting.JSON = JSONFormat.Checked;
            DataSetting.XML= XMLFormat.Checked;

            form1.Show();
            Close();
        }
    }
}
