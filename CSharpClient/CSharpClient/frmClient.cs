using System;
using System.Windows.Forms;
using com.hectorea.client;

namespace com.hectorea.client
{
    public partial class frmClient : Form
    {
        Client client = new Client();

        public frmClient()
        {
            InitializeComponent();
        }

        private void frmClient_Load(object sender, EventArgs e)
        {
            client.MessageSent += new MessageSentdHandler(client_MessageSent);
            client.MessageReceived += new MessageReceivedHandler(client_MessageReceived);
        }

        private void btnConnect_Click(object sender, EventArgs e)
        {
            client.Connect(txtIP.Text, 9090, txtUserName.Text);

            this.Text = "CSharp Client: Connected";

            EnableControls(false);
        }

        private void btnSent_Click(object sender, EventArgs e)
        {
            btnSent.Text = "Sending";

            client.Send(txtUserName.Text, txtMsg.Text);
            txtMsg.Text = string.Empty;
        }

        private void client_MessageSent(string message)
        {
            if (message == "Message Sent")
            {
                btnSent.Text = "Send";
                return;
            }

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

        private void client_MessageReceived(string message)
        {
            if (InvokeRequired)
            {
                Invoke(new MethodInvoker(delegate()
                {
                    if (txtChat != null)
                        txtChat.Text = txtChat.Text + Environment.NewLine + " -> " + message;

                    if (lblLastMsg != null)
                        lblLastMsg.Text = string.Format("Last Message Received at {0}", DateTime.Now.ToShortTimeString());
                }));

            }
            else
            {
                txtChat.Text = txtChat.Text + Environment.NewLine + " -> " + message;
                lblLastMsg.Text = string.Format("Last Message Received at {0}", DateTime.Now.ToShortTimeString());

            }

        }

        private void btnDisconnect_Click(object sender, EventArgs e)
        {
            client.Disconnect(txtUserName.Text);

            this.Text = "CSharp Client: Disconnected";

            EnableControls(true);
        }

        private void EnableControls(bool value)
        {
            btnConnect.Enabled = value;
            txtUserName.Enabled = value;
            txtPort.Enabled = value;
            txtIP.Enabled = value;
            btnDisconnect.Enabled = !value;
            btnSent.Enabled = !value;
        }
    }
}
