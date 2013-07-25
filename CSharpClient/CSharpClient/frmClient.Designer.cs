namespace com.hectorea.client
{
    partial class frmClient
    {
        /// <summary>
        /// Variable del diseñador requerida.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén utilizando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben eliminar; false en caso contrario, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido del método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmClient));
            this.label2 = new System.Windows.Forms.Label();
            this.txtPort = new System.Windows.Forms.TextBox();
            this.txtChat = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtIP = new System.Windows.Forms.TextBox();
            this.txtMsg = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtUserName = new System.Windows.Forms.TextBox();
            this.btnConnect = new System.Windows.Forms.Button();
            this.btnSent = new System.Windows.Forms.Button();
            this.btnDisconnect = new System.Windows.Forms.Button();
            this.lblLastMsg = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label2.Location = new System.Drawing.Point(45, 41);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(28, 15);
            this.label2.TabIndex = 12;
            this.label2.Text = "Port";
            // 
            // txtPort
            // 
            this.txtPort.Location = new System.Drawing.Point(81, 38);
            this.txtPort.MaxLength = 4;
            this.txtPort.Name = "txtPort";
            this.txtPort.Size = new System.Drawing.Size(36, 20);
            this.txtPort.TabIndex = 11;
            this.txtPort.Text = "9090";
            // 
            // txtChat
            // 
            this.txtChat.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtChat.Enabled = false;
            this.txtChat.Location = new System.Drawing.Point(10, 97);
            this.txtChat.Multiline = true;
            this.txtChat.Name = "txtChat";
            this.txtChat.ReadOnly = true;
            this.txtChat.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.txtChat.Size = new System.Drawing.Size(346, 205);
            this.txtChat.TabIndex = 10;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label1.Location = new System.Drawing.Point(33, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(40, 15);
            this.label1.TabIndex = 8;
            this.label1.Text = "Server";
            // 
            // txtIP
            // 
            this.txtIP.Location = new System.Drawing.Point(81, 12);
            this.txtIP.MaxLength = 50;
            this.txtIP.Name = "txtIP";
            this.txtIP.Size = new System.Drawing.Size(79, 20);
            this.txtIP.TabIndex = 7;
            this.txtIP.Text = "127.0.0.1";
            // 
            // txtMsg
            // 
            this.txtMsg.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtMsg.Location = new System.Drawing.Point(13, 320);
            this.txtMsg.MaxLength = 256;
            this.txtMsg.Name = "txtMsg";
            this.txtMsg.Size = new System.Drawing.Size(265, 20);
            this.txtMsg.TabIndex = 13;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label3.Location = new System.Drawing.Point(16, 67);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(57, 15);
            this.label3.TabIndex = 16;
            this.label3.Text = "Username";
            // 
            // txtUserName
            // 
            this.txtUserName.Location = new System.Drawing.Point(81, 64);
            this.txtUserName.MaxLength = 8;
            this.txtUserName.Name = "txtUserName";
            this.txtUserName.Size = new System.Drawing.Size(79, 20);
            this.txtUserName.TabIndex = 15;
            this.txtUserName.Text = "hectorea";
            // 
            // btnConnect
            // 
            this.btnConnect.Location = new System.Drawing.Point(196, 68);
            this.btnConnect.Name = "btnConnect";
            this.btnConnect.Size = new System.Drawing.Size(75, 23);
            this.btnConnect.TabIndex = 18;
            this.btnConnect.Text = "Sign In";
            this.btnConnect.UseVisualStyleBackColor = true;
            this.btnConnect.Click += new System.EventHandler(this.btnConnect_Click);
            // 
            // btnSent
            // 
            this.btnSent.Enabled = false;
            this.btnSent.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnSent.Location = new System.Drawing.Point(284, 320);
            this.btnSent.Name = "btnSent";
            this.btnSent.Size = new System.Drawing.Size(75, 23);
            this.btnSent.TabIndex = 19;
            this.btnSent.Text = "Send";
            this.btnSent.UseVisualStyleBackColor = true;
            this.btnSent.Click += new System.EventHandler(this.btnSent_Click);
            // 
            // btnDisconnect
            // 
            this.btnDisconnect.Enabled = false;
            this.btnDisconnect.Location = new System.Drawing.Point(277, 68);
            this.btnDisconnect.Name = "btnDisconnect";
            this.btnDisconnect.Size = new System.Drawing.Size(82, 23);
            this.btnDisconnect.TabIndex = 20;
            this.btnDisconnect.Text = "Sign Out";
            this.btnDisconnect.UseVisualStyleBackColor = true;
            this.btnDisconnect.Click += new System.EventHandler(this.btnDisconnect_Click);
            // 
            // lblLastMsg
            // 
            this.lblLastMsg.AutoSize = true;
            this.lblLastMsg.BackColor = System.Drawing.SystemColors.Control;
            this.lblLastMsg.ForeColor = System.Drawing.Color.Gray;
            this.lblLastMsg.Location = new System.Drawing.Point(13, 343);
            this.lblLastMsg.Name = "lblLastMsg";
            this.lblLastMsg.Size = new System.Drawing.Size(0, 13);
            this.lblLastMsg.TabIndex = 21;
            // 
            // frmClient
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(371, 362);
            this.Controls.Add(this.lblLastMsg);
            this.Controls.Add(this.btnDisconnect);
            this.Controls.Add(this.btnSent);
            this.Controls.Add(this.btnConnect);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtUserName);
            this.Controls.Add(this.txtMsg);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtPort);
            this.Controls.Add(this.txtChat);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtIP);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "frmClient";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "CSharp Client";
            this.Load += new System.EventHandler(this.frmClient_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtPort;
        private System.Windows.Forms.TextBox txtChat;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtIP;
        private System.Windows.Forms.TextBox txtMsg;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtUserName;
        private System.Windows.Forms.Button btnConnect;
        private System.Windows.Forms.Button btnSent;
        private System.Windows.Forms.Button btnDisconnect;
        private System.Windows.Forms.Label lblLastMsg;
    }
}

