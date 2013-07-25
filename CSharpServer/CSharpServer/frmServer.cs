/* 
 * @autor: hectorea
 * @date: 24/07/2013
 * @projet: ChatServer 
 * 
 */
using System;
using System.Threading;
using System.Windows.Forms;

namespace com.hectorea.server
{    
    public partial class frmServer : Form
    {
        Server server = new Server();

        public frmServer()
        {
            InitializeComponent();
        }

        private void frmServer_Load(object sender, EventArgs e)
        {
            server.MessageReceived += new MessageReceivedHandler(server_MessageReceived);
            server.MessageSent += new MessageSentdHandler(server_MessageSent);
        }

        private void btnStart_Click(object sender, EventArgs e)
        {
            Thread thread = new Thread(server.Start);
            thread.Start();

            txtChat.Text = "Server Started...";

            this.Text = "CSharpChat Server: Running";

            EnableControls(false);
        }

        private void btnStop_Click(object sender, EventArgs e)
        {
            server.Stop();
            
            this.Text = "CSharpChat Server: Stopped";
            
            txtChat.Text = txtChat.Text + Environment.NewLine + "Server Stopped...";

            EnableControls(true);
        }

        private void EnableControls(bool value)
        {
            btnStart.Enabled = value;
            txtIP.Enabled = value;
            txtPort.Enabled = value;
            btnStop.Enabled = !value;
        }

        private void server_MessageSent(string message)
        {
            if (InvokeRequired)
            {
                Invoke(new MethodInvoker(delegate()
                {
                    if (txtChat != null)
                        txtChat.Text = txtChat.Text + Environment.NewLine + " -> " + message;
                }));

            }
            else
            {
                txtChat.Text = txtChat.Text + Environment.NewLine + " -> " + message;
            }
        }

        private void server_MessageReceived(string message)
        {

            if (InvokeRequired)
            {
                Invoke(new MethodInvoker(delegate()
                {
                    if (txtChat != null)
                        txtChat.Text = txtChat.Text + Environment.NewLine + " -> " + message;
                }));

            }
            else
            {
                txtChat.Text = txtChat.Text + Environment.NewLine + " -> " + message;
            }
        }       
    }
}
