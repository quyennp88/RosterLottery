using Client.Services;
using RoosterLottery.Client.Model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ConGaTrongLottery.App
{
    public partial class RegistrationForm : Form
    {
        private UserService _userService { get; set; }
        public RegistrationForm()
        {
            InitializeComponent();
            _userService = new UserService();
        }

        private async void btnRegistration_Click(object sender, EventArgs e)
        {
            var user = new User();
            user.Name = txtName.Text;
            user.Phone = tbxPhone.Text;
            user.Birthday = dtBirthdate.Value;
            try {
                
                var result = await _userService.Register(user);
                MessageBox.Show("Đăng ký thành công!");
                this.Close();
            }
            catch {
                MessageBox.Show("Đăng ký thất bại.Xin vui lòng kiểm tra lại thông tin!");
            }
            
        }

    }
}
