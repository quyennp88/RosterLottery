namespace ConGaTrongLottery.App
{
    partial class ProfileForm
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
            groupBox1 = new GroupBox();
            lblBirthDate = new Label();
            label5 = new Label();
            lbPhone = new Label();
            label3 = new Label();
            lbName = new Label();
            label1 = new Label();
            btnClose = new Button();
            groupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(lblBirthDate);
            groupBox1.Controls.Add(label5);
            groupBox1.Controls.Add(lbPhone);
            groupBox1.Controls.Add(label3);
            groupBox1.Controls.Add(lbName);
            groupBox1.Controls.Add(label1);
            groupBox1.Location = new Point(12, 23);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(676, 170);
            groupBox1.TabIndex = 0;
            groupBox1.TabStop = false;
            groupBox1.Text = "Thông Tin Cá Nhân";
            // 
            // lblBirthDate
            // 
            lblBirthDate.AutoSize = true;
            lblBirthDate.Location = new Point(117, 78);
            lblBirthDate.Name = "lblBirthDate";
            lblBirthDate.Size = new Size(38, 15);
            lblBirthDate.TabIndex = 5;
            lblBirthDate.Text = "label2";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(26, 78);
            label5.Name = "label5";
            label5.Size = new Size(60, 15);
            label5.TabIndex = 4;
            label5.Text = "Ngày sinh";
            // 
            // lbPhone
            // 
            lbPhone.AutoSize = true;
            lbPhone.Location = new Point(117, 116);
            lbPhone.Name = "lbPhone";
            lbPhone.Size = new Size(38, 15);
            lbPhone.TabIndex = 3;
            lbPhone.Text = "label2";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(26, 116);
            label3.Name = "label3";
            label3.Size = new Size(76, 15);
            label3.TabIndex = 2;
            label3.Text = "Số điện thoại";
            // 
            // lbName
            // 
            lbName.AutoSize = true;
            lbName.Location = new Point(117, 38);
            lbName.Name = "lbName";
            lbName.Size = new Size(38, 15);
            lbName.TabIndex = 1;
            lbName.Text = "label2";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(26, 38);
            label1.Name = "label1";
            label1.Size = new Size(43, 15);
            label1.TabIndex = 0;
            label1.Text = "Họ tên";
            // 
            // btnClose
            // 
            btnClose.Location = new Point(613, 214);
            btnClose.Name = "btnClose";
            btnClose.Size = new Size(75, 23);
            btnClose.TabIndex = 1;
            btnClose.Text = "Đóng";
            btnClose.UseVisualStyleBackColor = true;
            btnClose.Click += btnClose_Click;
            // 
            // ProfileForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(709, 258);
            Controls.Add(btnClose);
            Controls.Add(groupBox1);
            Name = "ProfileForm";
            Text = "ProfileForm";
            Shown += ProfileForm_Shown;
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private GroupBox groupBox1;
        private Label lblBirthDate;
        private Label label5;
        private Label lbPhone;
        private Label label3;
        private Label lbName;
        private Label label1;
        private Button btnClose;
    }
}