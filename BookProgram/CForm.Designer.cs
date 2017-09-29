namespace BookProgram
{
    partial class CForm
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
            this.BottomBar = new System.Windows.Forms.Panel();
            this.resizeForm = new System.Windows.Forms.PictureBox();
            this.MainMenu = new System.Windows.Forms.Panel();
            this.HideMenu = new System.Windows.Forms.Panel();
            this.ShowMenuBut = new System.Windows.Forms.PictureBox();
            this.VisibleMenu = new System.Windows.Forms.Panel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.setting = new System.Windows.Forms.PictureBox();
            this.DocMenu = new System.Windows.Forms.Panel();
            this.HideMenuBtn = new System.Windows.Forms.PictureBox();
            this.reader = new System.Windows.Forms.PictureBox();
            this.perevod = new System.Windows.Forms.PictureBox();
            this.spravka = new System.Windows.Forms.PictureBox();
            this.my_books = new System.Windows.Forms.PictureBox();
            this.Persons = new System.Windows.Forms.PictureBox();
            this.TopBar = new System.Windows.Forms.Panel();
            this.pictureBox5 = new System.Windows.Forms.PictureBox();
            this.pictureBox4 = new System.Windows.Forms.PictureBox();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.Body = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.BottomBar.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.resizeForm)).BeginInit();
            this.MainMenu.SuspendLayout();
            this.HideMenu.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ShowMenuBut)).BeginInit();
            this.VisibleMenu.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.setting)).BeginInit();
            this.DocMenu.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.HideMenuBtn)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.reader)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.perevod)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.spravka)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.my_books)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Persons)).BeginInit();
            this.TopBar.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // BottomBar
            // 
            this.BottomBar.BackColor = System.Drawing.Color.Transparent;
            this.BottomBar.Controls.Add(this.resizeForm);
            this.BottomBar.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.BottomBar.Location = new System.Drawing.Point(0, 651);
            this.BottomBar.Name = "BottomBar";
            this.BottomBar.Size = new System.Drawing.Size(783, 16);
            this.BottomBar.TabIndex = 8;
            // 
            // resizeForm
            // 
            this.resizeForm.Dock = System.Windows.Forms.DockStyle.Right;
            this.resizeForm.Image = global::BookProgram.Properties.Resources.triangle;
            this.resizeForm.Location = new System.Drawing.Point(767, 0);
            this.resizeForm.Name = "resizeForm";
            this.resizeForm.Size = new System.Drawing.Size(16, 16);
            this.resizeForm.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.resizeForm.TabIndex = 0;
            this.resizeForm.TabStop = false;
            this.resizeForm.MouseDown += new System.Windows.Forms.MouseEventHandler(this.resize_MouseDown);
            this.resizeForm.MouseMove += new System.Windows.Forms.MouseEventHandler(this.resize_MouseMove);
            this.resizeForm.MouseUp += new System.Windows.Forms.MouseEventHandler(this.resize_MouseUp);
            // 
            // MainMenu
            // 
            this.MainMenu.BackColor = System.Drawing.Color.Transparent;
            this.MainMenu.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.MainMenu.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.MainMenu.Controls.Add(this.HideMenu);
            this.MainMenu.Controls.Add(this.VisibleMenu);
            this.MainMenu.Dock = System.Windows.Forms.DockStyle.Top;
            this.MainMenu.Location = new System.Drawing.Point(0, 25);
            this.MainMenu.Name = "MainMenu";
            this.MainMenu.Size = new System.Drawing.Size(783, 70);
            this.MainMenu.TabIndex = 7;
            // 
            // HideMenu
            // 
            this.HideMenu.BackColor = System.Drawing.Color.Transparent;
            this.HideMenu.Controls.Add(this.ShowMenuBut);
            this.HideMenu.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.HideMenu.Location = new System.Drawing.Point(0, 58);
            this.HideMenu.Name = "HideMenu";
            this.HideMenu.Size = new System.Drawing.Size(781, 10);
            this.HideMenu.TabIndex = 9;
            this.HideMenu.Visible = false;
            // 
            // ShowMenuBut
            // 
            this.ShowMenuBut.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.ShowMenuBut.Image = global::BookProgram.Properties.Resources.menud;
            this.ShowMenuBut.Location = new System.Drawing.Point(0, 0);
            this.ShowMenuBut.Name = "ShowMenuBut";
            this.ShowMenuBut.Size = new System.Drawing.Size(781, 10);
            this.ShowMenuBut.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.ShowMenuBut.TabIndex = 0;
            this.ShowMenuBut.TabStop = false;
            this.ShowMenuBut.Click += new System.EventHandler(this.ShowMenuBut_Click);
            // 
            // VisibleMenu
            // 
            this.VisibleMenu.BackColor = System.Drawing.Color.Transparent;
            this.VisibleMenu.Controls.Add(this.panel1);
            this.VisibleMenu.Controls.Add(this.DocMenu);
            this.VisibleMenu.Controls.Add(this.reader);
            this.VisibleMenu.Controls.Add(this.perevod);
            this.VisibleMenu.Controls.Add(this.spravka);
            this.VisibleMenu.Controls.Add(this.my_books);
            this.VisibleMenu.Controls.Add(this.Persons);
            this.VisibleMenu.Dock = System.Windows.Forms.DockStyle.Fill;
            this.VisibleMenu.ForeColor = System.Drawing.Color.Black;
            this.VisibleMenu.Location = new System.Drawing.Point(0, 0);
            this.VisibleMenu.Name = "VisibleMenu";
            this.VisibleMenu.Size = new System.Drawing.Size(781, 68);
            this.VisibleMenu.TabIndex = 8;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Controls.Add(this.setting);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(375, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(386, 35);
            this.panel1.TabIndex = 9;
            // 
            // setting
            // 
            this.setting.BackgroundImage = global::BookProgram.Properties.Resources.настройки;
            this.setting.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.setting.Dock = System.Windows.Forms.DockStyle.Left;
            this.setting.Location = new System.Drawing.Point(0, 0);
            this.setting.Name = "setting";
            this.setting.Size = new System.Drawing.Size(35, 35);
            this.setting.TabIndex = 0;
            this.setting.TabStop = false;
            this.setting.Click += new System.EventHandler(this.setting_Click);
            // 
            // DocMenu
            // 
            this.DocMenu.BackColor = System.Drawing.Color.Transparent;
            this.DocMenu.Controls.Add(this.HideMenuBtn);
            this.DocMenu.Dock = System.Windows.Forms.DockStyle.Right;
            this.DocMenu.Location = new System.Drawing.Point(761, 0);
            this.DocMenu.Name = "DocMenu";
            this.DocMenu.Size = new System.Drawing.Size(20, 68);
            this.DocMenu.TabIndex = 8;
            // 
            // HideMenuBtn
            // 
            this.HideMenuBtn.Dock = System.Windows.Forms.DockStyle.Top;
            this.HideMenuBtn.Image = global::BookProgram.Properties.Resources.hide;
            this.HideMenuBtn.Location = new System.Drawing.Point(0, 0);
            this.HideMenuBtn.Name = "HideMenuBtn";
            this.HideMenuBtn.Size = new System.Drawing.Size(20, 20);
            this.HideMenuBtn.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.HideMenuBtn.TabIndex = 0;
            this.HideMenuBtn.TabStop = false;
            this.HideMenuBtn.Click += new System.EventHandler(this.HideMenuBtn_Click);
            // 
            // reader
            // 
            this.reader.BackColor = System.Drawing.Color.Transparent;
            this.reader.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.reader.Dock = System.Windows.Forms.DockStyle.Left;
            this.reader.Image = global::BookProgram.Properties.Resources.н_читалка;
            this.reader.Location = new System.Drawing.Point(300, 0);
            this.reader.Name = "reader";
            this.reader.Size = new System.Drawing.Size(75, 68);
            this.reader.TabIndex = 6;
            this.reader.TabStop = false;
            this.reader.Click += new System.EventHandler(this.reader_Click);
            this.reader.MouseLeave += new System.EventHandler(this.reader_MouseLeave);
            this.reader.MouseHover += new System.EventHandler(this.reader_MouseHover);
            // 
            // perevod
            // 
            this.perevod.BackColor = System.Drawing.Color.Transparent;
            this.perevod.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.perevod.Dock = System.Windows.Forms.DockStyle.Left;
            this.perevod.Image = global::BookProgram.Properties.Resources.н_перевод;
            this.perevod.Location = new System.Drawing.Point(225, 0);
            this.perevod.Margin = new System.Windows.Forms.Padding(5);
            this.perevod.Name = "perevod";
            this.perevod.Size = new System.Drawing.Size(75, 68);
            this.perevod.TabIndex = 3;
            this.perevod.TabStop = false;
            this.perevod.Click += new System.EventHandler(this.perevod_Click);
            this.perevod.MouseLeave += new System.EventHandler(this.perevod_MouseLeave);
            this.perevod.MouseHover += new System.EventHandler(this.perevod_MouseHover);
            // 
            // spravka
            // 
            this.spravka.BackColor = System.Drawing.Color.Transparent;
            this.spravka.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.spravka.Dock = System.Windows.Forms.DockStyle.Left;
            this.spravka.Image = global::BookProgram.Properties.Resources.н_справочники;
            this.spravka.Location = new System.Drawing.Point(150, 0);
            this.spravka.Name = "spravka";
            this.spravka.Size = new System.Drawing.Size(75, 68);
            this.spravka.TabIndex = 7;
            this.spravka.TabStop = false;
            this.spravka.Click += new System.EventHandler(this.spravka_Click);
            this.spravka.MouseLeave += new System.EventHandler(this.spravka_MouseLeave);
            this.spravka.MouseHover += new System.EventHandler(this.spravka_MouseHover);
            // 
            // my_books
            // 
            this.my_books.BackColor = System.Drawing.Color.Transparent;
            this.my_books.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.my_books.Dock = System.Windows.Forms.DockStyle.Left;
            this.my_books.Image = global::BookProgram.Properties.Resources.н_книги;
            this.my_books.Location = new System.Drawing.Point(75, 0);
            this.my_books.Margin = new System.Windows.Forms.Padding(5);
            this.my_books.Name = "my_books";
            this.my_books.Size = new System.Drawing.Size(75, 68);
            this.my_books.TabIndex = 2;
            this.my_books.TabStop = false;
            this.my_books.Click += new System.EventHandler(this.my_books_Click);
            this.my_books.MouseLeave += new System.EventHandler(this.my_books_MouseLeave);
            this.my_books.MouseHover += new System.EventHandler(this.my_books_MouseHover);
            // 
            // Persons
            // 
            this.Persons.BackColor = System.Drawing.Color.Transparent;
            this.Persons.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.Persons.Dock = System.Windows.Forms.DockStyle.Left;
            this.Persons.Image = global::BookProgram.Properties.Resources.н_персонажи;
            this.Persons.Location = new System.Drawing.Point(0, 0);
            this.Persons.Margin = new System.Windows.Forms.Padding(20);
            this.Persons.Name = "Persons";
            this.Persons.Size = new System.Drawing.Size(75, 68);
            this.Persons.TabIndex = 5;
            this.Persons.TabStop = false;
            this.Persons.Click += new System.EventHandler(this.Persons_Click);
            this.Persons.MouseLeave += new System.EventHandler(this.Persons_MouseLeave);
            this.Persons.MouseHover += new System.EventHandler(this.Persons_MouseHover);
            // 
            // TopBar
            // 
            this.TopBar.BackColor = System.Drawing.Color.Transparent;
            this.TopBar.Controls.Add(this.pictureBox5);
            this.TopBar.Controls.Add(this.pictureBox4);
            this.TopBar.Controls.Add(this.pictureBox3);
            this.TopBar.Controls.Add(this.pictureBox2);
            this.TopBar.Dock = System.Windows.Forms.DockStyle.Top;
            this.TopBar.Location = new System.Drawing.Point(0, 0);
            this.TopBar.Name = "TopBar";
            this.TopBar.Size = new System.Drawing.Size(783, 25);
            this.TopBar.TabIndex = 6;
            this.TopBar.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Osnova_MouseDown);
            this.TopBar.MouseMove += new System.Windows.Forms.MouseEventHandler(this.Osnova_MouseMove);
            this.TopBar.MouseUp += new System.Windows.Forms.MouseEventHandler(this.Osnova_MouseUp);
            // 
            // pictureBox5
            // 
            this.pictureBox5.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox5.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.pictureBox5.Dock = System.Windows.Forms.DockStyle.Right;
            this.pictureBox5.Image = global::BookProgram.Properties.Resources.н_с_свернуть;
            this.pictureBox5.Location = new System.Drawing.Point(708, 0);
            this.pictureBox5.Name = "pictureBox5";
            this.pictureBox5.Size = new System.Drawing.Size(25, 25);
            this.pictureBox5.TabIndex = 2;
            this.pictureBox5.TabStop = false;
            this.pictureBox5.Click += new System.EventHandler(this.pictureBox5_Click);
            this.pictureBox5.MouseLeave += new System.EventHandler(this.pictureBox5_MouseLeave);
            this.pictureBox5.MouseHover += new System.EventHandler(this.pictureBox5_MouseHover);
            // 
            // pictureBox4
            // 
            this.pictureBox4.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox4.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.pictureBox4.Dock = System.Windows.Forms.DockStyle.Right;
            this.pictureBox4.Image = global::BookProgram.Properties.Resources.н_с_развернуть;
            this.pictureBox4.Location = new System.Drawing.Point(733, 0);
            this.pictureBox4.Name = "pictureBox4";
            this.pictureBox4.Size = new System.Drawing.Size(25, 25);
            this.pictureBox4.TabIndex = 2;
            this.pictureBox4.TabStop = false;
            this.pictureBox4.Click += new System.EventHandler(this.pictureBox4_Click);
            this.pictureBox4.MouseLeave += new System.EventHandler(this.pictureBox4_MouseLeave);
            this.pictureBox4.MouseHover += new System.EventHandler(this.pictureBox4_MouseHover);
            // 
            // pictureBox3
            // 
            this.pictureBox3.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.pictureBox3.Dock = System.Windows.Forms.DockStyle.Right;
            this.pictureBox3.Image = global::BookProgram.Properties.Resources.н_с_закрыть;
            this.pictureBox3.Location = new System.Drawing.Point(758, 0);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(25, 25);
            this.pictureBox3.TabIndex = 2;
            this.pictureBox3.TabStop = false;
            this.pictureBox3.Click += new System.EventHandler(this.pictureBox3_Click);
            this.pictureBox3.MouseLeave += new System.EventHandler(this.pictureBox3_MouseLeave);
            this.pictureBox3.MouseHover += new System.EventHandler(this.pictureBox3_MouseHover);
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox2.Dock = System.Windows.Forms.DockStyle.Left;
            this.pictureBox2.Image = global::BookProgram.Properties.Resources.Имя;
            this.pictureBox2.Location = new System.Drawing.Point(0, 0);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(107, 25);
            this.pictureBox2.TabIndex = 2;
            this.pictureBox2.TabStop = false;
            // 
            // Body
            // 
            this.Body.BackColor = System.Drawing.Color.Transparent;
            this.Body.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Body.Location = new System.Drawing.Point(0, 95);
            this.Body.Name = "Body";
            this.Body.Size = new System.Drawing.Size(783, 556);
            this.Body.TabIndex = 9;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Salmon;
            this.pictureBox1.Dock = System.Windows.Forms.DockStyle.Right;
            this.pictureBox1.Location = new System.Drawing.Point(351, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(35, 35);
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // CForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::BookProgram.Properties.Resources.Основной_фон;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(783, 667);
            this.Controls.Add(this.Body);
            this.Controls.Add(this.BottomBar);
            this.Controls.Add(this.MainMenu);
            this.Controls.Add(this.TopBar);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "CForm";
            this.Text = "CForm";
            this.BottomBar.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.resizeForm)).EndInit();
            this.MainMenu.ResumeLayout(false);
            this.HideMenu.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.ShowMenuBut)).EndInit();
            this.VisibleMenu.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.setting)).EndInit();
            this.DocMenu.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.HideMenuBtn)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.reader)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.perevod)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.spravka)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.my_books)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Persons)).EndInit();
            this.TopBar.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel MainMenu;
        private System.Windows.Forms.Panel BottomBar;
        private System.Windows.Forms.Panel TopBar;
        private System.Windows.Forms.PictureBox pictureBox5;
        private System.Windows.Forms.PictureBox pictureBox4;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.PictureBox resizeForm;
        public System.Windows.Forms.Panel Body;
        private System.Windows.Forms.Panel HideMenu;
        private System.Windows.Forms.Panel VisibleMenu;
        private System.Windows.Forms.PictureBox ShowMenuBut;
        private System.Windows.Forms.Panel DocMenu;
        private System.Windows.Forms.PictureBox HideMenuBtn;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox setting;
        public System.Windows.Forms.PictureBox perevod;
        public System.Windows.Forms.PictureBox reader;
        public System.Windows.Forms.PictureBox spravka;
        public System.Windows.Forms.PictureBox my_books;
        public System.Windows.Forms.PictureBox Persons;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}