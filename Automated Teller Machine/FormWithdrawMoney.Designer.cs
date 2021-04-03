namespace Automated_Teller_Machine
{
    partial class FormWithdrawMoney
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormWithdrawMoney));
            this.minimizeBtn = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.backBtn = new System.Windows.Forms.Button();
            this.textBoxMoneyAmount = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.button50 = new System.Windows.Forms.Button();
            this.button30 = new System.Windows.Forms.Button();
            this.button100 = new System.Windows.Forms.Button();
            this.button200 = new System.Windows.Forms.Button();
            this.button10 = new System.Windows.Forms.Button();
            this.button20 = new System.Windows.Forms.Button();
            this.confirmBtn = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
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
            this.minimizeBtn.Location = new System.Drawing.Point(770, 0);
            this.minimizeBtn.Name = "minimizeBtn";
            this.minimizeBtn.Size = new System.Drawing.Size(30, 30);
            this.minimizeBtn.TabIndex = 0;
            this.minimizeBtn.UseVisualStyleBackColor = false;
            this.minimizeBtn.Click += new System.EventHandler(this.minimizeBtn_Click);
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
            this.panel1.TabIndex = 9;
            this.panel1.MouseDown += new System.Windows.Forms.MouseEventHandler(this.panel1_MouseDown);
            this.panel1.MouseMove += new System.Windows.Forms.MouseEventHandler(this.panel1_MouseMove);
            this.panel1.MouseUp += new System.Windows.Forms.MouseEventHandler(this.panel1_MouseUp);
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
            this.label1.TabIndex = 10;
            this.label1.Text = "برداشت وجه";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // backBtn
            // 
            this.backBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold);
            this.backBtn.Location = new System.Drawing.Point(10, 530);
            this.backBtn.Margin = new System.Windows.Forms.Padding(1);
            this.backBtn.Name = "backBtn";
            this.backBtn.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.backBtn.Size = new System.Drawing.Size(130, 60);
            this.backBtn.TabIndex = 8;
            this.backBtn.Text = "بازگشت";
            this.backBtn.UseVisualStyleBackColor = true;
            this.backBtn.Click += new System.EventHandler(this.backBtn_Click);
            // 
            // textBoxMoneyAmount
            // 
            this.textBoxMoneyAmount.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.textBoxMoneyAmount.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.textBoxMoneyAmount.Location = new System.Drawing.Point(230, 285);
            this.textBoxMoneyAmount.Margin = new System.Windows.Forms.Padding(1);
            this.textBoxMoneyAmount.MaxLength = 7;
            this.textBoxMoneyAmount.Name = "textBoxMoneyAmount";
            this.textBoxMoneyAmount.Size = new System.Drawing.Size(341, 31);
            this.textBoxMoneyAmount.TabIndex = 0;
            this.textBoxMoneyAmount.Tag = "";
            this.textBoxMoneyAmount.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.textBoxMoneyAmount.TextChanged += new System.EventHandler(this.textBoxMoneyAmount_TextChanged);
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label2.BackColor = System.Drawing.SystemColors.Info;
            this.label2.Cursor = System.Windows.Forms.Cursors.WaitCursor;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.label2.Location = new System.Drawing.Point(225, 217);
            this.label2.Margin = new System.Windows.Forms.Padding(1, 0, 1, 0);
            this.label2.Name = "label2";
            this.label2.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.label2.Size = new System.Drawing.Size(350, 42);
            this.label2.TabIndex = 11;
            this.label2.Text = "مبلغ مورد نظر را انتخاب کنید یا مبلغ را وارد کنید. (ریال)";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // button50
            // 
            this.button50.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold);
            this.button50.Location = new System.Drawing.Point(10, 270);
            this.button50.Margin = new System.Windows.Forms.Padding(1);
            this.button50.Name = "button50";
            this.button50.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.button50.Size = new System.Drawing.Size(130, 60);
            this.button50.TabIndex = 5;
            this.button50.Text = "500,000";
            this.button50.UseVisualStyleBackColor = true;
            this.button50.Click += new System.EventHandler(this.button50_Click);
            // 
            // button30
            // 
            this.button30.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold);
            this.button30.Location = new System.Drawing.Point(660, 270);
            this.button30.Margin = new System.Windows.Forms.Padding(1);
            this.button30.Name = "button30";
            this.button30.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.button30.Size = new System.Drawing.Size(130, 60);
            this.button30.TabIndex = 4;
            this.button30.Text = "300,000";
            this.button30.UseVisualStyleBackColor = true;
            this.button30.Click += new System.EventHandler(this.button30_Click);
            // 
            // button100
            // 
            this.button100.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold);
            this.button100.Location = new System.Drawing.Point(660, 390);
            this.button100.Margin = new System.Windows.Forms.Padding(1);
            this.button100.Name = "button100";
            this.button100.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.button100.Size = new System.Drawing.Size(130, 60);
            this.button100.TabIndex = 6;
            this.button100.Text = "1,000,000";
            this.button100.UseVisualStyleBackColor = true;
            this.button100.Click += new System.EventHandler(this.button100_Click);
            // 
            // button200
            // 
            this.button200.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold);
            this.button200.Location = new System.Drawing.Point(10, 390);
            this.button200.Margin = new System.Windows.Forms.Padding(1);
            this.button200.Name = "button200";
            this.button200.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.button200.Size = new System.Drawing.Size(130, 60);
            this.button200.TabIndex = 7;
            this.button200.Text = "2,000,000";
            this.button200.UseVisualStyleBackColor = true;
            this.button200.Click += new System.EventHandler(this.button200_Click);
            // 
            // button10
            // 
            this.button10.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.button10.Location = new System.Drawing.Point(660, 150);
            this.button10.Margin = new System.Windows.Forms.Padding(1);
            this.button10.Name = "button10";
            this.button10.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.button10.Size = new System.Drawing.Size(130, 60);
            this.button10.TabIndex = 2;
            this.button10.Text = "100,000";
            this.button10.UseVisualStyleBackColor = true;
            this.button10.Click += new System.EventHandler(this.button10_Click);
            // 
            // button20
            // 
            this.button20.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.button20.Location = new System.Drawing.Point(10, 150);
            this.button20.Margin = new System.Windows.Forms.Padding(1);
            this.button20.Name = "button20";
            this.button20.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.button20.Size = new System.Drawing.Size(130, 60);
            this.button20.TabIndex = 3;
            this.button20.Text = "200,000";
            this.button20.UseVisualStyleBackColor = true;
            this.button20.Click += new System.EventHandler(this.button20_Click);
            // 
            // confirmBtn
            // 
            this.confirmBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold);
            this.confirmBtn.Location = new System.Drawing.Point(660, 530);
            this.confirmBtn.Margin = new System.Windows.Forms.Padding(1);
            this.confirmBtn.Name = "confirmBtn";
            this.confirmBtn.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.confirmBtn.Size = new System.Drawing.Size(130, 60);
            this.confirmBtn.TabIndex = 1;
            this.confirmBtn.Text = "تایید";
            this.confirmBtn.UseVisualStyleBackColor = true;
            this.confirmBtn.Click += new System.EventHandler(this.confirmBtn_Click);
            // 
            // FormWithdrawMoney
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(96F, 96F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.BackgroundImage = global::Automated_Teller_Machine.Properties.Resources.iconfinder_5_2693823;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.ClientSize = new System.Drawing.Size(800, 600);
            this.Controls.Add(this.confirmBtn);
            this.Controls.Add(this.button50);
            this.Controls.Add(this.button30);
            this.Controls.Add(this.button100);
            this.Controls.Add(this.button200);
            this.Controls.Add(this.button10);
            this.Controls.Add(this.button20);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.textBoxMoneyAmount);
            this.Controls.Add(this.backBtn);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.panel1);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "FormWithdrawMoney";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ATM";
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button minimizeBtn;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button backBtn;
        private System.Windows.Forms.TextBox textBoxMoneyAmount;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button button50;
        private System.Windows.Forms.Button button30;
        private System.Windows.Forms.Button button100;
        private System.Windows.Forms.Button button200;
        private System.Windows.Forms.Button button10;
        private System.Windows.Forms.Button button20;
        private System.Windows.Forms.Button confirmBtn;
    }
}