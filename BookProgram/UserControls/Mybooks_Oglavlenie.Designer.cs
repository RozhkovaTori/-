namespace BookProgram
{
    partial class Mybooks_Oglavlenie
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
            this.word = new System.Windows.Forms.PictureBox();
            this.foto = new System.Windows.Forms.PictureBox();
            this.spravka = new System.Windows.Forms.PictureBox();
            this.locacii = new System.Windows.Forms.PictureBox();
            this.vtorpers = new System.Windows.Forms.PictureBox();
            this.glavpers = new System.Windows.Forms.PictureBox();
            this.newcharper = new System.Windows.Forms.PictureBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.oglav = new System.Windows.Forms.Panel();
            this.oglavknigi = new System.Windows.Forms.ListBox();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.удалитьГлавуToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.label1 = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.oknige = new System.Windows.Forms.Panel();
            this.VisibleMenu = new System.Windows.Forms.Panel();
            this.DocMenu = new System.Windows.Forms.Panel();
            this.HideMenuBtn = new System.Windows.Forms.PictureBox();
            this.HideMenu = new System.Windows.Forms.Panel();
            this.ShowMenuBut = new System.Windows.Forms.PictureBox();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.word)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.foto)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.spravka)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.locacii)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.vtorpers)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.glavpers)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.newcharper)).BeginInit();
            this.panel2.SuspendLayout();
            this.oglav.SuspendLayout();
            this.contextMenuStrip1.SuspendLayout();
            this.oknige.SuspendLayout();
            this.VisibleMenu.SuspendLayout();
            this.DocMenu.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.HideMenuBtn)).BeginInit();
            this.HideMenu.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ShowMenuBut)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.word);
            this.panel1.Controls.Add(this.foto);
            this.panel1.Controls.Add(this.spravka);
            this.panel1.Controls.Add(this.locacii);
            this.panel1.Controls.Add(this.vtorpers);
            this.panel1.Controls.Add(this.glavpers);
            this.panel1.Controls.Add(this.newcharper);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(43, 828);
            this.panel1.TabIndex = 0;
            // 
            // word
            // 
            this.word.BackgroundImage = global::BookProgram.Properties.Resources.ворд;
            this.word.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.word.Dock = System.Windows.Forms.DockStyle.Top;
            this.word.Location = new System.Drawing.Point(0, 240);
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
            this.foto.Location = new System.Drawing.Point(0, 200);
            this.foto.Name = "foto";
            this.foto.Size = new System.Drawing.Size(43, 40);
            this.foto.TabIndex = 11;
            this.foto.TabStop = false;
            this.foto.Click += new System.EventHandler(this.foto_Click);
            // 
            // spravka
            // 
            this.spravka.BackgroundImage = global::BookProgram.Properties.Resources.с_к_закрыть;
            this.spravka.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.spravka.Dock = System.Windows.Forms.DockStyle.Top;
            this.spravka.Location = new System.Drawing.Point(0, 160);
            this.spravka.Name = "spravka";
            this.spravka.Size = new System.Drawing.Size(43, 40);
            this.spravka.TabIndex = 13;
            this.spravka.TabStop = false;
            this.spravka.Click += new System.EventHandler(this.spravka_Click);
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
            this.locacii.Click += new System.EventHandler(this.locacii_Click);
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
            this.vtorpers.Click += new System.EventHandler(this.vtorpers_Click);
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
            this.glavpers.Click += new System.EventHandler(this.glavpers_Click);
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
            this.newcharper.Click += new System.EventHandler(this.newcharper_Click);
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.oglav);
            this.panel2.Controls.Add(this.oknige);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(43, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(702, 804);
            this.panel2.TabIndex = 1;
            // 
            // oglav
            // 
            this.oglav.Controls.Add(this.oglavknigi);
            this.oglav.Controls.Add(this.label1);
            this.oglav.Controls.Add(this.panel3);
            this.oglav.Dock = System.Windows.Forms.DockStyle.Fill;
            this.oglav.Location = new System.Drawing.Point(0, 240);
            this.oglav.Name = "oglav";
            this.oglav.Size = new System.Drawing.Size(702, 564);
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
            this.oglavknigi.Size = new System.Drawing.Size(682, 539);
            this.oglavknigi.TabIndex = 0;
            this.oglavknigi.DoubleClick += new System.EventHandler(this.oglavknigi_DoubleClick);
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.удалитьГлавуToolStripMenuItem,
            this.toolStripMenuItem1});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(218, 48);
            // 
            // удалитьГлавуToolStripMenuItem
            // 
            this.удалитьГлавуToolStripMenuItem.Name = "удалитьГлавуToolStripMenuItem";
            this.удалитьГлавуToolStripMenuItem.Size = new System.Drawing.Size(217, 22);
            this.удалитьГлавуToolStripMenuItem.Text = "Удалить главу";
            this.удалитьГлавуToolStripMenuItem.Click += new System.EventHandler(this.удалитьГлавуToolStripMenuItem_Click);
            // 
            // toolStripMenuItem1
            // 
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            this.toolStripMenuItem1.Size = new System.Drawing.Size(217, 22);
            this.toolStripMenuItem1.Text = "Изменить название главы";
            // 
            // label1
            // 
            this.label1.Dock = System.Windows.Forms.DockStyle.Top;
            this.label1.Font = new System.Drawing.Font("Monotype Corsiva", 15.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(0, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(682, 25);
            this.label1.TabIndex = 1;
            this.label1.Text = "ОГЛАВЛЕНИЕ";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // panel3
            // 
            this.panel3.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel3.Location = new System.Drawing.Point(682, 0);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(20, 564);
            this.panel3.TabIndex = 2;
            // 
            // oknige
            // 
            this.oknige.Controls.Add(this.VisibleMenu);
            this.oknige.Controls.Add(this.HideMenu);
            this.oknige.Dock = System.Windows.Forms.DockStyle.Top;
            this.oknige.Location = new System.Drawing.Point(0, 0);
            this.oknige.Name = "oknige";
            this.oknige.Size = new System.Drawing.Size(702, 240);
            this.oknige.TabIndex = 0;
            // 
            // VisibleMenu
            // 
            this.VisibleMenu.Controls.Add(this.DocMenu);
            this.VisibleMenu.Dock = System.Windows.Forms.DockStyle.Fill;
            this.VisibleMenu.Location = new System.Drawing.Point(0, 0);
            this.VisibleMenu.Name = "VisibleMenu";
            this.VisibleMenu.Size = new System.Drawing.Size(702, 230);
            this.VisibleMenu.TabIndex = 12;
            // 
            // DocMenu
            // 
            this.DocMenu.BackColor = System.Drawing.Color.Transparent;
            this.DocMenu.Controls.Add(this.HideMenuBtn);
            this.DocMenu.Dock = System.Windows.Forms.DockStyle.Right;
            this.DocMenu.Location = new System.Drawing.Point(682, 0);
            this.DocMenu.Name = "DocMenu";
            this.DocMenu.Size = new System.Drawing.Size(20, 230);
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
            this.HideMenuBtn.Click += new System.EventHandler(this.HideMenuBtn_Click);
            // 
            // HideMenu
            // 
            this.HideMenu.BackColor = System.Drawing.Color.Transparent;
            this.HideMenu.Controls.Add(this.ShowMenuBut);
            this.HideMenu.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.HideMenu.Location = new System.Drawing.Point(0, 230);
            this.HideMenu.Name = "HideMenu";
            this.HideMenu.Size = new System.Drawing.Size(702, 10);
            this.HideMenu.TabIndex = 10;
            this.HideMenu.Visible = false;
            // 
            // ShowMenuBut
            // 
            this.ShowMenuBut.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.ShowMenuBut.Image = global::BookProgram.Properties.Resources.menud;
            this.ShowMenuBut.Location = new System.Drawing.Point(0, 0);
            this.ShowMenuBut.Name = "ShowMenuBut";
            this.ShowMenuBut.Size = new System.Drawing.Size(702, 10);
            this.ShowMenuBut.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.ShowMenuBut.TabIndex = 0;
            this.ShowMenuBut.TabStop = false;
            this.ShowMenuBut.Click += new System.EventHandler(this.ShowMenuBut_Click);
            // 
            // Mybooks_Oglavlenie
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.AutoSize = true;
            this.BackColor = System.Drawing.Color.Transparent;
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Name = "Mybooks_Oglavlenie";
            this.Size = new System.Drawing.Size(745, 828);
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.word)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.foto)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.spravka)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.locacii)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.vtorpers)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.glavpers)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.newcharper)).EndInit();
            this.panel2.ResumeLayout(false);
            this.oglav.ResumeLayout(false);
            this.contextMenuStrip1.ResumeLayout(false);
            this.oknige.ResumeLayout(false);
            this.VisibleMenu.ResumeLayout(false);
            this.DocMenu.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.HideMenuBtn)).EndInit();
            this.HideMenu.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.ShowMenuBut)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel oglav;
        private System.Windows.Forms.Panel oknige;
        private System.Windows.Forms.PictureBox locacii;
        private System.Windows.Forms.PictureBox foto;
        private System.Windows.Forms.PictureBox word;
        private System.Windows.Forms.PictureBox vtorpers;
        private System.Windows.Forms.PictureBox glavpers;
        private System.Windows.Forms.PictureBox newcharper;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel HideMenu;
        private System.Windows.Forms.PictureBox ShowMenuBut;
        private System.Windows.Forms.Panel DocMenu;
        private System.Windows.Forms.PictureBox HideMenuBtn;
        public System.Windows.Forms.Panel VisibleMenu;
        public System.Windows.Forms.ListBox oglavknigi;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem удалитьГлавуToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem1;
        private System.Windows.Forms.PictureBox spravka;
    }
}
