using Client.Models;
using Client.Services;
using RoosterLottery.Client.Model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ConGaTrongLottery.App
{
    public partial class DashboardForm : Form
    {
        private LotteryService _lotteryService { get; set; }
        public DashboardForm()
        {
            InitializeComponent();
            _lotteryService = new LotteryService();
            GetDataSource();
        }

        private void btnShowProfile_Click(object sender, EventArgs e)
        {
            showProfileForm();
        }

        private void btnShowProfileDown_Click(object sender, EventArgs e)
        {
            showProfileForm();
        }
        private void showProfileForm()
        {
            ProfileForm profileForm = new ProfileForm();
            profileForm.Show();
        }

        private void btnPlay_Click(object sender, EventArgs e)
        {
            PlayForm playForm = new PlayForm();
            playForm.Show();
        }

        private async void GetDataSource()
        {
            var result = await _lotteryService.GetHistoryLotteries(LoginInfo.User.Id);
            var historyDatasource = new List<LotteryHistoryViewModel>();
            var historyModel = new LotteryHistoryViewModel();
            if (result != null)
            {
                foreach (var item in result)
                {
                    historyModel.Hour = item.Lottery.Hour;
                    historyModel.Number = item.Lottery.LotteryNumber;
                    historyModel.Date = item.Lottery.LotteryDate.Date;
                    var status = "";
                    switch (item.Status)
                    {
                        case 0:
                            status = "Chờ sổ";
                            break;
                        case 1:
                            status = "Trúng";
                            break;
                        case 2:
                            status = "Sai";
                            break;
                    }
                    historyModel.Status = status;
                    historyDatasource.Add(historyModel);
                }
                this.girdHistory.DataSource = historyDatasource;

                girdHistory.Columns[0].HeaderText = "Mã số";
                girdHistory.Columns[1].HeaderText = "Ngày đặt cược";
                girdHistory.Columns[2].HeaderText = "Giờ đặt cược";
                girdHistory.Columns[3].HeaderText = "Số đặt cược";
                girdHistory.Columns[4].HeaderText = "Trạng thái";
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
