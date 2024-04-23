namespace RoosterLottery.Client;

partial class LogInFrm
{
    /// <summary>
    ///  Required designer variable.
    /// </summary>
    private System.ComponentModel.IContainer components = null;

    /// <summary>
    ///  Clean up any resources being used.
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
    ///  Required method for Designer support - do not modify
    ///  the contents of this method with the code editor.
    /// </summary>
    private void InitializeComponent()
    {
        txtUserName = new TextBox();
        d = new Label();
        btbLogIn = new Button();
        linkLabel1 = new LinkLabel();
        SuspendLayout();
        // 
        // txtUserName
        // 
        txtUserName.Location = new Point(256, 66);
        txtUserName.Name = "txtUserName";
        txtUserName.Size = new Size(293, 23);
        txtUserName.TabIndex = 0;
        // 
        // d
        // 
        d.AutoSize = true;
        d.Location = new Point(67, 66);
        d.Name = "d";
        d.Size = new Size(142, 15);
        d.TabIndex = 1;
        d.Text = "Số Điện Thoại Đăng Nhập";
        // 
        // btbLogIn
        // 
        btbLogIn.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
        btbLogIn.Location = new Point(306, 123);
        btbLogIn.Name = "btbLogIn";
        btbLogIn.Size = new Size(128, 23);
        btbLogIn.TabIndex = 4;
        btbLogIn.Text = "Đăng Nhập";
        btbLogIn.UseVisualStyleBackColor = true;
        btbLogIn.Click += btbLogIn_Click;
        // 
        // linkLabel1
        // 
        linkLabel1.AutoSize = true;
        linkLabel1.Location = new Point(67, 158);
        linkLabel1.Name = "linkLabel1";
        linkLabel1.Size = new Size(50, 15);
        linkLabel1.TabIndex = 5;
        linkLabel1.TabStop = true;
        linkLabel1.Text = "Đăng Ký";
        linkLabel1.LinkClicked += linkLabel1_LinkClicked;
        // 
        // LogInFrm
        // 
        AutoScaleDimensions = new SizeF(7F, 15F);
        AutoScaleMode = AutoScaleMode.Font;
        ClientSize = new Size(765, 223);
        Controls.Add(linkLabel1);
        Controls.Add(btbLogIn);
        Controls.Add(d);
        Controls.Add(txtUserName);
        Name = "LogInFrm";
        Text = "Form1";
        ResumeLayout(false);
        PerformLayout();
    }

    #endregion

    private TextBox txtUserName;
    private Label d;
    private Button btbLogIn;
    private LinkLabel linkLabel1;
}
