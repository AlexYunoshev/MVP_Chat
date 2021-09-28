
namespace MVP_Chat
{
    partial class ChatView
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
            this.listViewMessages = new System.Windows.Forms.ListView();
            this.textBoxSenderLogin = new System.Windows.Forms.TextBox();
            this.textBoxReceiverLogin = new System.Windows.Forms.TextBox();
            this.labelSenderName = new System.Windows.Forms.Label();
            this.labelReceiverName = new System.Windows.Forms.Label();
            this.textBoxMessage = new System.Windows.Forms.TextBox();
            this.labelMessage = new System.Windows.Forms.Label();
            this.buttonSend = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // listViewMessages
            // 
            this.listViewMessages.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.listViewMessages.HideSelection = false;
            this.listViewMessages.Location = new System.Drawing.Point(12, 67);
            this.listViewMessages.MultiSelect = false;
            this.listViewMessages.Name = "listViewMessages";
            this.listViewMessages.ShowGroups = false;
            this.listViewMessages.Size = new System.Drawing.Size(308, 426);
            this.listViewMessages.TabIndex = 0;
            this.listViewMessages.UseCompatibleStateImageBehavior = false;
            this.listViewMessages.View = System.Windows.Forms.View.List;
            // 
            // textBoxSenderLogin
            // 
            this.textBoxSenderLogin.Location = new System.Drawing.Point(12, 41);
            this.textBoxSenderLogin.Name = "textBoxSenderLogin";
            this.textBoxSenderLogin.Size = new System.Drawing.Size(140, 20);
            this.textBoxSenderLogin.TabIndex = 1;
            // 
            // textBoxReceiverLogin
            // 
            this.textBoxReceiverLogin.Location = new System.Drawing.Point(180, 41);
            this.textBoxReceiverLogin.Name = "textBoxReceiverLogin";
            this.textBoxReceiverLogin.Size = new System.Drawing.Size(140, 20);
            this.textBoxReceiverLogin.TabIndex = 2;
            // 
            // labelSenderName
            // 
            this.labelSenderName.Location = new System.Drawing.Point(12, 9);
            this.labelSenderName.Name = "labelSenderName";
            this.labelSenderName.Size = new System.Drawing.Size(140, 29);
            this.labelSenderName.TabIndex = 3;
            this.labelSenderName.Text = "Sender name:";
            this.labelSenderName.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // labelReceiverName
            // 
            this.labelReceiverName.Location = new System.Drawing.Point(180, 9);
            this.labelReceiverName.Name = "labelReceiverName";
            this.labelReceiverName.Size = new System.Drawing.Size(140, 29);
            this.labelReceiverName.TabIndex = 4;
            this.labelReceiverName.Text = "Receiver name:";
            this.labelReceiverName.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // textBoxMessage
            // 
            this.textBoxMessage.Location = new System.Drawing.Point(12, 527);
            this.textBoxMessage.Name = "textBoxMessage";
            this.textBoxMessage.Size = new System.Drawing.Size(308, 20);
            this.textBoxMessage.TabIndex = 5;
            // 
            // labelMessage
            // 
            this.labelMessage.Location = new System.Drawing.Point(12, 496);
            this.labelMessage.Name = "labelMessage";
            this.labelMessage.Size = new System.Drawing.Size(308, 28);
            this.labelMessage.TabIndex = 6;
            this.labelMessage.Text = "Message text:";
            this.labelMessage.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // buttonSend
            // 
            this.buttonSend.Location = new System.Drawing.Point(12, 566);
            this.buttonSend.Name = "buttonSend";
            this.buttonSend.Size = new System.Drawing.Size(308, 23);
            this.buttonSend.TabIndex = 7;
            this.buttonSend.Text = "Send";
            this.buttonSend.UseVisualStyleBackColor = true;
            this.buttonSend.Click += new System.EventHandler(this.buttonSend_Click);
            // 
            // ChatView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(334, 606);
            this.Controls.Add(this.buttonSend);
            this.Controls.Add(this.labelMessage);
            this.Controls.Add(this.textBoxMessage);
            this.Controls.Add(this.labelReceiverName);
            this.Controls.Add(this.labelSenderName);
            this.Controls.Add(this.textBoxReceiverLogin);
            this.Controls.Add(this.textBoxSenderLogin);
            this.Controls.Add(this.listViewMessages);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "ChatView";
            this.ShowIcon = false;
            this.Text = "ChatForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListView listViewMessages;
        private System.Windows.Forms.TextBox textBoxSenderLogin;
        private System.Windows.Forms.TextBox textBoxReceiverLogin;
        private System.Windows.Forms.Label labelSenderName;
        private System.Windows.Forms.Label labelReceiverName;
        private System.Windows.Forms.TextBox textBoxMessage;
        private System.Windows.Forms.Label labelMessage;
        private System.Windows.Forms.Button buttonSend;
    }
}