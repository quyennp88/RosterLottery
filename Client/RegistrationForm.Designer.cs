namespace ConGaTrongLottery.App
{
    partial class RegistrationForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            txtName = new TextBox();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            dtBirthdate = new DateTimePicker();
            label4 = new Label();
            tbxPhone = new TextBox();
            btnRegistration = new Button();
            SuspendLayout();
            // 
            // txtName
            // 
            txtName.Location = new Point(200, 79);
            txtName.Name = "txtName";
            txtName.Size = new Size(530, 23);
            txtName.TabIndex = 0;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(27, 82);
            label1.Name = "label1";
            label1.Size = new Size(43, 15);
            label1.TabIndex = 1;
            label1.Text = "Họ tên";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 20F);
            label2.Location = new Point(289, 9);
            label2.Name = "label2";
            label2.Size = new Size(242, 37);
            label2.TabIndex = 2;
            label2.Text = "Thông Tin Đăng Ký";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(27, 161);
            label3.Name = "label3";
            label3.Size = new Size(121, 15);
            label3.TabIndex = 3;
            label3.Text = "Ngày tháng năm sinh";
            // 
            // dtBirthdate
            // 
            dtBirthdate.Location = new Point(200, 161);
            dtBirthdate.Name = "dtBirthdate";
            dtBirthdate.Size = new Size(530, 23);
            dtBirthdate.TabIndex = 4;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(27, 246);
            label4.Name = "label4";
            label4.Size = new Size(76, 15);
            label4.TabIndex = 5;
            label4.Text = "Số điện thoại";
            // 
            // tbxPhone
            // 
            tbxPhone.Location = new Point(200, 238);
            tbxPhone.Name = "tbxPhone";
            tbxPhone.Size = new Size(530, 23);
            tbxPhone.TabIndex = 6;
            // 
            // btnRegistration
            // 
            btnRegistration.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            btnRegistration.Location = new Point(328, 301);
            btnRegistration.Name = "btnRegistration";
            btnRegistration.Size = new Size(130, 23);
            btnRegistration.TabIndex = 7;
            btnRegistration.Text = "Đăng Ký";
            btnRegistration.UseVisualStyleBackColor = true;
            btnRegistration.Click += btnRegistration_Click;
            // 
            // RegistrationForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(btnRegistration);
            Controls.Add(tbxPhone);
            Controls.Add(label4);
            Controls.Add(dtBirthdate);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(txtName);
            Name = "RegistrationForm";
            Text = "RegistrationForm";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txtName;
        private Label label1;
        private Label label2;
        private Label label3;
        private DateTimePicker dtBirthdate;
        private Label label4;
        private TextBox tbxPhone;
        private Button btnRegistration;
    }
}