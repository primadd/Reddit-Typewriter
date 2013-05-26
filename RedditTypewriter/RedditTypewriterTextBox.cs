using System;
using System.Windows.Forms;

namespace RedditTypewriter
{
    class RedditTypewriterTextBox : TextBox
    {
        protected override void OnKeyDown(KeyEventArgs e)
        {
            if ((e.KeyData & 
                (Keys.Up | Keys.Down | Keys.Left | Keys.Right |
                Keys.PageDown | Keys.PageUp | Keys.ControlKey |
                Keys.Control | Keys.Back)) != 0)
            {
                e.Handled = true;
            }

            base.OnKeyDown(e);
        }

        protected override void OnKeyPress(KeyPressEventArgs e)
        {
            if (e.KeyChar == '\b')
            {
                e.Handled = true;
            }
            base.OnKeyPress(e);
        }

        protected override void OnMouseClick(MouseEventArgs e)
        {
            this.SelectionStart = this.Text.Length;
            this.SelectionLength = 0;
            base.OnMouseClick(e);
        }

        protected override void OnMouseLeave(EventArgs e)
        {
            this.SelectionStart = this.Text.Length;
            this.SelectionLength = 0;
            base.OnMouseLeave(e);
        }
    }
}
