using RoosterLottery.Client.Model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ConGaTrongLottery.App
{
    public partial class ProfileForm : Form
    {
        public ProfileForm()
        {
            InitializeComponent();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        private void ShowProfile()
        {
            this.lbName.Text = LoginInfo.Name;
            this.lbPhone.Text = LoginInfo.Phone;
            this.lblBirthDate.Text = LoginInfo.Birthday.ToString();
        }

        private void ProfileForm_Shown(object sender, EventArgs e)
        {
            ShowProfile();
        }
    }
}
