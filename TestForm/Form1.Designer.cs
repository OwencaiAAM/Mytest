namespace TestForm
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
        /// 设计器支持所需的方法 - 不要
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            this.btnInitial = new System.Windows.Forms.Button();
            this.btnOpen = new System.Windows.Forms.Button();
            this.btnInventory = new System.Windows.Forms.Button();
            this.btnAuthenticate = new System.Windows.Forms.Button();
            this.btnConnect = new System.Windows.Forms.Button();
            this.btnDisconnect = new System.Windows.Forms.Button();
            this.btnClose = new System.Windows.Forms.Button();
            this.btnRead = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnInitial
            // 
            this.btnInitial.Location = new System.Drawing.Point(23, 25);
            this.btnInitial.Name = "btnInitial";
            this.btnInitial.Size = new System.Drawing.Size(96, 32);
            this.btnInitial.TabIndex = 0;
            this.btnInitial.Text = "初始化";
            this.btnInitial.UseVisualStyleBackColor = true;
            this.btnInitial.Click += new System.EventHandler(this.btnInitial_Click);
            // 
            // btnOpen
            // 
            this.btnOpen.Location = new System.Drawing.Point(23, 77);
            this.btnOpen.Name = "btnOpen";
            this.btnOpen.Size = new System.Drawing.Size(96, 32);
            this.btnOpen.TabIndex = 1;
            this.btnOpen.Text = "打开读卡器";
            this.btnOpen.UseVisualStyleBackColor = true;
            this.btnOpen.Click += new System.EventHandler(this.btnOpen_Click);
            // 
            // btnInventory
            // 
            this.btnInventory.Location = new System.Drawing.Point(23, 132);
            this.btnInventory.Name = "btnInventory";
            this.btnInventory.Size = new System.Drawing.Size(96, 32);
            this.btnInventory.TabIndex = 2;
            this.btnInventory.Text = "盘点标签";
            this.btnInventory.UseVisualStyleBackColor = true;
            this.btnInventory.Click += new System.EventHandler(this.btnInventory_Click);
            // 
            // btnAuthenticate
            // 
            this.btnAuthenticate.Location = new System.Drawing.Point(23, 261);
            this.btnAuthenticate.Name = "btnAuthenticate";
            this.btnAuthenticate.Size = new System.Drawing.Size(96, 32);
            this.btnAuthenticate.TabIndex = 4;
            this.btnAuthenticate.Text = "卡认证";
            this.btnAuthenticate.UseVisualStyleBackColor = true;
            this.btnAuthenticate.Click += new System.EventHandler(this.btnAuthenticate_Click);
            // 
            // btnConnect
            // 
            this.btnConnect.Location = new System.Drawing.Point(23, 197);
            this.btnConnect.Name = "btnConnect";
            this.btnConnect.Size = new System.Drawing.Size(96, 32);
            this.btnConnect.TabIndex = 5;
            this.btnConnect.Text = "卡连接";
            this.btnConnect.UseVisualStyleBackColor = true;
            this.btnConnect.Click += new System.EventHandler(this.btnConnect_Click);
            // 
            // btnDisconnect
            // 
            this.btnDisconnect.Location = new System.Drawing.Point(135, 197);
            this.btnDisconnect.Name = "btnDisconnect";
            this.btnDisconnect.Size = new System.Drawing.Size(96, 32);
            this.btnDisconnect.TabIndex = 6;
            this.btnDisconnect.Text = "断开连接";
            this.btnDisconnect.UseVisualStyleBackColor = true;
            this.btnDisconnect.Click += new System.EventHandler(this.btnDisconnect_Click);
            // 
            // btnClose
            // 
            this.btnClose.Location = new System.Drawing.Point(135, 77);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(96, 32);
            this.btnClose.TabIndex = 7;
            this.btnClose.Text = "关闭读卡器";
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // btnRead
            // 
            this.btnRead.Location = new System.Drawing.Point(23, 328);
            this.btnRead.Name = "btnRead";
            this.btnRead.Size = new System.Drawing.Size(96, 32);
            this.btnRead.TabIndex = 8;
            this.btnRead.Text = "读卡";
            this.btnRead.UseVisualStyleBackColor = true;
            this.btnRead.Click += new System.EventHandler(this.btnRead_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(345, 395);
            this.Controls.Add(this.btnRead);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.btnDisconnect);
            this.Controls.Add(this.btnConnect);
            this.Controls.Add(this.btnAuthenticate);
            this.Controls.Add(this.btnInventory);
            this.Controls.Add(this.btnOpen);
            this.Controls.Add(this.btnInitial);
            this.Name = "Form1";
            this.Text = "MF102Utest";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnInitial;
        private System.Windows.Forms.Button btnOpen;
        private System.Windows.Forms.Button btnInventory;
        private System.Windows.Forms.Button btnAuthenticate;
        private System.Windows.Forms.Button btnConnect;
        private System.Windows.Forms.Button btnDisconnect;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.Button btnRead;
    }
}

