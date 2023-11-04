using System;
using System.Drawing;
using System.Windows.Forms;

namespace BookProgram
{
    public partial class CFormMessage : Form
    {
        private Point mouseOffset;
        private bool isMouseDown = false;
        public CFormMessage( string message )
        {
            InitializeComponent();
            content_form.Text = message;
        }
        public CFormMessage( string message, string cuption )
        {
            InitializeComponent();
            content_form.Text = message;
            name_form.Text = cuption;
        }
        private void Osnova_MouseDown( object sender, MouseEventArgs e )
        {
            int xOffset;
            int yOffset;
            if( e.Button == MouseButtons.Left )
            {
                xOffset = -e.X - SystemInformation.FrameBorderSize.Width;
                yOffset = -e.Y - SystemInformation.CaptionHeight -
                    SystemInformation.FrameBorderSize.Height;
                mouseOffset = new Point( xOffset, yOffset );
                isMouseDown = true;
            }
        }
        private void Osnova_MouseMove( object sender, MouseEventArgs e )
        {
            if( isMouseDown )
            {
                Point mousePos = Control.MousePosition;
                mousePos.Offset( mouseOffset.X, mouseOffset.Y );
                Location = mousePos;
            }
        }
        private void Osnova_MouseUp( object sender, MouseEventArgs e )
        {
            if( e.Button == MouseButtons.Left )
                isMouseDown = false;
        }


        private void pictureBox3_MouseHover( object sender, EventArgs e )
        {
            pictureBox3.Image = Properties.Resources.с_с_закрыть;
        }
        private void pictureBox3_MouseLeave( object sender, EventArgs e )
        {
            pictureBox3.Image = Properties.Resources.н_с_закрыть;
        }
        private void pictureBox3_Click( object sender, EventArgs e )
        {
            pictureBox3.Image = Properties.Resources.к_с_закрыть;
            Close();
        }
    }
}
