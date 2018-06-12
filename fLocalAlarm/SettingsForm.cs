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
    public partial class SettingsForm : Form
    {
        public SettingsForm()
        {
            InitializeComponent();
            this.Visible = false;

            enemyAlarm.Checked = Properties.Settings.Default.enemyAlarm;
            neutAlarm.Checked = Properties.Settings.Default.neutAlarm;
            xBox.Value = Properties.Settings.Default.x;
            yBox.Value = Properties.Settings.Default.y;
            hBox.Value = Properties.Settings.Default.h;
            nameTextBox.Text = Properties.Settings.Default.pilotName;
            WarpX.Value = Properties.Settings.Default.warpX;
            WarpY.Value = Properties.Settings.Default.warpY;
            IsBackgroundCheckbox.Checked = Properties.Settings.Default.background;
            IsWarpCheckbox.Checked = Properties.Settings.Default.allign;

        }

        private void cancelButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void confirmButton_Click(object sender, EventArgs e)
        {
            Properties.Settings.Default.x = (int) xBox.Value;
            Properties.Settings.Default.y = (int) yBox.Value;
            Properties.Settings.Default.h = (int) hBox.Value;
            Properties.Settings.Default.pilotName = nameTextBox.Text;

            Properties.Settings.Default.enemyAlarm = enemyAlarm.Checked;
            Properties.Settings.Default.neutAlarm = neutAlarm.Checked;

            Properties.Settings.Default.warpX = (int) WarpX.Value;
            Properties.Settings.Default.warpY = (int) WarpY.Value;

            Properties.Settings.Default.background = IsBackgroundCheckbox.Checked;
            Properties.Settings.Default.allign = IsWarpCheckbox.Checked;

            Properties.Settings.Default.Save();
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            TAuth form = new TAuth();
            form.Show();            
        }
    }
}
