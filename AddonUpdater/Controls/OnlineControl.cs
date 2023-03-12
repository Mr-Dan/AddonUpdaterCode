using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AddonUpdater.Controls
{
    public partial class OnlineControl : UserControl
    {
        FormMainMenu form;
        public OnlineControl(bool isOnline, string realmName, int online, FormMainMenu form)
        {
            InitializeComponent();
            SetOnlineControl(isOnline, realmName, online);
            this.form = form;
        }

        public void SetOnlineControl(bool isOnline, string realmName, int online)
        {
            if (isOnline)
            {
                isOnlinePictureBox.BackgroundImage = Properties.Resources.online;
            }
            else
            {
                isOnlinePictureBox.BackgroundImage = Properties.Resources.ofline;
            }
            realmNameLabel.Text = realmName + "  " + online;
        }

        private void RealmNameLabel_MouseDown(object sender, MouseEventArgs e)
        {
            form.PanelTitleMove_MouseDown(sender, e);
        }

        private void IsOnlinePictureBox_MouseDown(object sender, MouseEventArgs e)
        {
            form.PanelTitleMove_MouseDown(sender, e);
        }

        private void OnlineControl_MouseDown(object sender, MouseEventArgs e)
        {
            form.PanelTitleMove_MouseDown(sender, e);
        }
    }
}
