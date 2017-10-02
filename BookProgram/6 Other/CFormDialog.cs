using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BookProgram {
    public partial class CFormDialog : Form {
        private Point mouseOffset;
        private bool isMouseDown = false;
        bool bDragStatus;
        public static CFormDialog CRefDialog { get; set; }
        public CFormDialog(UserControl us) {
            InitializeComponent();
            CRefDialog = this;
            us.Dock = DockStyle.Fill;
            Body.Controls.Add(us);
            Body.Controls.SetChildIndex(us, 0);
        }
        public void set_header(string h) { caption.Text = h; } 
        public void CloseCFormDialog() { Close(); }
        public void CloseCFormDialog_and_SaveFile() {
            CForm.selfref.save_to_file(CForm.selfref.global_path_file);
            Close(); 
        }
        #region Трансформирование формы
        private void Osnova_MouseDown(object sender, MouseEventArgs e) {
            int xOffset;
            int yOffset;
            if (e.Button == MouseButtons.Left) {
                xOffset = -e.X - SystemInformation.FrameBorderSize.Width;
                yOffset = -e.Y - SystemInformation.CaptionHeight -
                    SystemInformation.FrameBorderSize.Height;
                mouseOffset = new Point(xOffset, yOffset);
                isMouseDown = true;
            }
        }
        private void Osnova_MouseMove(object sender, MouseEventArgs e) {
            if (isMouseDown) {
                Point mousePos = Control.MousePosition;
                mousePos.Offset(mouseOffset.X, mouseOffset.Y);
                Location = mousePos;
            }
        }
        private void Osnova_MouseUp(object sender, MouseEventArgs e) {
            if (e.Button == MouseButtons.Left)
                isMouseDown = false;
        }
        private void resize_MouseDown(object sender, MouseEventArgs e) {
            if (e.Button == MouseButtons.Left)
                bDragStatus = true;
        }
        private void resize_MouseMove(object sender, MouseEventArgs e) {
            if (bDragStatus)
                this.Size = new Size(this.PointToClient(MousePosition).X, this.PointToClient(MousePosition).Y);
        }
        private void resize_MouseUp(object sender, MouseEventArgs e) {
            bDragStatus = false;
        }
        #endregion
        #region верхний бар


        private void pictureBox3_MouseHover(object sender, EventArgs e)
        {
            pictureBox3.Image = Properties.Resources.с_с_закрыть;
        }
        private void pictureBox3_MouseLeave(object sender, EventArgs e)
        {
            pictureBox3.Image = Properties.Resources.н_с_закрыть;
        }
        private void pictureBox3_Click(object sender, EventArgs e)
        {
            pictureBox3.Image = Properties.Resources.к_с_закрыть;
            Close();
        }

        private void pictureBox5_MouseHover(object sender, EventArgs e)
        {
            pictureBox5.Image = Properties.Resources.с_с_свернуть;
        }
        private void pictureBox5_MouseLeave(object sender, EventArgs e)
        {
            pictureBox5.Image = Properties.Resources.н_с_свернуть;
        }
        private void pictureBox5_Click(object sender, EventArgs e)
        {
            pictureBox5.Image = Properties.Resources.к_с_свернуть;
            this.WindowState = FormWindowState.Minimized;
        }

        private void pictureBox4_MouseHover(object sender, EventArgs e)
        {
            pictureBox4.Image = Properties.Resources.с_с_развернуть;
        }
        private void pictureBox4_MouseLeave(object sender, EventArgs e)
        {
            pictureBox4.Image = Properties.Resources.н_с_развернуть;
        }
        private void pictureBox4_Click(object sender, EventArgs e)
        {
            pictureBox4.Image = Properties.Resources.к_с_развернуть;
            if (Screen.PrimaryScreen.Bounds == Bounds)
                WindowState = FormWindowState.Normal;
            else
                WindowState = FormWindowState.Maximized;
        }


        #endregion

        public void ChangeUserControlCFormDialog(UserControl us)
        {
            CRefDialog = this;
            us.Dock = DockStyle.Fill;
            Body.Controls.Add(us);
            Body.Controls.SetChildIndex(us, 0);
        }
    }
}
