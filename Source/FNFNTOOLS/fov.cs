using System;
using System.Diagnostics;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using IniParser;
using IniParser.Model;
using System.IO;

namespace FNFNTOOLS
{
    public partial class fov : Form
    {
        public fov()
        {
            InitializeComponent();
        }

        private void BtnAppFov_Click(object sender, EventArgs e)
        {
            //Path to config file and remove read-only 
            string path = getCfgFile();
            File.SetAttributes(path, File.GetAttributes(path) & ~FileAttributes.ReadOnly);
            var parser = new FileIniDataParser();
            IniData config = parser.ReadFile(path);

            if (string.IsNullOrEmpty(cbFov.Text))
            {
                string messageError = "Error: Please select a FOV";
                MessageBoxButtons buttonsError = MessageBoxButtons.OK;
                DialogResult resultError;
                resultError = MessageBox.Show(messageError, "Error", buttonsError, MessageBoxIcon.Error);
            }
            else if (cbFov.Text == "100")
            {
                txtRec.Text = "1920 x 810";
                config["/Script/FortniteGame.FortGameUserSettings"]["FullscreenMode"] = "2";
                config["/Script/FortniteGame.FortGameUserSettings"]["bUseDynamicResolution"] = "False";
                config["/Script/FortniteGame.FortGameUserSettings"]["ResolutionSizeX"] = "1920";
                config["/Script/FortniteGame.FortGameUserSettings"]["ResolutionSizeY"] = "810";
                config["/Script/FortniteGame.FortGameUserSettings"]["LastUserConfirmedResolutionSizeX"] = "1920";
                config["/Script/FortniteGame.FortGameUserSettings"]["LastUserConfirmedResolutionSizeY"] = "810";
                config["/Script/FortniteGame.FortGameUserSettings"]["LastConfirmedFullscreenMode"] = "2";
                config["/Script/FortniteGame.FortGameUserSettings"]["PreferredFullscreenMode"] = "2";
                config["/Script/FortniteGame.FortGameUserSettings"]["DesiredScreenWidth"] = "1920";
                config["/Script/FortniteGame.FortGameUserSettings"]["DesiredScreenHeight"] = "810";
                config["/Script/FortniteGame.FortGameUserSettings"]["LastUserConfirmedDesiredScreenWidth"] = "1920";
                config["/Script/FortniteGame.FortGameUserSettings"]["LastUserConfirmedDesiredScreenHeight"] = "810";
            }
            else if (cbFov.Text == "90")
            {
                txtRec.Text = "1920 x 945";
                config["/Script/FortniteGame.FortGameUserSettings"]["FullscreenMode"] = "2";
                config["/Script/FortniteGame.FortGameUserSettings"]["bUseDynamicResolution"] = "False";
                config["/Script/FortniteGame.FortGameUserSettings"]["ResolutionSizeX"] = "1920";
                config["/Script/FortniteGame.FortGameUserSettings"]["ResolutionSizeY"] = "945";
                config["/Script/FortniteGame.FortGameUserSettings"]["LastUserConfirmedResolutionSizeX"] = "1920";
                config["/Script/FortniteGame.FortGameUserSettings"]["LastUserConfirmedResolutionSizeY"] = "945";
                config["/Script/FortniteGame.FortGameUserSettings"]["LastConfirmedFullscreenMode"] = "2";
                config["/Script/FortniteGame.FortGameUserSettings"]["PreferredFullscreenMode"] = "2";
                config["/Script/FortniteGame.FortGameUserSettings"]["DesiredScreenWidth"] = "1920";
                config["/Script/FortniteGame.FortGameUserSettings"]["DesiredScreenHeight"] = "945";
                config["/Script/FortniteGame.FortGameUserSettings"]["LastUserConfirmedDesiredScreenWidth"] = "1920";
                config["/Script/FortniteGame.FortGameUserSettings"]["LastUserConfirmedDesiredScreenHeight"] = "945";
            }

            else if (cbFov.Text == "110")
            {
                txtRec.Text = "1920 x 675";
                config["/Script/FortniteGame.FortGameUserSettings"]["FullscreenMode"] = "2";
                config["/Script/FortniteGame.FortGameUserSettings"]["bUseDynamicResolution"] = "False";
                config["/Script/FortniteGame.FortGameUserSettings"]["ResolutionSizeX"] = "1920";
                config["/Script/FortniteGame.FortGameUserSettings"]["ResolutionSizeY"] = "675";
                config["/Script/FortniteGame.FortGameUserSettings"]["LastUserConfirmedResolutionSizeX"] = "1920";
                config["/Script/FortniteGame.FortGameUserSettings"]["LastUserConfirmedResolutionSizeY"] = "675";
                config["/Script/FortniteGame.FortGameUserSettings"]["LastConfirmedFullscreenMode"] = "2";
                config["/Script/FortniteGame.FortGameUserSettings"]["PreferredFullscreenMode"] = "2";
                config["/Script/FortniteGame.FortGameUserSettings"]["DesiredScreenWidth"] = "1920";
                config["/Script/FortniteGame.FortGameUserSettings"]["DesiredScreenHeight"] = "675";
                config["/Script/FortniteGame.FortGameUserSettings"]["LastUserConfirmedDesiredScreenWidth"] = "1920";
                config["/Script/FortniteGame.FortGameUserSettings"]["LastUserConfirmedDesiredScreenHeight"] = "675";
            }

            else if (cbFov.Text == "120")
            {
                txtRec.Text = "1920 x 540";
                config["/Script/FortniteGame.FortGameUserSettings"]["FullscreenMode"] = "2";
                config["/Script/FortniteGame.FortGameUserSettings"]["bUseDynamicResolution"] = "False";
                config["/Script/FortniteGame.FortGameUserSettings"]["ResolutionSizeX"] = "1920";
                config["/Script/FortniteGame.FortGameUserSettings"]["ResolutionSizeY"] = "540";
                config["/Script/FortniteGame.FortGameUserSettings"]["LastUserConfirmedResolutionSizeX"] = "1920";
                config["/Script/FortniteGame.FortGameUserSettings"]["LastUserConfirmedResolutionSizeY"] = "540";
                config["/Script/FortniteGame.FortGameUserSettings"]["LastConfirmedFullscreenMode"] = "2";
                config["/Script/FortniteGame.FortGameUserSettings"]["PreferredFullscreenMode"] = "2";
                config["/Script/FortniteGame.FortGameUserSettings"]["DesiredScreenWidth"] = "1920";
                config["/Script/FortniteGame.FortGameUserSettings"]["DesiredScreenHeight"] = "540";
                config["/Script/FortniteGame.FortGameUserSettings"]["LastUserConfirmedDesiredScreenWidth"] = "1920";
                config["/Script/FortniteGame.FortGameUserSettings"]["LastUserConfirmedDesiredScreenHeight"] = "540";
            }


            //Overwrite it
            parser.WriteFile(path, config);


            if (chRO.Checked)
            {
                File.SetAttributes(path, File.GetAttributes(path) | FileAttributes.ReadOnly);
            }

            string message = "Settings have been applied";
            MessageBoxButtons buttons = MessageBoxButtons.OK;
            DialogResult result;
            result = MessageBox.Show(message, "Settings Saved", buttons, MessageBoxIcon.Information);
        }

        public string getCfgFile()
        {
            string local = Environment.GetFolderPath(Environment.SpecialFolder.LocalApplicationData);
            string cfgFile = @"\FortniteGame\Saved\Config\WindowsClient\GameUserSettings.ini";
            string path = local + cfgFile;
            return path;
        }

        private void Fov_Load(object sender, EventArgs e)
        {
            string path = getCfgFile();
            if (File.Exists(path) == false)
            {
                MessageBox.Show("Config file not found in path: " + path, "File Not Found", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);

            }
            else
            {
                txtPath.Text = path;
            }
        }

        private void PictureBox2_Click(object sender, EventArgs e)
        {

        }

        private void BtnOpenFolder_Click(object sender, EventArgs e)
        {
            string local2 = Environment.GetFolderPath(Environment.SpecialFolder.LocalApplicationData);
            string cfgFile2 = @"\FortniteGame\Saved\Config\WindowsClient\";
            string path2 = local2 + cfgFile2;
            Process.Start(path2);
        }
    }
}
