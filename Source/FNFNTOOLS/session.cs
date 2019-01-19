using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Timers;
using Newtonsoft.Json;
using Flurl;
using Flurl.Http;
using System.Drawing.Imaging;



namespace FNFNTOOLS
{
    public partial class session : Form
    {
        //Global objects
        public static Rootobject root = new Rootobject();
        Error error = new Error();
        public static Totals globalInitial ;
        public static Stats individualInitial ;

        //Global vars for time control
        private System.Windows.Forms.Timer secondsTimer;
        private DateTime startTimer = DateTime.MinValue;
        private TimeSpan currentTime = TimeSpan.Zero;
        private TimeSpan totalTime = TimeSpan.Zero;
        private System.Timers.Timer timer = new System.Timers.Timer(60000);
        private bool runningTime = false;

       


        public session()
        {
            InitializeComponent();
            secondsTimer = new System.Windows.Forms.Timer();
            secondsTimer.Interval = 1000;
            secondsTimer.Tick += new EventHandler(secondsTimer_tick); 
        }

        //?Check for illegal thread need why?
        private void session_Load(object sender, EventArgs e)
        {
            CheckForIllegalCrossThreadCalls = false;
            btnStop.Enabled = false;
        }

        //Handler event for time
        void secondsTimer_tick(object sender, EventArgs e)
        {
            var timeSinceStartTime = DateTime.Now - startTimer;
            timeSinceStartTime = new TimeSpan(timeSinceStartTime.Hours,
                                              timeSinceStartTime.Minutes,
                                              timeSinceStartTime.Seconds);
            currentTime = timeSinceStartTime + totalTime;
            //totalTimeDisplay.Text = currentTime.ToString();
            totalTimeDisplay.Text = timeSinceStartTime.ToString();
         

        }

        //Load Uid for user
        public async Task<string> LoadUid(string username)
        {
            Rootouser user = new Rootouser();
            string url = "https://fortnite-public-api.theapinetwork.com/prod09/users/id?username=" + username;
            string id = await url.GetStringAsync();
            user = JsonConvert.DeserializeObject<Rootouser>(id);
            return user.uid;

        }

        //Load initial stats 
        public async Task LoadInitial(string username, string platform)
        {
            string uid = await LoadUid(username);
            string url = "https://fortnite-public-api.theapinetwork.com/prod09/users/public/br_stats?user_id=" + uid + "&platform=" + platform;
            string text = await url.GetStringAsync();
            root = JsonConvert.DeserializeObject<Rootobject>(text);
            globalInitial = root.totals;
            individualInitial = root.stats;
            
        }

        //Load error json
        public async Task LoadError(string username, string platform)
        {
            string uid = await LoadUid(username);
            string url = "https://fortnite-public-api.theapinetwork.com/prod09/users/public/br_stats?user_id=" + uid + "&platform=" + platform;
            string text = await url.GetStringAsync();
            error = JsonConvert.DeserializeObject<Error>(text);
        }

        //Load while session started
            public async Task<Rootobject> LoadWhileSession(string username, string platform)
        {
            //Using FortniteAPI
            string uid = await LoadUid(username);
            string url = "https://fortnite-public-api.theapinetwork.com/prod09/users/public/br_stats?user_id=" + uid + "&platform=" + platform;
            string text = await url.GetStringAsync();
            root = JsonConvert.DeserializeObject<Rootobject>(text);
            return root;

        }

        private async void btnStart_Click(object sender, EventArgs e)
        {
            //Handling Errors
            if (string.IsNullOrEmpty(txtUname.Text))
            {
                string messageError = "Error: Please enter an username";
                MessageBoxButtons buttonsError = MessageBoxButtons.OK;
                DialogResult resultError;
                resultError = MessageBox.Show(messageError, "Error", buttonsError, MessageBoxIcon.Error);
            }
            else
            {
                string username = txtUname.Text;
                await LoadError(username, "pc");

                if (error.error == true)
                {
                    string message = "Error: " + error.numericErrorCode.ToString() + " " + error.errorMessage;
                    MessageBoxButtons buttons = MessageBoxButtons.OK;
                    DialogResult result;
                    result = MessageBox.Show(message, "Error", buttons, MessageBoxIcon.Error);
                }
                else
                {
                    await LoadInitial(username, "pc");

                    timer.Elapsed += CompareStats;
                    timer.Enabled = true;

                    if (!runningTime)
                    {
                        startTimer = DateTime.Now;
                        totalTime = currentTime;
                        secondsTimer.Start();
                        runningTime = true;
                    }
                    else
                    {
                        secondsTimer.Stop();
                        runningTime = false;
                    }

                    btnStart.Enabled = false;
                    btnStop.Enabled = true;
                }
                
            }
            

        }

        public async void CompareStats(object source, ElapsedEventArgs e)
        {
            string username = txtUname.Text;
            Rootobject newdata = new Rootobject();
            newdata = await LoadWhileSession(username, "pc");
            Totals globalNew = newdata.totals;
            var newWins = globalNew.wins - globalInitial.wins;
            var newMatches = globalNew.matchesplayed - globalInitial.matchesplayed;
            var newKills = globalNew.kills - globalInitial.kills;
            float newKd;
            float newWinr;

            if (newKills == 0)
            {
                newKd = 0;
            }
            else if ((newMatches - newWins) == 0)
            {
                newKd = newKills;
            }
            else
            {
                newKd =  newKills / (newMatches - newWins);
            }

            if (newMatches == 0)
            {
                newWinr = newWins * 100;
            }
            else
            {
                newWinr = (newWins * 100) / newMatches;
            }
            txtKills.Text = newKills.ToString();
            txtKD.Text = newKd.ToString();
            txtWr.Text = (newWinr).ToString() + "%";
            txtWins.Text = newWins.ToString();
            txtMatches.Text = newMatches.ToString();
        }

        private void btnStop_Click(object sender, EventArgs e)
        {
            secondsTimer.Stop();
            timer.Enabled = false;
            btnStop.Enabled = false;
            btnStart.Enabled = true;
            runningTime = false;
        }
    }
}
