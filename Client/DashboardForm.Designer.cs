namespace ConGaTrongLottery.App
{
    partial class DashboardForm
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
            btnPlay = new Button();
            label1 = new Label();
            groupBox2 = new GroupBox();
            girdHistory = new DataGridView();
            button1 = new Button();
            btnShowProfileDown = new Button();
            btnShowProfile = new Button();
            groupBox1.SuspendLayout();
            groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)girdHistory).BeginInit();
            SuspendLayout();
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(btnPlay);
            groupBox1.Controls.Add(label1);
            groupBox1.Location = new Point(18, 60);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(776, 185);
            groupBox1.TabIndex = 0;
            groupBox1.TabStop = false;
            groupBox1.Text = "Đặt cược";
            // 
            // btnPlay
            // 
            btnPlay.Font = new Font("Segoe UI", 15F);
            btnPlay.Location = new Point(221, 69);
            btnPlay.Name = "btnPlay";
            btnPlay.Size = new Size(230, 55);
            btnPlay.TabIndex = 1;
            btnPlay.Text = "Đặt Cược Ngay !";
            btnPlay.UseVisualStyleBackColor = true;
            btnPlay.Click += btnPlay_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 10F);
            label1.Location = new Point(152, 31);
            label1.Name = "label1";
            label1.Size = new Size(504, 19);
            label1.TabIndex = 0;
            label1.Text = "Mời bạn nhấn nút Đặt Cược Ngay để tiến hành đặt cược cho lần xổ số tiếp theo. ";
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(girdHistory);
            groupBox2.Location = new Point(12, 262);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(776, 272);
            groupBox2.TabIndex = 1;
            groupBox2.TabStop = false;
            groupBox2.Text = "Nhật ký đặt cược";
            // 
            // girdHistory
            // 
            girdHistory.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            girdHistory.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
            girdHistory.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            girdHistory.Location = new Point(6, 22);
            girdHistory.Name = "girdHistory";
            girdHistory.Size = new Size(748, 228);
            girdHistory.TabIndex = 0;
            // 
            // button1
            // 
            button1.Location = new Point(713, 550);
            button1.Name = "button1";
            button1.Size = new Size(75, 23);
            button1.TabIndex = 2;
            button1.Text = "Thoát";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // btnShowProfileDown
            // 
            btnShowProfileDown.Location = new Point(12, 550);
            btnShowProfileDown.Name = "btnShowProfileDown";
            btnShowProfileDown.Size = new Size(163, 23);
            btnShowProfileDown.TabIndex = 3;
            btnShowProfileDown.Text = "Xem Thông Tin Cá Nhân";
            btnShowProfileDown.UseVisualStyleBackColor = true;
            btnShowProfileDown.Click += btnShowProfileDown_Click;
            // 
            // btnShowProfile
            // 
            btnShowProfile.Location = new Point(18, 21);
            btnShowProfile.Name = "btnShowProfile";
            btnShowProfile.Size = new Size(163, 23);
            btnShowProfile.TabIndex = 4;
            btnShowProfile.Text = "Xem Thông Tin Cá Nhân";
            btnShowProfile.UseVisualStyleBackColor = true;
            btnShowProfile.Click += btnShowProfile_Click;
            // 
            // DashboardForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(806, 585);
            Controls.Add(btnShowProfile);
            Controls.Add(btnShowProfileDown);
            Controls.Add(button1);
            Controls.Add(groupBox2);
            Controls.Add(groupBox1);
            Name = "DashboardForm";
            Text = "DashboardForm";
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)girdHistory).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private GroupBox groupBox1;
        private Label label1;
        private Button btnPlay;
        private GroupBox groupBox2;
        private DataGridView girdHistory;
        private Button button1;
        private Button btnShowProfileDown;
        private Button btnShowProfile;
    }
}