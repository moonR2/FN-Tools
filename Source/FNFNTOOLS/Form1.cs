using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FNFNTOOLS
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            
        }

        public Task InitializeAsync()
        {
            //use this to test the exception handling
            //throw new NotImplementedException();
            return Task.Delay(TimeSpan.FromSeconds(5));
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            this.MaximizeBox = false;
            if (ParentPanel.Controls.Count > 0)
            {
                ParentPanel.Controls.RemoveAt(0);
            }
            news myForm = new news();
            myForm.TopLevel = false;
            myForm.FormBorderStyle = FormBorderStyle.None;
            myForm.Dock = DockStyle.Fill;
            ParentPanel.Controls.Add(myForm);
            ParentPanel.Tag = myForm;
            myForm.Show();
        }

        private void SideMenu_Paint(object sender, PaintEventArgs e)
        {

        }

        private void openForm (Form form)
        {

        }

        private void btnStats_Click_1(object sender, EventArgs e)
        {
            if (ParentPanel.Controls.Count > 0)
            {
                ParentPanel.Controls.RemoveAt(0);
            }
            Estadisticas myForm = new Estadisticas();
            myForm.TopLevel = false;
            myForm.FormBorderStyle = FormBorderStyle.None;
            myForm.Dock = DockStyle.Fill;
            ParentPanel.Controls.Add(myForm);
            ParentPanel.Tag = myForm;
            myForm.Show();
        }

        private void btnResolution_Click_1(object sender, EventArgs e)
        {
            if (ParentPanel.Controls.Count > 0)
            {
                ParentPanel.Controls.RemoveAt(0);
            }
            Resolution myForm = new Resolution();
            myForm.TopLevel = false;
            myForm.FormBorderStyle = FormBorderStyle.None;
            myForm.Dock = DockStyle.Fill;
            ParentPanel.Controls.Add(myForm);
            ParentPanel.Tag = myForm;
            myForm.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (ParentPanel.Controls.Count > 0)
            {
                ParentPanel.Controls.RemoveAt(0);
            }
            session myForm = new session();
            myForm.TopLevel = false;
            myForm.FormBorderStyle = FormBorderStyle.None;
            myForm.Dock = DockStyle.Fill;
            ParentPanel.Controls.Add(myForm);
            ParentPanel.Tag = myForm;
            myForm.Show();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            if (ParentPanel.Controls.Count > 0)
            {
                ParentPanel.Controls.RemoveAt(0);
            }
            news myForm = new news();
            myForm.TopLevel = false;
            myForm.FormBorderStyle = FormBorderStyle.None;
            myForm.Dock = DockStyle.Fill;
            ParentPanel.Controls.Add(myForm);
            ParentPanel.Tag = myForm;
            myForm.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (ParentPanel.Controls.Count > 0)
            {
                ParentPanel.Controls.RemoveAt(0);
            }
            support myForm = new support();
            myForm.TopLevel = false;
            myForm.FormBorderStyle = FormBorderStyle.None;
            myForm.Dock = DockStyle.Fill;
            ParentPanel.Controls.Add(myForm);
            ParentPanel.Tag = myForm;
            myForm.Show();
        }

        private void btnCfg_Click(object sender, EventArgs e)
        {
            if (ParentPanel.Controls.Count > 0)
            {
                ParentPanel.Controls.RemoveAt(0);
            }
            cfg myForm = new cfg();
            myForm.TopLevel = false;
            myForm.FormBorderStyle = FormBorderStyle.None;
            myForm.Dock = DockStyle.Fill;
            ParentPanel.Controls.Add(myForm);
            ParentPanel.Tag = myForm;
            myForm.Show();
        }
    }
}
