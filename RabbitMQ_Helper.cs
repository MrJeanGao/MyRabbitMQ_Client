using System;
using System.Text;
using System.Threading.Channels;
using System.Windows.Forms;
using RabbitMQ.Client;
using RabbitMQ.Client.Events;

namespace RabbitMQ_Client
{
    public static class RabbitMQ_Helper
    {       
        public static IConnection _conn = null;
        public static IModel _channel = null;

        //Connecting to RabbitMQ
        public static void ConnectMethod(string UserName, string Password, string VirtualHost, string HostName)
        {
            try
            {
                ConnectionFactory factory = new ConnectionFactory();

                factory.UserName = UserName;
                factory.Password = Password;
                factory.VirtualHost = VirtualHost;
                factory.HostName = HostName;

                _conn = factory.CreateConnection();
                //_channel = _conn.CreateModel();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }
        public static void DisconnectMethod()
        {
            if (_conn != null)
            {
                //_channel.Close();
                _conn.Dispose();
            }
        }
    }
}
