namespace BookProgram
{
    partial class Mybooks
    {
        /// <summary> 
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором компонентов

        /// <summary> 
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.panel1 = new System.Windows.Forms.Panel();
            this.mybook = new System.Windows.Forms.ListBox();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.удалитьВыбраннуюКнигуToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.panel2 = new System.Windows.Forms.Panel();
            this.newbook = new System.Windows.Forms.PictureBox();
            this.kniga = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.oglav = new System.Windows.Forms.Panel();
            this.oglavknigi = new System.Windows.Forms.ListBox();
            this.label1 = new System.Windows.Forms.Label();
            this.panel4 = new System.Windows.Forms.Panel();
            this.oknige = new System.Windows.Forms.Panel();
            this.VisibleMenu = new System.Windows.Forms.Panel();
            this.content_book = new System.Windows.Forms.Panel();
            this.обложка = new System.Windows.Forms.PictureBox();
            this.о_книге = new System.Windows.Forms.TextBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.жанр = new System.Windows.Forms.ComboBox();
            this.название = new System.Windows.Forms.TextBox();
            this.DocMenu = new System.Windows.Forms.Panel();
            this.HideMenuBtn = new System.Windows.Forms.PictureBox();
            this.HideMenu = new System.Windows.Forms.Panel();
            this.ShowMenuBut = new System.Windows.Forms.PictureBox();
            this.panel5 = new System.Windows.Forms.Panel();
            this.word = new System.Windows.Forms.PictureBox();
            this.foto = new System.Windows.Forms.PictureBox();
            this.locacii = new System.Windows.Forms.PictureBox();
            this.vtorpers = new System.Windows.Forms.PictureBox();
            this.glavpers = new System.Windows.Forms.PictureBox();
            this.newcharper = new System.Windows.Forms.PictureBox();
            this.panel1.SuspendLayout();
            this.contextMenuStrip1.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.newbook)).BeginInit();
            this.kniga.SuspendLayout();
            this.panel3.SuspendLayout();
            this.oglav.SuspendLayout();
            this.oknige.SuspendLayout();
            this.VisibleMenu.SuspendLayout();
            this.content_book.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.обложка)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.DocMenu.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.HideMenuBtn)).BeginInit();
            this.HideMenu.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ShowMenuBut)).BeginInit();
            this.panel5.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.word)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.foto)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.locacii)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.vtorpers)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.glavpers)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.newcharper)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Transparent;
            this.panel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panel1.Controls.Add(this.mybook);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(163, 815);
            this.panel1.TabIndex = 0;
            // 
            // mybook
            // 
            this.mybook.ContextMenuStrip = this.contextMenuStrip1;
            this.mybook.Dock = System.Windows.Forms.DockStyle.Fill;
            this.mybook.Font = new System.Drawing.Font("Monotype Corsiva", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.mybook.FormattingEnabled = true;
            this.mybook.ItemHeight = 18;
            this.mybook.Location = new System.Drawing.Point(0, 0);
            this.mybook.Name = "mybook";
            this.mybook.Size = new System.Drawing.Size(163, 815);
            this.mybook.TabIndex = 2;
            this.mybook.SelectedIndexChanged += new System.EventHandler(this.mybook_SelectedIndexChanged);
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.удалитьВыбраннуюКнигуToolStripMenuItem});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(221, 26);
            // 
            // удалитьВыбраннуюКнигуToolStripMenuItem
            // 
            this.удалитьВыбраннуюКнигуToolStripMenuItem.Name = "удалитьВыбраннуюКнигуToolStripMenuItem";
            this.удалитьВыбраннуюКнигуToolStripMenuItem.Size = new System.Drawing.Size(220, 22);
            this.удалитьВыбраннуюКнигуToolStripMenuItem.Text = "Удалить выбранную книгу";
            this.удалитьВыбраннуюКнигуToolStripMenuItem.Click += new System.EventHandler(this.удалитьВыбраннуюКнигуToolStripMenuItem_Click);
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.newbook);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(163, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(956, 40);
            this.panel2.TabIndex = 1;
            // 
            // newbook
            // 
            this.newbook.BackgroundImage = global::BookProgram.Properties.Resources.новая_книга;
            this.newbook.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.newbook.Dock = System.Windows.Forms.DockStyle.Left;
            this.newbook.Location = new System.Drawing.Point(0, 0);
            this.newbook.Name = "newbook";
            this.newbook.Size = new System.Drawing.Size(40, 40);
            this.newbook.TabIndex = 0;
            this.newbook.TabStop = false;
            this.newbook.Click += new System.EventHandler(this.newbook_Click);
            this.newbook.MouseLeave += new System.EventHandler(this.newbook_MouseLeave);
            this.newbook.MouseHover += new System.EventHandler(this.newbook_MouseHover);
            // 
            // kniga
            // 
            this.kniga.Controls.Add(this.panel3);
            this.kniga.Controls.Add(this.panel5);
            this.kniga.Dock = System.Windows.Forms.DockStyle.Fill;
            this.kniga.Location = new System.Drawing.Point(163, 40);
            this.kniga.Name = "kniga";
            this.kniga.Size = new System.Drawing.Size(956, 775);
            this.kniga.TabIndex = 2;
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.oglav);
            this.panel3.Controls.Add(this.oknige);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel3.Location = new System.Drawing.Point(43, 0);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(913, 804);
            this.panel3.TabIndex = 2;
            // 
            // oglav
            // 
            this.oglav.Controls.Add(this.oglavknigi);
            this.oglav.Controls.Add(this.label1);
            this.oglav.Controls.Add(this.panel4);
            this.oglav.Dock = System.Windows.Forms.DockStyle.Fill;
            this.oglav.Location = new System.Drawing.Point(0, 376);
            this.oglav.Name = "oglav";
            this.oglav.Size = new System.Drawing.Size(913, 428);
            this.oglav.TabIndex = 1;
            // 
            // oglavknigi
            // 
            this.oglavknigi.ContextMenuStrip = this.contextMenuStrip1;
            this.oglavknigi.Dock = System.Windows.Forms.DockStyle.Fill;
            this.oglavknigi.Font = new System.Drawing.Font("Monotype Corsiva", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.oglavknigi.FormattingEnabled = true;
            this.oglavknigi.ItemHeight = 18;
            this.oglavknigi.Location = new System.Drawing.Point(0, 25);
            this.oglavknigi.Name = "oglavknigi";
            this.oglavknigi.Size = new System.Drawing.Size(893, 403);
            this.oglavknigi.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.Dock = System.Windows.Forms.DockStyle.Top;
            this.label1.Font = new System.Drawing.Font("Monotype Corsiva", 15.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(0, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(893, 25);
            this.label1.TabIndex = 1;
            this.label1.Text = "ОГЛАВЛЕНИЕ";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // panel4
            // 
            this.panel4.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel4.Location = new System.Drawing.Point(893, 0);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(20, 428);
            this.panel4.TabIndex = 2;
            // 
            // oknige
            // 
            this.oknige.Controls.Add(this.VisibleMenu);
            this.oknige.Controls.Add(this.HideMenu);
            this.oknige.Dock = System.Windows.Forms.DockStyle.Top;
            this.oknige.Location = new System.Drawing.Point(0, 0);
            this.oknige.Name = "oknige";
            this.oknige.Size = new System.Drawing.Size(913, 376);
            this.oknige.TabIndex = 0;
            // 
            // VisibleMenu
            // 
            this.VisibleMenu.Controls.Add(this.content_book);
            this.VisibleMenu.Controls.Add(this.DocMenu);
            this.VisibleMenu.Dock = System.Windows.Forms.DockStyle.Fill;
            this.VisibleMenu.Location = new System.Drawing.Point(0, 0);
            this.VisibleMenu.Name = "VisibleMenu";
            this.VisibleMenu.Size = new System.Drawing.Size(913, 366);
            this.VisibleMenu.TabIndex = 12;
            // 
            // content_book
            // 
            this.content_book.Controls.Add(this.обложка);
            this.content_book.Controls.Add(this.о_книге);
            this.content_book.Controls.Add(this.pictureBox2);
            this.content_book.Controls.Add(this.жанр);
            this.content_book.Controls.Add(this.название);
            this.content_book.Dock = System.Windows.Forms.DockStyle.Fill;
            this.content_book.Location = new System.Drawing.Point(0, 0);
            this.content_book.Name = "content_book";
            this.content_book.Size = new System.Drawing.Size(893, 366);
            this.content_book.TabIndex = 31;
            // 
            // обложка
            // 
            this.обложка.BackgroundImage = global::BookProgram.Properties.Resources.Для_пикчербоксов;
            this.обложка.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.обложка.Location = new System.Drawing.Point(28, 6);
            this.обложка.Name = "обложка";
            this.обложка.Size = new System.Drawing.Size(249, 319);
            this.обложка.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.обложка.TabIndex = 2;
            this.обложка.TabStop = false;
            // 
            // о_книге
            // 
            this.о_книге.BackColor = System.Drawing.Color.GhostWhite;
            this.о_книге.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.о_книге.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.о_книге.Font = new System.Drawing.Font("Monotype Corsiva", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.о_книге.ForeColor = System.Drawing.Color.Black;
            this.о_книге.Location = new System.Drawing.Point(296, 50);
            this.о_книге.Multiline = true;
            this.о_книге.Name = "о_книге";
            this.о_книге.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.о_книге.Size = new System.Drawing.Size(432, 307);
            this.о_книге.TabIndex = 29;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = global::BookProgram.Properties.Resources.Изменить;
            this.pictureBox2.Location = new System.Drawing.Point(669, 16);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(25, 25);
            this.pictureBox2.TabIndex = 29;
            this.pictureBox2.TabStop = false;
            // 
            // жанр
            // 
            this.жанр.Font = new System.Drawing.Font("Monotype Corsiva", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.жанр.FormattingEnabled = true;
            this.жанр.Items.AddRange(new object[] {
            "Не выбрано",
            "Современный роман",
            "Исторический роман",
            "Фэнтези",
            "Фантастика",
            "Попаданцы",
            "Ужасы, мистика",
            "Детектив",
            "Антиутопия",
            "Драма"});
            this.жанр.Location = new System.Drawing.Point(47, 331);
            this.жанр.Name = "жанр";
            this.жанр.Size = new System.Drawing.Size(215, 26);
            this.жанр.TabIndex = 0;
            // 
            // название
            // 
            this.название.BackColor = System.Drawing.Color.GhostWhite;
            this.название.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.название.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.название.Font = new System.Drawing.Font("Monotype Corsiva", 20.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.название.ForeColor = System.Drawing.Color.Black;
            this.название.Location = new System.Drawing.Point(317, 17);
            this.название.Multiline = true;
            this.название.Name = "название";
            this.название.Size = new System.Drawing.Size(346, 24);
            this.название.TabIndex = 28;
            this.название.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // DocMenu
            // 
            this.DocMenu.BackColor = System.Drawing.Color.Transparent;
            this.DocMenu.Controls.Add(this.HideMenuBtn);
            this.DocMenu.Dock = System.Windows.Forms.DockStyle.Right;
            this.DocMenu.Location = new System.Drawing.Point(893, 0);
            this.DocMenu.Name = "DocMenu";
            this.DocMenu.Size = new System.Drawing.Size(20, 366);
            this.DocMenu.TabIndex = 11;
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
            // 
            // HideMenu
            // 
            this.HideMenu.BackColor = System.Drawing.Color.Transparent;
            this.HideMenu.Controls.Add(this.ShowMenuBut);
            this.HideMenu.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.HideMenu.Location = new System.Drawing.Point(0, 366);
            this.HideMenu.Name = "HideMenu";
            this.HideMenu.Size = new System.Drawing.Size(913, 10);
            this.HideMenu.TabIndex = 10;
            this.HideMenu.Visible = false;
            // 
            // ShowMenuBut
            // 
            this.ShowMenuBut.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.ShowMenuBut.Image = global::BookProgram.Properties.Resources.menud;
            this.ShowMenuBut.Location = new System.Drawing.Point(0, 0);
            this.ShowMenuBut.Name = "ShowMenuBut";
            this.ShowMenuBut.Size = new System.Drawing.Size(913, 10);
            this.ShowMenuBut.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.ShowMenuBut.TabIndex = 0;
            this.ShowMenuBut.TabStop = false;
            // 
            // panel5
            // 
            this.panel5.Controls.Add(this.word);
            this.panel5.Controls.Add(this.foto);
            this.panel5.Controls.Add(this.locacii);
            this.panel5.Controls.Add(this.vtorpers);
            this.panel5.Controls.Add(this.glavpers);
            this.panel5.Controls.Add(this.newcharper);
            this.panel5.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel5.Location = new System.Drawing.Point(0, 0);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(43, 775);
            this.panel5.TabIndex = 3;
            // 
            // word
            // 
            this.word.BackgroundImage = global::BookProgram.Properties.Resources.ворд;
            this.word.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.word.Dock = System.Windows.Forms.DockStyle.Top;
            this.word.Location = new System.Drawing.Point(0, 200);
            this.word.Name = "word";
            this.word.Size = new System.Drawing.Size(43, 40);
            this.word.TabIndex = 10;
            this.word.TabStop = false;
            // 
            // foto
            // 
            this.foto.BackgroundImage = global::BookProgram.Properties.Resources.фото_перс;
            this.foto.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.foto.Dock = System.Windows.Forms.DockStyle.Top;
            this.foto.Location = new System.Drawing.Point(0, 160);
            this.foto.Name = "foto";
            this.foto.Size = new System.Drawing.Size(43, 40);
            this.foto.TabIndex = 11;
            this.foto.TabStop = false;
            // 
            // locacii
            // 
            this.locacii.BackgroundImage = global::BookProgram.Properties.Resources.локации;
            this.locacii.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.locacii.Dock = System.Windows.Forms.DockStyle.Top;
            this.locacii.Location = new System.Drawing.Point(0, 120);
            this.locacii.Name = "locacii";
            this.locacii.Size = new System.Drawing.Size(43, 40);
            this.locacii.TabIndex = 12;
            this.locacii.TabStop = false;
            // 
            // vtorpers
            // 
            this.vtorpers.BackgroundImage = global::BookProgram.Properties.Resources.остальные_персонажи;
            this.vtorpers.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.vtorpers.Dock = System.Windows.Forms.DockStyle.Top;
            this.vtorpers.Location = new System.Drawing.Point(0, 80);
            this.vtorpers.Name = "vtorpers";
            this.vtorpers.Size = new System.Drawing.Size(43, 40);
            this.vtorpers.TabIndex = 9;
            this.vtorpers.TabStop = false;
            // 
            // glavpers
            // 
            this.glavpers.BackgroundImage = global::BookProgram.Properties.Resources.главный_персонаж;
            this.glavpers.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.glavpers.Dock = System.Windows.Forms.DockStyle.Top;
            this.glavpers.Location = new System.Drawing.Point(0, 40);
            this.glavpers.Name = "glavpers";
            this.glavpers.Size = new System.Drawing.Size(43, 40);
            this.glavpers.TabIndex = 8;
            this.glavpers.TabStop = false;
            // 
            // newcharper
            // 
            this.newcharper.BackgroundImage = global::BookProgram.Properties.Resources.новая_глава;
            this.newcharper.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.newcharper.Dock = System.Windows.Forms.DockStyle.Top;
            this.newcharper.Location = new System.Drawing.Point(0, 0);
            this.newcharper.Name = "newcharper";
            this.newcharper.Size = new System.Drawing.Size(43, 40);
            this.newcharper.TabIndex = 7;
            this.newcharper.TabStop = false;
            // 
            // Mybooks
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Transparent;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.Controls.Add(this.kniga);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Name = "Mybooks";
            this.Size = new System.Drawing.Size(1119, 815);
            this.panel1.ResumeLayout(false);
            this.contextMenuStrip1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.newbook)).EndInit();
            this.kniga.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.oglav.ResumeLayout(false);
            this.oknige.ResumeLayout(false);
            this.VisibleMenu.ResumeLayout(false);
            this.content_book.ResumeLayout(false);
            this.content_book.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.обложка)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.DocMenu.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.HideMenuBtn)).EndInit();
            this.HideMenu.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.ShowMenuBut)).EndInit();
            this.panel5.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.word)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.foto)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.locacii)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.vtorpers)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.glavpers)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.newcharper)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.PictureBox newbook;
        private System.Windows.Forms.Panel kniga;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem удалитьВыбраннуюКнигуToolStripMenuItem;
        public System.Windows.Forms.ListBox mybook;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel oglav;
        public System.Windows.Forms.ListBox oglavknigi;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Panel oknige;
        public System.Windows.Forms.Panel VisibleMenu;
        private System.Windows.Forms.Panel content_book;
        private System.Windows.Forms.PictureBox обложка;
        private System.Windows.Forms.TextBox о_книге;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.ComboBox жанр;
        private System.Windows.Forms.TextBox название;
        private System.Windows.Forms.Panel DocMenu;
        private System.Windows.Forms.PictureBox HideMenuBtn;
        private System.Windows.Forms.Panel HideMenu;
        private System.Windows.Forms.PictureBox ShowMenuBut;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.PictureBox word;
        private System.Windows.Forms.PictureBox foto;
        private System.Windows.Forms.PictureBox locacii;
        private System.Windows.Forms.PictureBox vtorpers;
        private System.Windows.Forms.PictureBox glavpers;
        private System.Windows.Forms.PictureBox newcharper;
    }
}
