/* 
 * @autor: hectorea
 * @date: 24/07/2013
 * @projet: ChatServer 
 * 
 */

using System.Collections;
using System.Net;
using System.Net.Sockets;
using System.Text;
using System.Threading;

namespace com.hectorea.server
{
    public delegate void MessageReceivedHandler(string message);
    public delegate void MessageSentdHandler(string message);

    public sealed class Server
    {
        public event MessageReceivedHandler MessageReceived;
        public event MessageSentdHandler MessageSent;       

        private const string JOINMSG = " has joined to the Chat";
        private const string LEFTMSG = " has left the Chat";

        public TcpListener TcpListener { get; private set; }
        public Hashtable Users { get; set; }

        public Server()
        {
            IPAddress ip = IPAddress.Parse("127.0.0.1");
            TcpListener = new TcpListener(ip, 9090);

            Users = new Hashtable();
        }

        public Server(string ip, int port)
            : this()
        {
            TcpListener = new TcpListener(IPAddress.Parse(ip), port);
        }

        public void Start()
        {
            TcpListener.Start();

            AcceptClient();
        }

        public void Stop()
        {
            TcpListener.Stop();            
        }

        public void Send(string username, string msg)
        {
            foreach (DictionaryEntry user in Users)
            {
                byte[] data = null;

                TcpClient client = (TcpClient)user.Value;

                NetworkStream stream = client.GetStream();

                if (username == string.Empty)
                {
                    data = Encoding.ASCII.GetBytes(msg);
                }
                else
                {
                    data = Encoding.ASCII.GetBytes(string.Format("{0} says: {1}", username, msg));
                    MessageSent(string.Format("Message sent to {0}", user.Key));
                }

                stream.Write(data, 0, data.Length);
                stream.Flush();

            }
        }

        private void AcceptClient()
        {
            try
            {
                while (true)
                {
                    byte[] buffer = new byte[256];

                    TcpClient TcpClient = TcpListener.AcceptTcpClient();

                    NetworkStream stream = TcpClient.GetStream();
                    stream.Read(buffer, 0, buffer.Length);

                    var msg = Encoding.ASCII.GetString(buffer, 0, buffer.Length).Split(new char[] { '#' });
                    var cmd = msg[0];
                    var usr = msg[1];

                    if (Users.ContainsKey(usr))
                    {
                    }
                    else
                    {
                        Command(usr,cmd,string.Empty);
                        
                         Users.Add(usr, TcpClient);

                        Thread thread = new Thread(Receive);
                        thread.Start(TcpClient);
                    }
                }
            }
            catch (SocketException)
            {
                //Known exception when we stop the server. For now, We only manages it to avoid crashing the app
            }
        }

        private void Receive(object o)
        {
            TcpClient client = (TcpClient)o;

            while (true)
            {
                byte[] buffer = new byte[256];

                NetworkStream stream = client.GetStream();
                stream.Read(buffer, 0, buffer.Length);

                var msg = Encoding.ASCII.GetString(buffer, 0, buffer.Length).Split(new char[] { '#' });

                if (msg.Length > 2)
                {
                    var cmd = msg[0];
                    var usr = msg[1];
                    var sms = msg[2];

                    Command(usr, cmd, sms);
                }
                else if (msg.Length > 1)
                {
                    var cmd = msg[0];
                    var usr = msg[1];

                    Command(usr, cmd);
                }
            }
        }

        private void Command(string user, string command, string msg = "")
        {
            switch (command)
            {
                case "SIGNIN":
                    Send(string.Empty, string.Format("{0} {1}", user, JOINMSG));
                    MessageReceived(string.Format("{0} {1}", user, JOINMSG));
                    break;
                case "SIGNOFF":
                    Users.Remove(user);
                    Send(user, string.Format("{0} {1}", user, LEFTMSG));
                    MessageReceived(string.Format("{0} {1}", user, LEFTMSG));
                    break;
                case "MSG":
                    Send(user, msg);                    
                    MessageReceived(string.Format("Message received from {0}", user));
                    break;
                default:
                    return;

            }
        }
    }
}
