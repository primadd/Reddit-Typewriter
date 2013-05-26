namespace RedditTypewriter
{
    partial class AboutDialog
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
            this.redditRequestLinkLabel = new System.Windows.Forms.LinkLabel();
            this.wantToHelpLinkLabel = new System.Windows.Forms.LinkLabel();
            this.redditTypewriteOnGithubLinkLabel = new System.Windows.Forms.LinkLabel();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // redditRequestLinkLabel
            // 
            this.redditRequestLinkLabel.AutoSize = true;
            this.redditRequestLinkLabel.Location = new System.Drawing.Point(12, 77);
            this.redditRequestLinkLabel.Name = "redditRequestLinkLabel";
            this.redditRequestLinkLabel.Size = new System.Drawing.Size(389, 13);
            this.redditRequestLinkLabel.TabIndex = 0;
            this.redditRequestLinkLabel.TabStop = true;
            this.redditRequestLinkLabel.Text = "[REQUEST] Programmer with basic knowledge of printer software and text editor.";
            this.redditRequestLinkLabel.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.redditRequestLinkLabel_LinkClicked);
            // 
            // wantToHelpLinkLabel
            // 
            this.wantToHelpLinkLabel.AutoSize = true;
            this.wantToHelpLinkLabel.Location = new System.Drawing.Point(12, 118);
            this.wantToHelpLinkLabel.Name = "wantToHelpLinkLabel";
            this.wantToHelpLinkLabel.Size = new System.Drawing.Size(459, 13);
            this.wantToHelpLinkLabel.TabIndex = 1;
            this.wantToHelpLinkLabel.TabStop = true;
            this.wantToHelpLinkLabel.Text = "[REQUEST] Please help me translate a free and simple app into as many languages a" +
    "s possible.";
            this.wantToHelpLinkLabel.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.wantToHelpLinkLabel_LinkClicked);
            // 
            // redditTypewriteOnGithubLinkLabel
            // 
            this.redditTypewriteOnGithubLinkLabel.AutoSize = true;
            this.redditTypewriteOnGithubLinkLabel.Location = new System.Drawing.Point(12, 38);
            this.redditTypewriteOnGithubLinkLabel.Name = "redditTypewriteOnGithubLinkLabel";
            this.redditTypewriteOnGithubLinkLabel.Size = new System.Drawing.Size(137, 13);
            this.redditTypewriteOnGithubLinkLabel.TabIndex = 2;
            this.redditTypewriteOnGithubLinkLabel.TabStop = true;
            this.redditTypewriteOnGithubLinkLabel.Text = "Reddit Typewriter on github";
            this.redditTypewriteOnGithubLinkLabel.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.redditTypewriteOnGithubLinkLabel_LinkClicked);
            // 
            // label1
            // 
            this.label1.Location = new System.Drawing.Point(13, 61);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Why?";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(16, 102);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(271, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "If you would like to help the author with his own request:";
            // 
            // About
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(554, 165);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.redditTypewriteOnGithubLinkLabel);
            this.Controls.Add(this.wantToHelpLinkLabel);
            this.Controls.Add(this.redditRequestLinkLabel);
            this.Name = "About";
            this.Text = "About";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.LinkLabel redditRequestLinkLabel;
        private System.Windows.Forms.LinkLabel wantToHelpLinkLabel;
        private System.Windows.Forms.LinkLabel redditTypewriteOnGithubLinkLabel;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
    }
}