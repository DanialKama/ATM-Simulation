namespace Automated_Teller_Machine
{
    partial class FormMenu
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormMenu));
            this.exitBtn = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.minimizeBtn = new System.Windows.Forms.Button();
            this.withdrawMoneyBtn = new System.Windows.Forms.Button();
            this.acctBalanceBtn = new System.Windows.Forms.Button();
            this.exitCardBtn = new System.Windows.Forms.Button();
            this.otherServicesBtn = new System.Windows.Forms.Button();
            this.moneyTransferBtn = new System.Windows.Forms.Button();
            this.changePwdBtn = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // exitBtn
            // 
            this.exitBtn.BackColor = System.Drawing.Color.SteelBlue;
            this.exitBtn.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("exitBtn.BackgroundImage")));
            this.exitBtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.exitBtn.FlatAppearance.BorderSize = 0;
            this.exitBtn.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.exitBtn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Tomato;
            this.exitBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.exitBtn.ForeColor = System.Drawing.Color.Transparent;
            this.exitBtn.Location = new System.Drawing.Point(770, 0);
            this.exitBtn.Name = "exitBtn";
            this.exitBtn.Size = new System.Drawing.Size(30, 30);
            this.exitBtn.TabIndex = 7;
            this.exitBtn.UseVisualStyleBackColor = false;
            this.exitBtn.Click += new System.EventHandler(this.exitBtn_Click);
            // 
            // panel1
            // 
            this.panel1.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.panel1.BackColor = System.Drawing.Color.SteelBlue;
            this.panel1.Controls.Add(this.minimizeBtn);
            this.panel1.ForeColor = System.Drawing.Color.Transparent;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(800, 30);
            this.panel1.TabIndex = 6;
            this.panel1.MouseDown += new System.Windows.Forms.MouseEventHandler(this.panel1_MouseDown);
            this.panel1.MouseMove += new System.Windows.Forms.MouseEventHandler(this.panel1_MouseMove);
            this.panel1.MouseUp += new System.Windows.Forms.MouseEventHandler(this.panel1_MouseUp);
            // 
            // minimizeBtn
            // 
            this.minimizeBtn.BackColor = System.Drawing.Color.SteelBlue;
            this.minimizeBtn.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("minimizeBtn.BackgroundImage")));
            this.minimizeBtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.minimizeBtn.FlatAppearance.BorderSize = 0;
            this.minimizeBtn.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.minimizeBtn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.LightSkyBlue;
            this.minimizeBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.minimizeBtn.ForeColor = System.Drawing.Color.Transparent;
            this.minimizeBtn.Location = new System.Drawing.Point(734, 0);
            this.minimizeBtn.Name = "minimizeBtn";
            this.minimizeBtn.Size = new System.Drawing.Size(30, 30);
            this.minimizeBtn.TabIndex = 0;
            this.minimizeBtn.UseVisualStyleBackColor = false;
            this.minimizeBtn.Click += new System.EventHandler(this.minimizeBtn_Click);
            // 
            // withdrawMoneyBtn
            // 
            this.withdrawMoneyBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.withdrawMoneyBtn.Location = new System.Drawing.Point(10, 150);
            this.withdrawMoneyBtn.Margin = new System.Windows.Forms.Padding(1);
            this.withdrawMoneyBtn.Name = "withdrawMoneyBtn";
            this.withdrawMoneyBtn.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.withdrawMoneyBtn.Size = new System.Drawing.Size(130, 60);
            this.withdrawMoneyBtn.TabIndex = 1;
            this.withdrawMoneyBtn.Text = "برداشت وجه";
            this.withdrawMoneyBtn.UseVisualStyleBackColor = true;
            this.withdrawMoneyBtn.Click += new System.EventHandler(this.withdrawMoneyBtn_Click);
            // 
            // acctBalanceBtn
            // 
            this.acctBalanceBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.acctBalanceBtn.Location = new System.Drawing.Point(660, 150);
            this.acctBalanceBtn.Margin = new System.Windows.Forms.Padding(1);
            this.acctBalanceBtn.Name = "acctBalanceBtn";
            this.acctBalanceBtn.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.acctBalanceBtn.Size = new System.Drawing.Size(130, 60);
            this.acctBalanceBtn.TabIndex = 0;
            this.acctBalanceBtn.Text = "موجودی حساب";
            this.acctBalanceBtn.UseVisualStyleBackColor = true;
            this.acctBalanceBtn.Click += new System.EventHandler(this.acctBalanceBtn_Click);
            // 
            // exitCardBtn
            // 
            this.exitCardBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold);
            this.exitCardBtn.Location = new System.Drawing.Point(10, 390);
            this.exitCardBtn.Margin = new System.Windows.Forms.Padding(1);
            this.exitCardBtn.Name = "exitCardBtn";
            this.exitCardBtn.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.exitCardBtn.Size = new System.Drawing.Size(130, 60);
            this.exitCardBtn.TabIndex = 5;
            this.exitCardBtn.Text = "خروج";
            this.exitCardBtn.UseVisualStyleBackColor = true;
            this.exitCardBtn.Click += new System.EventHandler(this.exitCardBtn_Click);
            // 
            // otherServicesBtn
            // 
            this.otherServicesBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold);
            this.otherServicesBtn.Location = new System.Drawing.Point(660, 390);
            this.otherServicesBtn.Margin = new System.Windows.Forms.Padding(1);
            this.otherServicesBtn.Name = "otherServicesBtn";
            this.otherServicesBtn.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.otherServicesBtn.Size = new System.Drawing.Size(130, 60);
            this.otherServicesBtn.TabIndex = 4;
            this.otherServicesBtn.Text = "پرداخت قبوض";
            this.otherServicesBtn.UseVisualStyleBackColor = true;
            this.otherServicesBtn.Click += new System.EventHandler(this.otherServicesBtn_Click);
            // 
            // moneyTransferBtn
            // 
            this.moneyTransferBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold);
            this.moneyTransferBtn.Location = new System.Drawing.Point(660, 270);
            this.moneyTransferBtn.Margin = new System.Windows.Forms.Padding(1);
            this.moneyTransferBtn.Name = "moneyTransferBtn";
            this.moneyTransferBtn.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.moneyTransferBtn.Size = new System.Drawing.Size(130, 60);
            this.moneyTransferBtn.TabIndex = 2;
            this.moneyTransferBtn.Text = "انتقال وجه";
            this.moneyTransferBtn.UseVisualStyleBackColor = true;
            this.moneyTransferBtn.Click += new System.EventHandler(this.moneyTransferBtn_Click);
            // 
            // changePwdBtn
            // 
            this.changePwdBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold);
            this.changePwdBtn.Location = new System.Drawing.Point(10, 270);
            this.changePwdBtn.Margin = new System.Windows.Forms.Padding(1);
            this.changePwdBtn.Name = "changePwdBtn";
            this.changePwdBtn.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.changePwdBtn.Size = new System.Drawing.Size(130, 60);
            this.changePwdBtn.TabIndex = 3;
            this.changePwdBtn.Text = "تغییر رمز";
            this.changePwdBtn.UseVisualStyleBackColor = true;
            this.changePwdBtn.Click += new System.EventHandler(this.changePwdBtn_Click);
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label1.BackColor = System.Drawing.SystemColors.Info;
            this.label1.Cursor = System.Windows.Forms.Cursors.WaitCursor;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.label1.Location = new System.Drawing.Point(310, 85);
            this.label1.Margin = new System.Windows.Forms.Padding(1, 0, 1, 0);
            this.label1.Name = "label1";
            this.label1.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.label1.Size = new System.Drawing.Size(181, 42);
            this.label1.TabIndex = 8;
            this.label1.Text = "انتخاب نوع خدمات";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // FormMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(96F, 96F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.BackgroundImage = global::Automated_Teller_Machine.Properties.Resources.iconfinder_5_2693823;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.ClientSize = new System.Drawing.Size(800, 600);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.changePwdBtn);
            this.Controls.Add(this.moneyTransferBtn);
            this.Controls.Add(this.otherServicesBtn);
            this.Controls.Add(this.exitCardBtn);
            this.Controls.Add(this.acctBalanceBtn);
            this.Controls.Add(this.withdrawMoneyBtn);
            this.Controls.Add(this.exitBtn);
            this.Controls.Add(this.panel1);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "FormMenu";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ATM";
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button exitBtn;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button withdrawMoneyBtn;
        private System.Windows.Forms.Button acctBalanceBtn;
        private System.Windows.Forms.Button exitCardBtn;
        private System.Windows.Forms.Button otherServicesBtn;
        private System.Windows.Forms.Button moneyTransferBtn;
        private System.Windows.Forms.Button changePwdBtn;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button minimizeBtn;
    }
}