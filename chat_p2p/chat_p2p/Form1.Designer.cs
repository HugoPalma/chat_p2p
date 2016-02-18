namespace chat_p2p
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.tb_message = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.b_ip_connect = new System.Windows.Forms.Button();
            this.tb_ip_connect = new System.Windows.Forms.TextBox();
            this.tb_ip_invite = new System.Windows.Forms.TextBox();
            this.b_ip_accept = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.b_ip_deny = new System.Windows.Forms.Button();
            this.b_message_send = new System.Windows.Forms.Button();
            this.tb_chat = new System.Windows.Forms.TextBox();
            this.b_chat_clear = new System.Windows.Forms.Button();
            this.tb_nickname = new System.Windows.Forms.TextBox();
            this.b_nickname_set = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // tb_message
            // 
            this.tb_message.Enabled = false;
            this.tb_message.Location = new System.Drawing.Point(12, 446);
            this.tb_message.Name = "tb_message";
            this.tb_message.Size = new System.Drawing.Size(522, 20);
            this.tb_message.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(73, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Connect to ip:";
            // 
            // b_ip_connect
            // 
            this.b_ip_connect.Location = new System.Drawing.Point(197, 4);
            this.b_ip_connect.Name = "b_ip_connect";
            this.b_ip_connect.Size = new System.Drawing.Size(75, 23);
            this.b_ip_connect.TabIndex = 2;
            this.b_ip_connect.Text = "Connect";
            this.b_ip_connect.UseVisualStyleBackColor = true;
            // 
            // tb_ip_connect
            // 
            this.tb_ip_connect.Location = new System.Drawing.Point(91, 6);
            this.tb_ip_connect.Name = "tb_ip_connect";
            this.tb_ip_connect.Size = new System.Drawing.Size(100, 20);
            this.tb_ip_connect.TabIndex = 3;
            // 
            // tb_ip_invite
            // 
            this.tb_ip_invite.Location = new System.Drawing.Point(441, 6);
            this.tb_ip_invite.Name = "tb_ip_invite";
            this.tb_ip_invite.Size = new System.Drawing.Size(156, 20);
            this.tb_ip_invite.TabIndex = 6;
            // 
            // b_ip_accept
            // 
            this.b_ip_accept.Location = new System.Drawing.Point(522, 32);
            this.b_ip_accept.Name = "b_ip_accept";
            this.b_ip_accept.Size = new System.Drawing.Size(75, 23);
            this.b_ip_accept.TabIndex = 5;
            this.b_ip_accept.Text = "Accept";
            this.b_ip_accept.UseVisualStyleBackColor = true;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(359, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(76, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Invited from ip:";
            // 
            // b_ip_deny
            // 
            this.b_ip_deny.Location = new System.Drawing.Point(441, 32);
            this.b_ip_deny.Name = "b_ip_deny";
            this.b_ip_deny.Size = new System.Drawing.Size(75, 23);
            this.b_ip_deny.TabIndex = 7;
            this.b_ip_deny.Text = "Deny";
            this.b_ip_deny.UseVisualStyleBackColor = true;
            // 
            // b_message_send
            // 
            this.b_message_send.Enabled = false;
            this.b_message_send.Location = new System.Drawing.Point(540, 444);
            this.b_message_send.Name = "b_message_send";
            this.b_message_send.Size = new System.Drawing.Size(75, 23);
            this.b_message_send.TabIndex = 8;
            this.b_message_send.Text = "Send";
            this.b_message_send.UseVisualStyleBackColor = true;
            // 
            // tb_chat
            // 
            this.tb_chat.Enabled = false;
            this.tb_chat.Location = new System.Drawing.Point(12, 96);
            this.tb_chat.Multiline = true;
            this.tb_chat.Name = "tb_chat";
            this.tb_chat.Size = new System.Drawing.Size(522, 315);
            this.tb_chat.TabIndex = 9;
            // 
            // b_chat_clear
            // 
            this.b_chat_clear.Enabled = false;
            this.b_chat_clear.Location = new System.Drawing.Point(540, 388);
            this.b_chat_clear.Name = "b_chat_clear";
            this.b_chat_clear.Size = new System.Drawing.Size(75, 23);
            this.b_chat_clear.TabIndex = 10;
            this.b_chat_clear.Text = "Clear";
            this.b_chat_clear.UseVisualStyleBackColor = true;
            // 
            // tb_nickname
            // 
            this.tb_nickname.Location = new System.Drawing.Point(76, 70);
            this.tb_nickname.Name = "tb_nickname";
            this.tb_nickname.Size = new System.Drawing.Size(100, 20);
            this.tb_nickname.TabIndex = 12;
            // 
            // b_nickname_set
            // 
            this.b_nickname_set.Location = new System.Drawing.Point(182, 68);
            this.b_nickname_set.Name = "b_nickname_set";
            this.b_nickname_set.Size = new System.Drawing.Size(75, 23);
            this.b_nickname_set.TabIndex = 11;
            this.b_nickname_set.Text = "Set";
            this.b_nickname_set.UseVisualStyleBackColor = true;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 73);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(58, 13);
            this.label3.TabIndex = 13;
            this.label3.Text = "Nickname:";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(630, 482);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.tb_nickname);
            this.Controls.Add(this.b_nickname_set);
            this.Controls.Add(this.b_chat_clear);
            this.Controls.Add(this.tb_chat);
            this.Controls.Add(this.b_message_send);
            this.Controls.Add(this.b_ip_deny);
            this.Controls.Add(this.tb_ip_invite);
            this.Controls.Add(this.b_ip_accept);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.tb_ip_connect);
            this.Controls.Add(this.b_ip_connect);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.tb_message);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "Form1";
            this.Text = "Chat P2P";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox tb_message;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button b_ip_connect;
        private System.Windows.Forms.TextBox tb_ip_connect;
        private System.Windows.Forms.TextBox tb_ip_invite;
        private System.Windows.Forms.Button b_ip_accept;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button b_ip_deny;
        private System.Windows.Forms.Button b_message_send;
        private System.Windows.Forms.TextBox tb_chat;
        private System.Windows.Forms.Button b_chat_clear;
        private System.Windows.Forms.TextBox tb_nickname;
        private System.Windows.Forms.Button b_nickname_set;
        private System.Windows.Forms.Label label3;
    }
}

