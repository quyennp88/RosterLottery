using Client.Services;
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
    public partial class PlayForm : Form
    {
        private LotteryService _lotteryService { get; set; }
        public PlayForm()
        {
            InitializeComponent();
            _lotteryService = new LotteryService();
            cbx_Number.DataSource = new List<int>{0, 1, 2, 3, 4, 5, 6, 7, 8, 9 };
        }

        private async void btbFinish_Click(object sender, EventArgs e)
        {
            var userLottery = new UserLottery();
            userLottery.UserId = LoginInfo.User.Id;
            userLottery.Number = (int)cbx_Number.SelectedValue;
            userLottery.Status = 0;
            userLottery.LotteryId = LoginInfo.OpenLottery.Id;

            var result = (bool)await _lotteryService.SubmitLottery(userLottery);
            if (result)
            {
                MessageBox.Show("Đặt cược thành công!");
                LoginInfo.Betting = new Lottery();
                LoginInfo.Betting.LotteryNumber = userLottery.Number;
                this.Close();
            }
            else
            {
                MessageBox.Show("Bạn đã đặt cược cho suất này rồi. Xin vui lòng không đặt lại!");
            }
        }

        private void PlayForm_Load(object sender, EventArgs e)
        {

        }
    }
}
