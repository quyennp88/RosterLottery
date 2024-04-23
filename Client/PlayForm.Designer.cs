namespace ConGaTrongLottery.App
{
    partial class PlayForm
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
            cbx_Number = new ComboBox();
            label1 = new Label();
            btbFinish = new Button();
            SuspendLayout();
            // 
            // cbx_Number
            // 
            cbx_Number.FormattingEnabled = true;
            cbx_Number.Items.AddRange(new object[] { "0", "1", "2", "3", "4", "5", "6", "7", "8", "9" });
            cbx_Number.Location = new Point(178, 58);
            cbx_Number.Name = "cbx_Number";
            cbx_Number.Size = new Size(121, 23);
            cbx_Number.TabIndex = 0;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(79, 58);
            label1.Name = "label1";
            label1.Size = new Size(72, 15);
            label1.TabIndex = 1;
            label1.Text = "Số Đặt Cược";
            // 
            // btbFinish
            // 
            btbFinish.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            btbFinish.Location = new Point(129, 114);
            btbFinish.Name = "btbFinish";
            btbFinish.Size = new Size(130, 23);
            btbFinish.TabIndex = 2;
            btbFinish.Text = "Hoàn Thành";
            btbFinish.UseVisualStyleBackColor = true;
            btbFinish.Click += btbFinish_Click;
            // 
            // PlayForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(425, 182);
            Controls.Add(btbFinish);
            Controls.Add(label1);
            Controls.Add(cbx_Number);
            Name = "PlayForm";
            Text = "PlayForm";
            Load += PlayForm_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ComboBox cbx_Number;
        private Label label1;
        private Button btbFinish;
    }
}