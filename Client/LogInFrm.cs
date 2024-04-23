using Client.Services;
using ConGaTrongLottery.App;
using RoosterLottery.Client.Model;

namespace RoosterLottery.Client;

public partial class LogInFrm : Form
{
    //private RegistrationForm _registrationForm { get; set; }
    //private DashboardForm _dashboardForm { get; set; }
    //private AppDbContext _appDbContext { get; set; }
    private UserService _userService {  get; set; }
    private LotteryService _loterryService { get; set; }
    public LogInFrm()
    {
        InitializeComponent();
        _userService = new UserService();
        _loterryService = new LotteryService();
    }

    private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
    {
        RegistrationForm regis = new RegistrationForm();
        regis.ShowDialog();
    }

    private async void btbLogIn_Click(object sender, EventArgs e)
    {
        User user = new User() { Phone = this.txtUserName.Text };
        var result = await _userService.Login(user);
        if (result.Id != null)
        {
            LoginInfo.User = result;
            LoginInfo.OpenLottery = await _loterryService.GetOpenLottery();
            LoginInfo.Phone = result.Phone;
            LoginInfo.Name = result.Name;
            LoginInfo.Birthday = result.Birthday;

            MessageBox.Show("Đăng nhập thành công!");
            DashboardForm dashboardForm = new DashboardForm();
            dashboardForm.ShowDialog();

        }
        else
        {
            MessageBox.Show("Đăng nhập thất bại. Vui lòng xem lại thông tin đăng nhập! ");
        }

    }
}
