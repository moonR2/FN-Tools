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
    public partial class news : Form
    {
        public news()
        {
            InitializeComponent();
        }

        private async void news_Load(object sender, EventArgs e)
        {
            brnews.newsRoot root = new brnews.newsRoot();
            status.Rootobject rootStatus = new status.Rootobject();
            string urlStatus = "https://fortnite-public-api.theapinetwork.com/prod09/status/fortnite_server_status";
            string urlNews = "https://fortnite-public-api.theapinetwork.com/prod09/br_motd/get?language=en";
            string info = await urlNews.GetStringAsync();
            string infoStatus = await urlStatus.GetStringAsync();
            root = JsonConvert.DeserializeObject<brnews.newsRoot>(info);
            rootStatus = JsonConvert.DeserializeObject<status.Rootobject>(infoStatus);
            brnews.Entry[] entries = root.entries;
            news1.Load(entries[0].image);
            news2.Load(entries[1].image);
            txtNews1.Text = entries[0].title;
            txtNews2.Text = entries[1].title;
            txtInfoNews1.Text = entries[0].body;
            txtInfoNews2.Text = entries[1].body;
            txtSeverMsg.Text = rootStatus.message;
            txtVersion.Text = rootStatus.version;
        }


    }
}
