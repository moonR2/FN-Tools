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
    public partial class cfg : Form
    {
        public cfg()
        {
            InitializeComponent();
        }

        private void cfg_Load(object sender, EventArgs e)
        {
            string path = getCfgFile();
            if (File.Exists(path) == false)
            {
                MessageBox.Show("Config file not found in path: " + path, "File Not Found", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);


            }
            else
            {
                txtPath.Text = path;
                var parser = new FileIniDataParser();
                IniData config = parser.ReadFile(path);

                //Script Groups
                cbBoolean.Text = config["/Script/FortniteGame.FortGameUserSettings"]["bMotionBlur"];
                cbShowGrass.Text = config["/Script/FortniteGame.FortGameUserSettings"]["bShowGrass"];
                cbShowFPS.Text = config["/Script/FortniteGame.FortGameUserSettings"]["bShowFPS"];
                cbMouse.Text = config["/Script/FortniteGame.FortGameUserSettings"]["bDisableMouseAcceleration"];
                cbVsync.Text = config["/Script/FortniteGame.FortGameUserSettings"]["bUseVSync"];
                //Scalability Groups
                cbDistanceQuality.Text = config["ScalabilityGroups"]["sg.ViewDistanceQuality"];
                cbEffectsQuality.Text = config["ScalabilityGroups"]["sg.EffectsQuality"];
                cbFoliageQuality.Text = config["ScalabilityGroups"]["sg.FoliageQuality"];
                cbPostProcess.Text = config["ScalabilityGroups"]["sg.PostProcessQuality"];
                cbShadowQuality.Text = config["ScalabilityGroups"]["sg.ShadowQuality"];
                cbTextureQuality.Text = config["ScalabilityGroups"]["sg.TextureQuality"];
                cbAntiAliasing.Text = config["ScalabilityGroups"]["sg.AntiAliasingQuality"];
            }
        }
        public string getCfgFile()
        {
            string local = Environment.GetFolderPath(Environment.SpecialFolder.LocalApplicationData);
            string cfgFile = @"\FortniteGame\Saved\Config\WindowsClient\GameUserSettings.ini";
            string path = local + cfgFile;
            return path;
        }

        private void btnCreateBackup_Click(object sender, EventArgs e)
        {
            string path = getCfgFile();
            var parser = new FileIniDataParser();
            IniData config = parser.ReadFile(path);
            string local = Environment.GetFolderPath(Environment.SpecialFolder.LocalApplicationData);
            string cfgFile = @"\FortniteGame\Saved\Config\WindowsClient\GameUserSettings.backup.ini";
            path = local + cfgFile;
            parser.WriteFile(path, config);
            string message = "Backup Created";
            MessageBoxButtons buttons = MessageBoxButtons.OK;
            DialogResult result;
            result = MessageBox.Show(message, "Backup Saved", buttons, MessageBoxIcon.Information);
        }

        private void btnRestoreBackup_Click(object sender, EventArgs e)
        {
            string message = "Are you sure you restore the backup?";
            MessageBoxButtons buttons = MessageBoxButtons.YesNo;
            DialogResult result;
            result = MessageBox.Show(message, "Backup Options", buttons, MessageBoxIcon.Information);
            if (result == DialogResult.Yes)
            {
                string path;
                string local = Environment.GetFolderPath(Environment.SpecialFolder.LocalApplicationData);
                string cfgFile = @"\FortniteGame\Saved\Config\WindowsClient\GameUserSettings.backup.ini";
                path = local + cfgFile;
                var parser = new FileIniDataParser();
                IniData config = parser.ReadFile(path);
                path = getCfgFile();
                File.SetAttributes(path, File.GetAttributes(path) & ~FileAttributes.ReadOnly);
                parser.WriteFile(path, config);
                string message2 = "Backup Restored";
                MessageBoxButtons buttons2 = MessageBoxButtons.OK;
                DialogResult result2;
                result2 = MessageBox.Show(message2, "Backup Restored.", buttons2, MessageBoxIcon.Information);

            }
            else
            {
                string message2 = "Canceled operation.";
                MessageBoxButtons buttons2 = MessageBoxButtons.OK;
                DialogResult result2;
                result2 = MessageBox.Show(message2, "Backup Options", buttons2, MessageBoxIcon.Information);
            }
            



        }

        private void comboBox5_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void btnApply_Click(object sender, EventArgs e)
        {
            string path = getCfgFile();

            File.SetAttributes(path, File.GetAttributes(path) & ~FileAttributes.ReadOnly);
            var parser = new FileIniDataParser();
            IniData config = parser.ReadFile(path);

            //Script Groups
            config["/Script/FortniteGame.FortGameUserSettings"]["bMotionBlur"] = cbBoolean.Text;
            config["/Script/FortniteGame.FortGameUserSettings"]["bShowGrass"] = cbShowGrass.Text;
            config["/Script/FortniteGame.FortGameUserSettings"]["bShowFPS"] = cbShowFPS.Text;
            config["/Script/FortniteGame.FortGameUserSettings"]["bDisableMouseAcceleration"] = cbMouse.Text;
            config["/Script/FortniteGame.FortGameUserSettings"]["bUseVSync"] = cbVsync.Text;
            //Scalability Groups
            config["ScalabilityGroups"]["sg.ViewDistanceQuality"] = cbDistanceQuality.Text;
            config["ScalabilityGroups"]["sg.EffectsQuality"] = cbEffectsQuality.Text;
            config["ScalabilityGroups"]["sg.FoliageQuality"] = cbFoliageQuality.Text;
            config["ScalabilityGroups"]["sg.PostProcessQuality"] = cbPostProcess.Text;
            config["ScalabilityGroups"]["sg.ShadowQuality"] = cbShadowQuality.Text;
            config["ScalabilityGroups"]["sg.TextureQuality"] = cbTextureQuality.Text;
            config["ScalabilityGroups"]["sg.AntiAliasingQuality"] = cbAntiAliasing.Text;

            //Overwrite it
            parser.WriteFile(path, config);

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
}
