using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Newtonsoft.Json;
using Flurl;
using Flurl.Http;

namespace FNFNTOOLS
{
    public partial class Estadisticas : Form
    {
        public Estadisticas()
        {
            InitializeComponent();
            

        }

        private void Estadisticas_Load(object sender, EventArgs e)
        {
           
            
        }

        public async Task<string> LoadUid(string username)
        {
            Rootouser user = new Rootouser();
            string url = "https://fortnite-public-api.theapinetwork.com/prod09/users/id?username=" + username;
            string id = await url.GetStringAsync();
            user = JsonConvert.DeserializeObject<Rootouser>(id);
            txtUID.Text = "UID: " + user.uid;
            return user.uid;
            
        }

        public async Task LoadStats(string username, string platform)
        {
            //Using FortniteAPI
            Rootobject root = new Rootobject();
            Error error = new Error();
            string uid = await LoadUid(username);
            string url = "https://fortnite-public-api.theapinetwork.com/prod09/users/public/br_stats?user_id=" + uid + "&platform=" + platform;
            string text = await url.GetStringAsync();
            root = JsonConvert.DeserializeObject<Rootobject>(text);
            error = JsonConvert.DeserializeObject<Error>(text);
            Totals global = root.totals;
            Stats individual = root.stats;
            
            if (error.error == true)
            {
                string message = "Error: " + error.numericErrorCode.ToString() + " " + error.errorMessage;
                MessageBoxButtons buttons = MessageBoxButtons.OK;
                DialogResult result;
                result = MessageBox.Show(message,"Error",buttons, MessageBoxIcon.Error);
            }
            else
            {
                //Global stats load
                txtWins.Text = global.wins.ToString();
                txtWr.Text = global.winrate.ToString();
                txtKD.Text = global.kd.ToString();
                txtKills.Text = global.kills.ToString();
                txtMatches.Text = global.matchesplayed.ToString();

                //Solo stats load
                txtSoloWins.Text = individual.placetop1_solo.ToString();
                txtSoloKills.Text = individual.kills_solo.ToString();
                txtTop10Solo.Text = individual.placetop10_solo.ToString();
                txtTop25Solo.Text = individual.placetop25_solo.ToString();
                txtWrSolo.Text = individual.winrate_solo.ToString();
                txtKdSolo.Text = individual.kd_solo.ToString();
                txtSoloMatches.Text = individual.matchesplayed_solo.ToString() + " Matches";

                //Duo stats load
                txtDuoWins.Text = individual.placetop1_duo.ToString();
                txtDuoKills.Text = individual.kills_duo.ToString();
                txtDuoTop5.Text = individual.placetop5_duo.ToString();
                txtDuoTop12.Text = individual.placetop12_duo.ToString();
                txtDuoWr.Text = individual.winrate_duo.ToString();
                txtDuoKd.Text = individual.kd_duo.ToString();
                txtDuoMatches.Text = individual.matchesplayed_duo.ToString() + " Matches";

                //Squad stats load

                txtSquadWins.Text = individual.placetop1_squad.ToString();
                txtSquadKills.Text = individual.kills_squad.ToString();
                txtSquadTop3.Text = individual.placetop3_squad.ToString();
                txtSquadTop6.Text = individual.placetop6_squad.ToString();
                txtSquadWr.Text = individual.winrate_squad.ToString();
                txtSquadKd.Text = individual.kd_squad.ToString();
                txtSquadMatches.Text = individual.matchesplayed_squad.ToString() + " Matches";
            }
            
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void txtWins_TextChanged(object sender, EventArgs e)
        {

        }

        private async void btnSearch_Click(object sender, EventArgs e)
        {
            string username = txtSearch.Text;
            string platform = cbPlatform.Text;
            await LoadStats(txtSearch.Text, platform);
        }
    }
}
