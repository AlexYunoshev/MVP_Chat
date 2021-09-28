
namespace MVP_Chat
{
    partial class MainView
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
            this.buttonOpenChatOleksandr = new System.Windows.Forms.Button();
            this.buttonOpenChatSerhii = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // buttonOpenChatOleksandr
            // 
            this.buttonOpenChatOleksandr.Location = new System.Drawing.Point(12, 12);
            this.buttonOpenChatOleksandr.Name = "buttonOpenChatOleksandr";
            this.buttonOpenChatOleksandr.Size = new System.Drawing.Size(139, 58);
            this.buttonOpenChatOleksandr.TabIndex = 0;
            this.buttonOpenChatOleksandr.Text = "Open chat as Oleksandr";
            this.buttonOpenChatOleksandr.UseVisualStyleBackColor = true;
            this.buttonOpenChatOleksandr.Click += new System.EventHandler(this.buttonOpenChatOleksandr_Click);
            // 
            // buttonOpenChatSerhii
            // 
            this.buttonOpenChatSerhii.Location = new System.Drawing.Point(177, 12);
            this.buttonOpenChatSerhii.Name = "buttonOpenChatSerhii";
            this.buttonOpenChatSerhii.Size = new System.Drawing.Size(139, 58);
            this.buttonOpenChatSerhii.TabIndex = 1;
            this.buttonOpenChatSerhii.Text = "Open chat as Serhii";
            this.buttonOpenChatSerhii.UseVisualStyleBackColor = true;
            this.buttonOpenChatSerhii.Click += new System.EventHandler(this.buttonOpenChatSerhii_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(325, 80);
            this.Controls.Add(this.buttonOpenChatSerhii);
            this.Controls.Add(this.buttonOpenChatOleksandr);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "MainForm";
            this.ShowIcon = false;
            this.Text = "Main Form";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button buttonOpenChatOleksandr;
        private System.Windows.Forms.Button buttonOpenChatSerhii;
    }
}

