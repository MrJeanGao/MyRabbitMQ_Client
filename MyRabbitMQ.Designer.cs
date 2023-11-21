namespace MyRabbitMQ_Client
{
    partial class MyRabbitMQ
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MyRabbitMQ));
            this.groupBox_sendContent = new System.Windows.Forms.GroupBox();
            this.groupBox_showLog = new System.Windows.Forms.GroupBox();
            this.label_host = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.groupBox_config = new System.Windows.Forms.GroupBox();
            this.textBox_connectState = new System.Windows.Forms.TextBox();
            this.label_connectState = new System.Windows.Forms.Label();
            this.button_disconnect = new System.Windows.Forms.Button();
            this.button_connect = new System.Windows.Forms.Button();
            this.textBox_publishExchange = new System.Windows.Forms.TextBox();
            this.label_publishExchange = new System.Windows.Forms.Label();
            this.button_send = new System.Windows.Forms.Button();
            this.textBox_password = new System.Windows.Forms.TextBox();
            this.label_password = new System.Windows.Forms.Label();
            this.textBox_userName = new System.Windows.Forms.TextBox();
            this.label_userName = new System.Windows.Forms.Label();
            this.textBox_vHost = new System.Windows.Forms.TextBox();
            this.label_vHost = new System.Windows.Forms.Label();
            this.textBox_port = new System.Windows.Forms.TextBox();
            this.label_port = new System.Windows.Forms.Label();
            this.textBox_host = new System.Windows.Forms.TextBox();
            this.button_listenMsg = new System.Windows.Forms.Button();
            this.textBox_listenQueue = new System.Windows.Forms.TextBox();
            this.label_listenQueue = new System.Windows.Forms.Label();
            this.richTextBox_showLog = new System.Windows.Forms.RichTextBox();
            this.textBox_sendContent = new System.Windows.Forms.TextBox();
            this.groupBox_sendContent.SuspendLayout();
            this.groupBox_showLog.SuspendLayout();
            this.panel1.SuspendLayout();
            this.groupBox_config.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox_sendContent
            // 
            this.groupBox_sendContent.Controls.Add(this.textBox_sendContent);
            this.groupBox_sendContent.Location = new System.Drawing.Point(15, 437);
            this.groupBox_sendContent.Name = "groupBox_sendContent";
            this.groupBox_sendContent.Size = new System.Drawing.Size(634, 426);
            this.groupBox_sendContent.TabIndex = 0;
            this.groupBox_sendContent.TabStop = false;
            this.groupBox_sendContent.Text = "SendContent";
            // 
            // groupBox_showLog
            // 
            this.groupBox_showLog.Controls.Add(this.richTextBox_showLog);
            this.groupBox_showLog.Location = new System.Drawing.Point(651, 437);
            this.groupBox_showLog.Name = "groupBox_showLog";
            this.groupBox_showLog.Size = new System.Drawing.Size(656, 426);
            this.groupBox_showLog.TabIndex = 1;
            this.groupBox_showLog.TabStop = false;
            this.groupBox_showLog.Text = "ShowLog";
            // 
            // label_host
            // 
            this.label_host.AutoSize = true;
            this.label_host.Location = new System.Drawing.Point(17, 43);
            this.label_host.Name = "label_host";
            this.label_host.Size = new System.Drawing.Size(58, 24);
            this.label_host.TabIndex = 2;
            this.label_host.Text = "Host";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.groupBox_config);
            this.panel1.Controls.Add(this.groupBox_showLog);
            this.panel1.Controls.Add(this.groupBox_sendContent);
            this.panel1.Location = new System.Drawing.Point(-3, 2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1307, 874);
            this.panel1.TabIndex = 3;
            // 
            // groupBox_config
            // 
            this.groupBox_config.Controls.Add(this.textBox_listenQueue);
            this.groupBox_config.Controls.Add(this.label_listenQueue);
            this.groupBox_config.Controls.Add(this.button_listenMsg);
            this.groupBox_config.Controls.Add(this.textBox_connectState);
            this.groupBox_config.Controls.Add(this.label_connectState);
            this.groupBox_config.Controls.Add(this.button_disconnect);
            this.groupBox_config.Controls.Add(this.button_connect);
            this.groupBox_config.Controls.Add(this.textBox_publishExchange);
            this.groupBox_config.Controls.Add(this.label_publishExchange);
            this.groupBox_config.Controls.Add(this.button_send);
            this.groupBox_config.Controls.Add(this.textBox_password);
            this.groupBox_config.Controls.Add(this.label_password);
            this.groupBox_config.Controls.Add(this.textBox_userName);
            this.groupBox_config.Controls.Add(this.label_userName);
            this.groupBox_config.Controls.Add(this.textBox_vHost);
            this.groupBox_config.Controls.Add(this.label_vHost);
            this.groupBox_config.Controls.Add(this.textBox_port);
            this.groupBox_config.Controls.Add(this.label_port);
            this.groupBox_config.Controls.Add(this.textBox_host);
            this.groupBox_config.Controls.Add(this.label_host);
            this.groupBox_config.Location = new System.Drawing.Point(15, 3);
            this.groupBox_config.Name = "groupBox_config";
            this.groupBox_config.Size = new System.Drawing.Size(1289, 428);
            this.groupBox_config.TabIndex = 3;
            this.groupBox_config.TabStop = false;
            this.groupBox_config.Text = "Config";
            // 
            // textBox_connectState
            // 
            this.textBox_connectState.Location = new System.Drawing.Point(1075, 40);
            this.textBox_connectState.Name = "textBox_connectState";
            this.textBox_connectState.ReadOnly = true;
            this.textBox_connectState.Size = new System.Drawing.Size(162, 35);
            this.textBox_connectState.TabIndex = 18;
            // 
            // label_connectState
            // 
            this.label_connectState.AutoSize = true;
            this.label_connectState.Location = new System.Drawing.Point(894, 46);
            this.label_connectState.Name = "label_connectState";
            this.label_connectState.Size = new System.Drawing.Size(154, 24);
            this.label_connectState.TabIndex = 17;
            this.label_connectState.Text = "ConnectState";
            // 
            // button_disconnect
            // 
            this.button_disconnect.BackColor = System.Drawing.Color.Red;
            this.button_disconnect.Location = new System.Drawing.Point(1075, 179);
            this.button_disconnect.Name = "button_disconnect";
            this.button_disconnect.Size = new System.Drawing.Size(162, 62);
            this.button_disconnect.TabIndex = 16;
            this.button_disconnect.Text = "Disconnect";
            this.button_disconnect.UseVisualStyleBackColor = false;
            this.button_disconnect.Click += new System.EventHandler(this.button_disconnect_Click);
            // 
            // button_connect
            // 
            this.button_connect.BackColor = System.Drawing.Color.Lime;
            this.button_connect.Location = new System.Drawing.Point(1075, 101);
            this.button_connect.Name = "button_connect";
            this.button_connect.Size = new System.Drawing.Size(162, 53);
            this.button_connect.TabIndex = 15;
            this.button_connect.Text = "Connect";
            this.button_connect.UseVisualStyleBackColor = false;
            this.button_connect.Click += new System.EventHandler(this.button_connect_Click);
            // 
            // textBox_publishExchange
            // 
            this.textBox_publishExchange.Location = new System.Drawing.Point(165, 324);
            this.textBox_publishExchange.Name = "textBox_publishExchange";
            this.textBox_publishExchange.Size = new System.Drawing.Size(227, 35);
            this.textBox_publishExchange.TabIndex = 14;
            this.textBox_publishExchange.Text = "TestExchange1";
            // 
            // label_publishExchange
            // 
            this.label_publishExchange.AutoSize = true;
            this.label_publishExchange.Location = new System.Drawing.Point(17, 327);
            this.label_publishExchange.Name = "label_publishExchange";
            this.label_publishExchange.Size = new System.Drawing.Size(142, 24);
            this.label_publishExchange.TabIndex = 13;
            this.label_publishExchange.Text = "PubExchange";
            // 
            // button_send
            // 
            this.button_send.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.button_send.Location = new System.Drawing.Point(1075, 356);
            this.button_send.Name = "button_send";
            this.button_send.Size = new System.Drawing.Size(162, 62);
            this.button_send.TabIndex = 12;
            this.button_send.Text = "SendMsg";
            this.button_send.UseVisualStyleBackColor = false;
            this.button_send.Click += new System.EventHandler(this.button_send_Click);
            // 
            // textBox_password
            // 
            this.textBox_password.Location = new System.Drawing.Point(165, 206);
            this.textBox_password.Name = "textBox_password";
            this.textBox_password.PasswordChar = '*';
            this.textBox_password.Size = new System.Drawing.Size(227, 35);
            this.textBox_password.TabIndex = 11;
            this.textBox_password.Text = "123";
            // 
            // label_password
            // 
            this.label_password.AutoSize = true;
            this.label_password.Location = new System.Drawing.Point(17, 209);
            this.label_password.Name = "label_password";
            this.label_password.Size = new System.Drawing.Size(106, 24);
            this.label_password.TabIndex = 10;
            this.label_password.Text = "Password";
            // 
            // textBox_userName
            // 
            this.textBox_userName.Location = new System.Drawing.Point(165, 153);
            this.textBox_userName.Name = "textBox_userName";
            this.textBox_userName.Size = new System.Drawing.Size(227, 35);
            this.textBox_userName.TabIndex = 9;
            this.textBox_userName.Text = "admin";
            // 
            // label_userName
            // 
            this.label_userName.AutoSize = true;
            this.label_userName.Location = new System.Drawing.Point(17, 156);
            this.label_userName.Name = "label_userName";
            this.label_userName.Size = new System.Drawing.Size(106, 24);
            this.label_userName.TabIndex = 8;
            this.label_userName.Text = "UserName";
            // 
            // textBox_vHost
            // 
            this.textBox_vHost.Location = new System.Drawing.Point(165, 268);
            this.textBox_vHost.Name = "textBox_vHost";
            this.textBox_vHost.Size = new System.Drawing.Size(227, 35);
            this.textBox_vHost.TabIndex = 7;
            this.textBox_vHost.Text = "test";
            // 
            // label_vHost
            // 
            this.label_vHost.AutoSize = true;
            this.label_vHost.Location = new System.Drawing.Point(17, 271);
            this.label_vHost.Name = "label_vHost";
            this.label_vHost.Size = new System.Drawing.Size(142, 24);
            this.label_vHost.TabIndex = 6;
            this.label_vHost.Text = "virtualHost";
            // 
            // textBox_port
            // 
            this.textBox_port.Location = new System.Drawing.Point(165, 101);
            this.textBox_port.Name = "textBox_port";
            this.textBox_port.Size = new System.Drawing.Size(227, 35);
            this.textBox_port.TabIndex = 5;
            this.textBox_port.Text = "5672";
            // 
            // label_port
            // 
            this.label_port.AutoSize = true;
            this.label_port.Location = new System.Drawing.Point(17, 104);
            this.label_port.Name = "label_port";
            this.label_port.Size = new System.Drawing.Size(58, 24);
            this.label_port.TabIndex = 4;
            this.label_port.Text = "Port";
            // 
            // textBox_host
            // 
            this.textBox_host.Location = new System.Drawing.Point(165, 40);
            this.textBox_host.Name = "textBox_host";
            this.textBox_host.Size = new System.Drawing.Size(227, 35);
            this.textBox_host.TabIndex = 3;
            this.textBox_host.Text = "127.0.0.1";
            // 
            // button_listenMsg
            // 
            this.button_listenMsg.BackColor = System.Drawing.Color.Cyan;
            this.button_listenMsg.Location = new System.Drawing.Point(1075, 268);
            this.button_listenMsg.Name = "button_listenMsg";
            this.button_listenMsg.Size = new System.Drawing.Size(162, 58);
            this.button_listenMsg.TabIndex = 19;
            this.button_listenMsg.Text = "ListenMsg";
            this.button_listenMsg.UseVisualStyleBackColor = false;
            this.button_listenMsg.Click += new System.EventHandler(this.button_listenMsg_Click);
            // 
            // textBox_listenQueue
            // 
            this.textBox_listenQueue.Location = new System.Drawing.Point(165, 383);
            this.textBox_listenQueue.Name = "textBox_listenQueue";
            this.textBox_listenQueue.Size = new System.Drawing.Size(227, 35);
            this.textBox_listenQueue.TabIndex = 21;
            this.textBox_listenQueue.Text = "TestQueue2";
            // 
            // label_listenQueue
            // 
            this.label_listenQueue.AutoSize = true;
            this.label_listenQueue.Location = new System.Drawing.Point(17, 386);
            this.label_listenQueue.Name = "label_listenQueue";
            this.label_listenQueue.Size = new System.Drawing.Size(142, 24);
            this.label_listenQueue.TabIndex = 20;
            this.label_listenQueue.Text = "ListenQueue";
            // 
            // richTextBox_showLog
            // 
            this.richTextBox_showLog.Location = new System.Drawing.Point(6, 34);
            this.richTextBox_showLog.Name = "richTextBox_showLog";
            this.richTextBox_showLog.Size = new System.Drawing.Size(644, 381);
            this.richTextBox_showLog.TabIndex = 22;
            this.richTextBox_showLog.Text = "";
            // 
            // textBox_sendContent
            // 
            this.textBox_sendContent.Location = new System.Drawing.Point(21, 34);
            this.textBox_sendContent.Multiline = true;
            this.textBox_sendContent.Name = "textBox_sendContent";
            this.textBox_sendContent.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.textBox_sendContent.Size = new System.Drawing.Size(612, 381);
            this.textBox_sendContent.TabIndex = 0;
            // 
            // MyRabbitMQ
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 24F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1316, 873);
            this.Controls.Add(this.panel1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "MyRabbitMQ";
            this.Text = "MyRabbitMQ";
            this.groupBox_sendContent.ResumeLayout(false);
            this.groupBox_sendContent.PerformLayout();
            this.groupBox_showLog.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.groupBox_config.ResumeLayout(false);
            this.groupBox_config.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox_sendContent;
        private System.Windows.Forms.GroupBox groupBox_showLog;
        private System.Windows.Forms.Label label_host;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.GroupBox groupBox_config;
        private System.Windows.Forms.Label label_password;
        private System.Windows.Forms.TextBox textBox_userName;
        private System.Windows.Forms.Label label_userName;
        private System.Windows.Forms.TextBox textBox_vHost;
        private System.Windows.Forms.Label label_vHost;
        private System.Windows.Forms.TextBox textBox_port;
        private System.Windows.Forms.Label label_port;
        private System.Windows.Forms.TextBox textBox_host;
        private System.Windows.Forms.TextBox textBox_password;
        private System.Windows.Forms.Button button_send;
        private System.Windows.Forms.TextBox textBox_publishExchange;
        private System.Windows.Forms.Label label_publishExchange;
        private System.Windows.Forms.Button button_connect;
        private System.Windows.Forms.Button button_disconnect;
        private System.Windows.Forms.TextBox textBox_connectState;
        private System.Windows.Forms.Label label_connectState;
        private System.Windows.Forms.Button button_listenMsg;
        private System.Windows.Forms.TextBox textBox_listenQueue;
        private System.Windows.Forms.Label label_listenQueue;
        private System.Windows.Forms.RichTextBox richTextBox_showLog;
        private System.Windows.Forms.TextBox textBox_sendContent;
    }
}

