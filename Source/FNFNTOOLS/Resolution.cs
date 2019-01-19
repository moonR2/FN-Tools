using System;
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
    public partial class Resolution : Form
    {
        public Resolution()
        {
            InitializeComponent();
            this.cb3DRes.MouseHover += cb3dMouseHover;
            this.cbFps.MouseHover += cbFpsMouseHover;
            this.cbResX.MouseHover += cbResXMouseHover;
            this.cbResY.MouseHover += cbResYMouseHover;
            
        }

        private void Resolution_Load(object sender, EventArgs e)
        {
            string path = getCfgFile();
            string userResWidth = Screen.PrimaryScreen.Bounds.Width.ToString();
            string userResHeight = Screen.PrimaryScreen.Bounds.Height.ToString();
            txtUserRes.Text = "Your Primary Screen Resolution: " + userResWidth + "X" + userResHeight;

            
            if (File.Exists(path) == false)
            {
                MessageBox.Show("Config file not found in path: " + path, "File Not Found", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);

            }
            else
            {
                txtPath.Text = path;
            }
        }

        private void btnChangeRes_Click(object sender, EventArgs e)
        {
            //Path to config file
            string path = getCfgFile();

            //Check for config file


            // Check for not empty boxes
            if (string.IsNullOrEmpty(cbResX.Text) || string.IsNullOrEmpty(cbResY.Text) || string.IsNullOrEmpty(cbFps.Text) || string.IsNullOrEmpty(cb3DRes.Text))
            {
                string messageError = "Error: Please fill all the boxes";
                MessageBoxButtons buttonsError = MessageBoxButtons.OK;
                DialogResult resultError;
                resultError = MessageBox.Show(messageError, "Error", buttonsError, MessageBoxIcon.Error);
            }
            else
            {
                // Remove read only and parse config file
                string fps;
                File.SetAttributes(path, File.GetAttributes(path) & ~FileAttributes.ReadOnly);
                var parser = new FileIniDataParser();
                IniData config = parser.ReadFile(path);

                //Handle Unlimited option
                if (cbFps.Text == "Unlimited")
                {
                    fps = "Unlimited";
                }
                else
                {
                    fps = cbFps.Text + ".000000";
                }

                //Change data in parsed config file
                config["/Script/FortniteGame.FortGameUserSettings"]["ResolutionSizeX"] = cbResX.Text;
                config["/Script/FortniteGame.FortGameUserSettings"]["ResolutionSizeY"] = cbResY.Text;
                config["/Script/FortniteGame.FortGameUserSettings"]["LastUserConfirmedResolutionSizeX"] = cbResX.Text;
                config["/Script/FortniteGame.FortGameUserSettings"]["LastUserConfirmedResolutionSizeY"] = cbResY.Text;
                config["/Script/FortniteGame.FortGameUserSettings"]["FrameRateLimit"] = fps;
                config["ScalabilityGroups"]["sg.ResolutionQuality"] = cb3DRes.Text + ".000000";
                if (chReadOnly.Checked)
                {
                    config["/Script/FortniteGame.FortGameUserSettings"]["FullscreenMode"] = "0";
                }

                //Overwrite it
                parser.WriteFile(path, config);

                // Set read only
                if (chReadOnly.Checked)
                {
                    File.SetAttributes(path, File.GetAttributes(path) | FileAttributes.ReadOnly);
                }

                string message = "Settings have been applied";
                MessageBoxButtons buttons = MessageBoxButtons.OK;
                DialogResult result;
                result = MessageBox.Show(message, "Settings Saved", buttons, MessageBoxIcon.Information);

            }
        }

        public string getCfgFile()
        {
            string local = Environment.GetFolderPath(Environment.SpecialFolder.LocalApplicationData);
            string cfgFile = @"\FortniteGame\Saved\Config\WindowsClient\GameUserSettings.ini";
            string path = local + cfgFile;
            return path;
        }

        //Mouse hover functions
        private void cb3dMouseHover(object sender,EventArgs e)
        {
            txtInfo.Text = "3D Resolution, only use integers. Lowering this parameter will increase the fps, but will cause pixellated images. It is recommended not to use it below 85.";
        }

        private void cbFpsMouseHover(object sender, EventArgs e)
        {
            txtInfo.Text = "Frame Rate Limit";
        }

        private void cbResXMouseHover(object sender, EventArgs e)
        {
            txtInfo.Text = "Width Resolution";
        }

        private void cbResYMouseHover(object sender, EventArgs e)
        {
            txtInfo.Text = "Height Resolution";
        }

    }
}
