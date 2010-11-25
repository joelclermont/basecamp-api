using System;
using System.Configuration;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Basecamp;

namespace SampleApp
{
    public partial class SampleCamp : Form
    {
        public SampleCamp()
        {
            InitializeComponent();
        }

        private void btnTest_Click(object sender, EventArgs e)
        {
            string url = ConfigurationSettings.AppSettings["BasecampURL"];
            string apiToken = ConfigurationSettings.AppSettings["APIToken"];

            BasecampClient bc = new BasecampClient(url, apiToken);
            txtResults.Text = bc.TestConnection();
        }
    }
}
