/* 
 * @autor: hectorea
 * @date: 24/07/2013
 * @projet: CSharpClient 
 * 
 */

using System.IO;
using System.Net.Sockets;
using System.Text;
using System.Threading;

namespace com.hectorea.client
{
    public delegate void MessageReceivedHandler(string message);
    public delegate void MessageSentdHandler(string message);

public sealed class Client
{
    public event MessageReceivedHandler MessageReceived;
    public event MessageSentdHandler MessageSent;

    private const string _SIGNIN = "SIGNIN";
    private const string _SIGNOFF = "SIGNOFF";
    private const string _MSG = "MSG";

    public TcpClient TcpClient { get; private set; }

    public Client()
    {
        TcpClient = new TcpClient();
    }

    public void Connect(string ip, int port, string username)
    {
        TcpClient.Connect(ip, port);

        var msg = string.Format("{0}#{1}", _SIGNIN, username);

        Send(username, string.Empty, _SIGNIN);

        Thread thread = new Thread(Receive);
        thread.Start();
    }

    public void Disconnect(string username)
    {
        Send(username,string.Empty,_SIGNOFF);

        TcpClient.Close();
    }

    public void Send(string username, string msg, string cmd=_MSG)
    {
        byte[] data = Encoding.ASCII.GetBytes(string.Format("{0}#{1}#{2}#", cmd, username, msg));
            
        NetworkStream stream = TcpClient.GetStream();
        stream.Write(data, 0, data.Length);
        stream.Flush();

        MessageSent("Message Sent");
    }

    private void Receive()
    {
        try
        {
            while (true)
            {
                NetworkStream stream = TcpClient.GetStream();
                byte[] buffer = new byte[256];

                stream.Read(buffer, 0, buffer.Length);

                var msg = Encoding.ASCII.GetString(buffer);

                MessageReceived(msg);
            }
        }
        catch (IOException)
        {
            //Logic to reconnect
        }
    }
}
}
