using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Runtime.Serialization.Formatters.Binary;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BookProgram {
    public partial class CForm : Form {

        public List<Person_class> mass_person = new List<Person_class>();
        public List<Book_class> mass_book = new List<Book_class>();
        public string global_path_file = "default.bm";
        public Settings_class set = new Settings_class();
        private Point mouseOffset;
        private bool isMouseDown = false;
        bool bDragStatus;
        int temp_height_menu = 70;
        public static CForm selfref { get; set; }
        public CForm() {
            InitializeComponent();
            selfref = this;
            if (File.Exists("config")) {
                load_settings_is_file();
                build_settings();
            }
            else {
                create_default_settings_to_file();
                save_settings_to_file();
            }
        }
        #region Верхний бордюр
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
            Application.Exit();
        }
        #endregion
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
        private void resize_MouseDown(object sender, MouseEventArgs e)  {
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
        #region меню
        private void Persons_MouseHover(object sender, EventArgs e)
        {
            Persons.Image = Properties.Resources.с_персонажи;
        }
        private void Persons_Click(object sender, EventArgs e)
        {
            Body.Controls.Clear();
            Persons.Image = Properties.Resources.к_персонажи;
            Arxivper it = new Arxivper();
            it.Dock = DockStyle.Fill;
            Body.Controls.Add(it);
            Body.Controls.SetChildIndex(it, 0);
        }
        private void Persons_MouseLeave(object sender, EventArgs e)
        {
            Persons.Image = Properties.Resources.н_персонажи;
        }

        private void my_books_MouseHover(object sender, EventArgs e)
        {
            my_books.Image = Properties.Resources.с_книги;
        }     
        private void my_books_Click(object sender, EventArgs e)
        {
            Body.Controls.Clear();
            my_books.Image = Properties.Resources.к_книги;
            Mybooks it = new Mybooks();
            it.Dock = DockStyle.Fill;
            Body.Controls.Add(it);
            Body.Controls.SetChildIndex(it, 0);            
        }
        private void my_books_MouseLeave(object sender, EventArgs e)
        {
            my_books.Image = Properties.Resources.н_книги;
        }

        private void spravka_MouseHover(object sender, EventArgs e)
        {
            spravka.Image = Properties.Resources.с_справочники;
        }
        private void spravka_MouseLeave(object sender, EventArgs e)
        {
            spravka.Image = Properties.Resources.н_справочники;
        }
        private void spravka_Click(object sender, EventArgs e)
        {
            Body.Controls.Clear();
            spravka.Image = Properties.Resources.к_справочники;
            Spravochnik it = new Spravochnik();
            it.Dock = DockStyle.Fill;
            Body.Controls.Add(it);
            Body.Controls.SetChildIndex(it, 0);            
        }

        private void reader_MouseHover(object sender, EventArgs e)
        {
            reader.Image = Properties.Resources.c_читалка;
        }
        private void reader_MouseLeave(object sender, EventArgs e)
        {
            reader.Image = Properties.Resources.н_читалка;
        }
        private void reader_Click(object sender, EventArgs e)
        {
            Body.Controls.Clear();
            reader.Image = Properties.Resources.к_читалка;
            Reader it = new Reader();
            it.Dock = DockStyle.Fill;
            Body.Controls.Add(it);
            Body.Controls.SetChildIndex(it, 0);
        }

        private void perevod_MouseHover(object sender, EventArgs e)
        {
            perevod.Image = Properties.Resources.с_перевод;
        }
        private void perevod_MouseLeave(object sender, EventArgs e)
        {
            perevod.Image = Properties.Resources.н_перевод;
        }
        private void perevod_Click(object sender, EventArgs e)
        {
            Body.Controls.Clear();
            perevod.Image = Properties.Resources.к_перевод;
            MainTranslate it = new MainTranslate();
            it.Dock = DockStyle.Fill;
            Body.Controls.Add(it);
            Body.Controls.SetChildIndex(it, 0);
        }


        private void HideMenuBtn_Click(object sender, EventArgs e) {
            VisibleMenu.Visible = false;
            HideMenu.Visible = true;
            temp_height_menu = MainMenu.Height; 
            MainMenu.Height = HideMenu.Height;
        }
        private void ShowMenuBut_Click(object sender, EventArgs e) {
            VisibleMenu.Visible = true;
            HideMenu.Visible = false;
            MainMenu.Height = temp_height_menu;
        }
        private void setting_Click(object sender, EventArgs e) {
            Body.Controls.Clear();
            Settings it = new Settings();
            it.Dock = DockStyle.Fill;
            Body.Controls.Add(it);
            Body.Controls.SetChildIndex(it, 0);
        }
        #endregion
        #region работа с файлами
        public void save_to_file(string path) {
            Serialize s = new Serialize();
            s.persons = mass_person;
            s.books = mass_book;
            BinaryFormatter binFormat = new BinaryFormatter();
            using (Stream fStream = new FileStream(path, FileMode.Create, FileAccess.Write, FileShare.None)) {
                binFormat.Serialize(fStream, s);
                fStream.Close();
            }
        }
        public void load_is_file(string path) {
            if (File.Exists(path)) {
                System.IO.FileInfo file = new System.IO.FileInfo(path);
                    long size = file.Length;
                    if (size > 0) {
                        FileStream fs = new FileStream(path, FileMode.Open);
                        BinaryFormatter formatter = new BinaryFormatter();
                        Serialize load = new Serialize();
                        load = (Serialize)formatter.Deserialize(fs);
                        mass_person = load.persons;
                        mass_book = load.books;
                        fs.Close();
                    }
                }
        }
        public void save_settings_to_file() { 
            string temp = set.path_global_file + "\n" + set.height_form  + "\n" + set.width_form + "\n" + set.fullscreen.ToString();
            File.WriteAllText("config", temp, Encoding.UTF8);
        }
        public void load_settings_is_file() {
            string[] temp = File.ReadAllLines("config", Encoding.UTF8);
            set.path_global_file = temp[0];
            set.height_form = Convert.ToInt32(temp[1]);
            set.width_form = Convert.ToInt32(temp[2]);
            set.fullscreen = Convert.ToBoolean(temp[3]);
        }
        public void create_default_settings_to_file() {
            set.path_global_file = global_path_file;
            set.height_form = Height;
            set.width_form = Width;
            set.fullscreen = false;
        }
        public void build_settings() {
            global_path_file = set.path_global_file;
            Height = set.height_form;
            Width = set.width_form;
            if (set.fullscreen) WindowState = FormWindowState.Maximized;
        }
        #endregion
    } 
}
