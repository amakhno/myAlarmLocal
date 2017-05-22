using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace fLocalAlarm
{
    public partial class TAuth : Form
    {
        public TAuth()
        {
            InitializeComponent();
            keyTextBox.Text = Properties.Settings.Default.apiKey;
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            System.Diagnostics.Process.Start("https://vsu-my.sharepoint.com/personal/makhno_office365_vsu_ru/_layouts/15/guestaccess.aspx?docid=06ca6af3db3a1428285caaf883f7cfa76&authkey=AaOPhW-jB2UN85vTdapp8yM");
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Properties.Settings.Default.isTelgram = false;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Properties.Settings.Default.isTelgram = false;
            this.Close();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Tracker.tracker.messager = new TelegramMessager(keyTextBox.Text);
            Properties.Settings.Default.apiKey = keyTextBox.Text;
            Properties.Settings.Default.isTelgram = true;
            this.Close();
        }
    }
}
