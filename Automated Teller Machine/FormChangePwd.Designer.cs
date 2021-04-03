namespace Automated_Teller_Machine
{
    partial class FormChangePwd
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormChangePwd));
            this.minimizeBtn = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.cancelBtn = new System.Windows.Forms.Button();
            this.ConfirmBtn = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.repeatNewPwdTextBox = new System.Windows.Forms.TextBox();
            this.newPwdTextBox = new System.Windows.Forms.TextBox();
            this.currentPwdTextBox = new System.Windows.Forms.TextBox();
            this.repeatNewPwdLabel = new System.Windows.Forms.Label();
            this.newPwdLabel = new System.Windows.Forms.Label();
            this.currentPwdLabel = new System.Windows.Forms.Label();
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
            this.panel1.TabIndex = 5;
            this.panel1.MouseDown += new System.Windows.Forms.MouseEventHandler(this.panel1_MouseDown);
            this.panel1.MouseMove += new System.Windows.Forms.MouseEventHandler(this.panel1_MouseMove);
            this.panel1.MouseUp += new System.Windows.Forms.MouseEventHandler(this.panel1_MouseUp);
            // 
            // cancelBtn
            // 
            this.cancelBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold);
            this.cancelBtn.Location = new System.Drawing.Point(10, 530);
            this.cancelBtn.Margin = new System.Windows.Forms.Padding(1);
            this.cancelBtn.Name = "cancelBtn";
            this.cancelBtn.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.cancelBtn.Size = new System.Drawing.Size(130, 60);
            this.cancelBtn.TabIndex = 4;
            this.cancelBtn.Text = "لغو";
            this.cancelBtn.UseVisualStyleBackColor = true;
            this.cancelBtn.Click += new System.EventHandler(this.cancelBtn_Click);
            // 
            // ConfirmBtn
            // 
            this.ConfirmBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold);
            this.ConfirmBtn.Location = new System.Drawing.Point(660, 530);
            this.ConfirmBtn.Margin = new System.Windows.Forms.Padding(1);
            this.ConfirmBtn.Name = "ConfirmBtn";
            this.ConfirmBtn.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.ConfirmBtn.Size = new System.Drawing.Size(130, 60);
            this.ConfirmBtn.TabIndex = 3;
            this.ConfirmBtn.Text = "تایید";
            this.ConfirmBtn.UseVisualStyleBackColor = true;
            this.ConfirmBtn.Click += new System.EventHandler(this.ConfirmBtn_Click);
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
            this.label1.TabIndex = 6;
            this.label1.Text = "تغییر رمز";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // repeatNewPwdTextBox
            // 
            this.repeatNewPwdTextBox.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.repeatNewPwdTextBox.BackColor = System.Drawing.Color.Snow;
            this.repeatNewPwdTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.repeatNewPwdTextBox.Location = new System.Drawing.Point(289, 358);
            this.repeatNewPwdTextBox.Margin = new System.Windows.Forms.Padding(1);
            this.repeatNewPwdTextBox.MaxLength = 4;
            this.repeatNewPwdTextBox.Name = "repeatNewPwdTextBox";
            this.repeatNewPwdTextBox.Size = new System.Drawing.Size(85, 31);
            this.repeatNewPwdTextBox.TabIndex = 2;
            this.repeatNewPwdTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.repeatNewPwdTextBox.TextChanged += new System.EventHandler(this.repeatNewPwdTextBox_TextChanged);
            // 
            // newPwdTextBox
            // 
            this.newPwdTextBox.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.newPwdTextBox.BackColor = System.Drawing.Color.Snow;
            this.newPwdTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.newPwdTextBox.Location = new System.Drawing.Point(289, 288);
            this.newPwdTextBox.Margin = new System.Windows.Forms.Padding(1);
            this.newPwdTextBox.MaxLength = 4;
            this.newPwdTextBox.Name = "newPwdTextBox";
            this.newPwdTextBox.Size = new System.Drawing.Size(85, 31);
            this.newPwdTextBox.TabIndex = 1;
            this.newPwdTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.newPwdTextBox.TextChanged += new System.EventHandler(this.newPwdTextBox_TextChanged);
            // 
            // currentPwdTextBox
            // 
            this.currentPwdTextBox.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.currentPwdTextBox.BackColor = System.Drawing.Color.Snow;
            this.currentPwdTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.currentPwdTextBox.Location = new System.Drawing.Point(289, 208);
            this.currentPwdTextBox.Margin = new System.Windows.Forms.Padding(1);
            this.currentPwdTextBox.MaxLength = 4;
            this.currentPwdTextBox.Name = "currentPwdTextBox";
            this.currentPwdTextBox.Size = new System.Drawing.Size(85, 31);
            this.currentPwdTextBox.TabIndex = 0;
            this.currentPwdTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.currentPwdTextBox.TextChanged += new System.EventHandler(this.currentPwdTextBox_TextChanged);
            // 
            // repeatNewPwdLabel
            // 
            this.repeatNewPwdLabel.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.repeatNewPwdLabel.BackColor = System.Drawing.SystemColors.Info;
            this.repeatNewPwdLabel.Cursor = System.Windows.Forms.Cursors.WaitCursor;
            this.repeatNewPwdLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.repeatNewPwdLabel.Location = new System.Drawing.Point(399, 354);
            this.repeatNewPwdLabel.Margin = new System.Windows.Forms.Padding(1, 0, 1, 0);
            this.repeatNewPwdLabel.Name = "repeatNewPwdLabel";
            this.repeatNewPwdLabel.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.repeatNewPwdLabel.Size = new System.Drawing.Size(109, 42);
            this.repeatNewPwdLabel.TabIndex = 9;
            this.repeatNewPwdLabel.Text = "تکرار رمز جدید";
            this.repeatNewPwdLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // newPwdLabel
            // 
            this.newPwdLabel.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.newPwdLabel.BackColor = System.Drawing.SystemColors.Info;
            this.newPwdLabel.Cursor = System.Windows.Forms.Cursors.WaitCursor;
            this.newPwdLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.newPwdLabel.Location = new System.Drawing.Point(399, 284);
            this.newPwdLabel.Margin = new System.Windows.Forms.Padding(1, 0, 1, 0);
            this.newPwdLabel.Name = "newPwdLabel";
            this.newPwdLabel.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.newPwdLabel.Size = new System.Drawing.Size(109, 42);
            this.newPwdLabel.TabIndex = 8;
            this.newPwdLabel.Text = "رمز جدید";
            this.newPwdLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // currentPwdLabel
            // 
            this.currentPwdLabel.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.currentPwdLabel.BackColor = System.Drawing.SystemColors.Info;
            this.currentPwdLabel.Cursor = System.Windows.Forms.Cursors.WaitCursor;
            this.currentPwdLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.currentPwdLabel.Location = new System.Drawing.Point(399, 204);
            this.currentPwdLabel.Margin = new System.Windows.Forms.Padding(1, 0, 1, 0);
            this.currentPwdLabel.Name = "currentPwdLabel";
            this.currentPwdLabel.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.currentPwdLabel.Size = new System.Drawing.Size(113, 42);
            this.currentPwdLabel.TabIndex = 7;
            this.currentPwdLabel.Text = "رمز فعلی";
            this.currentPwdLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // FormChangePwd
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(96F, 96F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.BackgroundImage = global::Automated_Teller_Machine.Properties.Resources.iconfinder_5_2693823;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.ClientSize = new System.Drawing.Size(800, 600);
            this.Controls.Add(this.repeatNewPwdTextBox);
            this.Controls.Add(this.newPwdTextBox);
            this.Controls.Add(this.currentPwdTextBox);
            this.Controls.Add(this.repeatNewPwdLabel);
            this.Controls.Add(this.newPwdLabel);
            this.Controls.Add(this.currentPwdLabel);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cancelBtn);
            this.Controls.Add(this.ConfirmBtn);
            this.Controls.Add(this.panel1);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "FormChangePwd";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ATM";
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button minimizeBtn;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button cancelBtn;
        private System.Windows.Forms.Button ConfirmBtn;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox repeatNewPwdTextBox;
        private System.Windows.Forms.TextBox newPwdTextBox;
        private System.Windows.Forms.TextBox currentPwdTextBox;
        private System.Windows.Forms.Label repeatNewPwdLabel;
        private System.Windows.Forms.Label newPwdLabel;
        private System.Windows.Forms.Label currentPwdLabel;
    }
}