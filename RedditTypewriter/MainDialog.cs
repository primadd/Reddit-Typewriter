using System;
using System.IO;
using System.Windows.Forms;

namespace RedditTypewriter
{
    public partial class MainDialog : Form
    {
        public MainDialog()
        {
            InitializeComponent();
        }

        private void MainDialog_Load(object sender, EventArgs e)
        {

        }

        private void aboutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            new AboutDialog().ShowDialog();
        }

        private void loadToolStripMenuItem_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog1 = new OpenFileDialog();
            openFileDialog1.Filter = "Text|*.txt";
            openFileDialog1.Title = "Load a Text File";
            openFileDialog1.ShowDialog();

            // check for empty filename
            if (openFileDialog1.FileName != "")
            {
                // load file
                using (var streamReader = new StreamReader(openFileDialog1.OpenFile()))
                {
                    redditTypewriterTextBox1.Text = streamReader.ReadToEnd();
                }
            }
        }

        private void saveToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SaveFileDialog saveFileDialog1 = new SaveFileDialog();
            saveFileDialog1.Filter = "Text|*.txt";
            saveFileDialog1.Title = "Save a Text File";
            saveFileDialog1.ShowDialog();

            // Don't save to empty filename
            if (saveFileDialog1.FileName != "")
            {
                // Save text to file
                using (var streamWriter = new StreamWriter(saveFileDialog1.OpenFile()))
                {
                    streamWriter.Write(redditTypewriterTextBox1.Text);
                }
            }
        }
    }
}
