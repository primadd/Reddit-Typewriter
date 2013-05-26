using System.Windows.Forms;

namespace RedditTypewriter
{
    public partial class AboutDialog : Form
    {
        public AboutDialog()
        {
            InitializeComponent();
        }

        private void redditRequestLinkLabel_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            System.Diagnostics.Process.Start(
                @"http://www.reddit.com/r/Favors/comments/1f2l85/request_programmer_with_basic_knowledge_of/"
                );
        }

        private void wantToHelpLinkLabel_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            System.Diagnostics.Process.Start(
                @"http://www.reddit.com/r/Favors/comments/1f18g5/request_please_help_me_translate_a_free_and/"
                );
        }

        private void redditTypewriteOnGithubLinkLabel_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            System.Diagnostics.Process.Start(
                @"https://github.com/primadd/Reddit-Typewriter"
                );
        }
    }
}
