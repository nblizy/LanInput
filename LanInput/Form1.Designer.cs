namespace LanInput
{
    partial class Form1
    {
        /// <summary>
        /// 必需的设计器变量。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清理所有正在使用的资源。
        /// </summary>
        /// <param name="disposing">如果应释放托管资源，为 true；否则为 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows 窗体设计器生成的代码

        /// <summary>
        /// 设计器支持所需的方法 - 不要修改
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            this.textBox_URL_Show = new System.Windows.Forms.TextBox();
            this.BTN_OPEN_URL = new System.Windows.Forms.Button();
            this.BTN_GET_STR = new System.Windows.Forms.Button();
            this.webb = new System.Windows.Forms.WebBrowser();
            this.SuspendLayout();
            // 
            // textBox_URL_Show
            // 
            this.textBox_URL_Show.Location = new System.Drawing.Point(12, 12);
            this.textBox_URL_Show.Name = "textBox_URL_Show";
            this.textBox_URL_Show.Size = new System.Drawing.Size(926, 21);
            this.textBox_URL_Show.TabIndex = 0;
            this.textBox_URL_Show.Text = "https://www.sh.ctc.com/index.html";
            // 
            // BTN_OPEN_URL
            // 
            this.BTN_OPEN_URL.Location = new System.Drawing.Point(962, 12);
            this.BTN_OPEN_URL.Name = "BTN_OPEN_URL";
            this.BTN_OPEN_URL.Size = new System.Drawing.Size(75, 23);
            this.BTN_OPEN_URL.TabIndex = 1;
            this.BTN_OPEN_URL.Text = "打开";
            this.BTN_OPEN_URL.UseVisualStyleBackColor = true;
            this.BTN_OPEN_URL.Click += new System.EventHandler(this.BTN_OPEN_URL_Click);
            // 
            // BTN_GET_STR
            // 
            this.BTN_GET_STR.Location = new System.Drawing.Point(962, 53);
            this.BTN_GET_STR.Name = "BTN_GET_STR";
            this.BTN_GET_STR.Size = new System.Drawing.Size(75, 23);
            this.BTN_GET_STR.TabIndex = 2;
            this.BTN_GET_STR.Text = "获取字符";
            this.BTN_GET_STR.UseVisualStyleBackColor = true;
            // 
            // webb
            // 
            this.webb.Location = new System.Drawing.Point(12, 82);
            this.webb.MaximumSize = new System.Drawing.Size(1920, 1080);
            this.webb.MinimumSize = new System.Drawing.Size(20, 20);
            this.webb.Name = "webb";
            this.webb.Size = new System.Drawing.Size(1210, 559);
            this.webb.TabIndex = 3;
            this.webb.Navigated += new System.Windows.Forms.WebBrowserNavigatedEventHandler(this.webb_Navigated);
            this.webb.NewWindow += new System.ComponentModel.CancelEventHandler(this.webb_NewWindow);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1250, 653);
            this.Controls.Add(this.webb);
            this.Controls.Add(this.BTN_GET_STR);
            this.Controls.Add(this.BTN_OPEN_URL);
            this.Controls.Add(this.textBox_URL_Show);
            this.Name = "Form1";
            this.Text = "LanInput";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Form1_FormClosed);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBox_URL_Show;
        private System.Windows.Forms.Button BTN_OPEN_URL;
        private System.Windows.Forms.Button BTN_GET_STR;
        private System.Windows.Forms.WebBrowser webb;
    }
}

