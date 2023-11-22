using RabbitMQ.Client;
using RabbitMQ.Client.Events;
using RabbitMQ_Client;
using System;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace MyRabbitMQ_Client
{
    public partial class MyRabbitMQ : Form
    {
        static readonly object _logLock = new object();
        const string sendTag = "[Send]";
        const string receivetag = "[Rec]";
        const string connect = "Connecting";
        const string disconnect = "Disconnected";
        private IModel _channel = null;
        private IConnection _conn = null;

        public MyRabbitMQ()
        {
            InitializeComponent();
        }
        public void ShowLogMsg(string msgTag, string info)
        {
            lock (_logLock)
            {             
                StringBuilder txt = new StringBuilder();
                txt.AppendLine($"{DateTime.Now.ToString("HH:mm:ss.fff")}{msgTag}\t{info}");
                if (msgTag == sendTag)
                {
                    richTextBox_showLog.SelectionStart = richTextBox_showLog.TextLength;
                    richTextBox_showLog.SelectionLength = 0;
                    richTextBox_showLog.SelectionColor = Color.Blue;
                }
                else if(msgTag == receivetag)
                {
                    richTextBox_showLog.SelectionStart = richTextBox_showLog.TextLength;
                    richTextBox_showLog.SelectionLength = 0;
                    richTextBox_showLog.SelectionColor = Color.Gold;
                }
                richTextBox_showLog.AppendText(txt.ToString());
            }
        }

        private void button_send_Click(object sender, EventArgs e)
        {
            if ( _conn == null)
            {
                MessageBox.Show("先连接MQ！");
                return;
            }
            using (var channel = _conn.CreateModel())
            {
                string publishExchangeName = textBox_publishExchange.Text;
                string routingKey = "";
                string Message = textBox_sendContent.Text;
                bool result = SendMessage(channel, publishExchangeName, routingKey, Message);
                if (result)
                {
                    ShowLogMsg(sendTag, Message);
                }
            } // 在这里 channel 会被自动关闭和释放资源
            
        }
        public bool SendMessage(IModel channel,string publishExchangeName, string routingKey, string Message)
        {
            try
            {
                byte[] messageBodyBytes = Encoding.UTF8.GetBytes(Message);
                IBasicProperties props = channel.CreateBasicProperties();
                props.ContentType = "text/plain";
                props.DeliveryMode = 2;
                channel.BasicPublish(publishExchangeName, routingKey, props, messageBodyBytes);
                return true;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                return false;
            }
        }

        private void button_connect_Click(object sender, EventArgs e)
        {
            try
            {
                string userName = textBox_userName.Text;
                string password = textBox_password.Text;
                string vHost = textBox_vHost.Text;
                string hostName = textBox_host.Text;
                RabbitMQ_Helper.ConnectMethod(userName, password, vHost, hostName);
                _channel = RabbitMQ_Helper._channel;
                _conn = RabbitMQ_Helper._conn;
                textBox_connectState.Text = connect;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }            
        }

        private void button_disconnect_Click(object sender, EventArgs e)
        {
            RabbitMQ_Helper.DisconnectMethod();
            textBox_connectState.Text = disconnect;
        }

        private void button_listenMsg_Click(object sender, EventArgs e)
        {
            if (_conn == null)
            {
                MessageBox.Show("先连接MQ!");
                return;
            }
            if (string.IsNullOrEmpty(textBox_listenQueue.Text))
            {
                MessageBox.Show("ListenQueu不能为空!");
                return;
            }
            string listenQueue = textBox_listenQueue.Text;
            IModel channel = _conn.CreateModel();
            // 定义队列
            channel.QueueDeclare(queue: listenQueue, durable: true, exclusive: false, autoDelete: false, arguments: null);

            // 创建消费者
            var consumer = new EventingBasicConsumer(channel);

            // 注册消息接收事件
            consumer.Received += (model, ea) =>
            {
                var body = ea.Body.ToArray();
                var message = Encoding.UTF8.GetString(body);

                // 使用 Invoke 确保在 UI 线程上更新 TextBox
                richTextBox_showLog.Invoke(new Action(() =>
                {
                    ShowLogMsg(receivetag, message);
                }));
            };

            // 启动消费者监听队列
            channel.BasicConsume(queue: listenQueue, autoAck: true, consumer: consumer);
        }
    }
}
