namespace BookProgram
{
    partial class Spravochnik
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.slovari = new System.Windows.Forms.Panel();
            this.pictureBox4 = new System.Windows.Forms.PictureBox();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.DocMenu = new System.Windows.Forms.Panel();
            this.HideMenuBtn = new System.Windows.Forms.PictureBox();
            this.HideMenu = new System.Windows.Forms.Panel();
            this.ShowMenuBut = new System.Windows.Forms.PictureBox();
            this.panel3 = new System.Windows.Forms.Panel();
            this.panel1.SuspendLayout();
            this.slovari.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.DocMenu.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.HideMenuBtn)).BeginInit();
            this.HideMenu.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ShowMenuBut)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.slovari);
            this.panel1.Controls.Add(this.HideMenu);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(167, 744);
            this.panel1.TabIndex = 0;
            // 
            // slovari
            // 
            this.slovari.Controls.Add(this.pictureBox4);
            this.slovari.Controls.Add(this.pictureBox3);
            this.slovari.Controls.Add(this.pictureBox2);
            this.slovari.Controls.Add(this.pictureBox1);
            this.slovari.Controls.Add(this.DocMenu);
            this.slovari.Dock = System.Windows.Forms.DockStyle.Fill;
            this.slovari.Location = new System.Drawing.Point(0, 0);
            this.slovari.Name = "slovari";
            this.slovari.Size = new System.Drawing.Size(150, 744);
            this.slovari.TabIndex = 0;
            // 
            // pictureBox4
            // 
            this.pictureBox4.Dock = System.Windows.Forms.DockStyle.Top;
            this.pictureBox4.Image = global::BookProgram.Properties.Resources.слов_мифологический;
            this.pictureBox4.Location = new System.Drawing.Point(0, 141);
            this.pictureBox4.Name = "pictureBox4";
            this.pictureBox4.Size = new System.Drawing.Size(150, 40);
            this.pictureBox4.TabIndex = 0;
            this.pictureBox4.TabStop = false;
            this.pictureBox4.Click += new System.EventHandler(this.pictureBox4_Click);
            // 
            // pictureBox3
            // 
            this.pictureBox3.Dock = System.Windows.Forms.DockStyle.Top;
            this.pictureBox3.Image = global::BookProgram.Properties.Resources.слов_англо_русский;
            this.pictureBox3.Location = new System.Drawing.Point(0, 101);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(150, 40);
            this.pictureBox3.TabIndex = 0;
            this.pictureBox3.TabStop = false;
            this.pictureBox3.Click += new System.EventHandler(this.pictureBox3_Click);
            // 
            // pictureBox2
            // 
            this.pictureBox2.Dock = System.Windows.Forms.DockStyle.Top;
            this.pictureBox2.Image = global::BookProgram.Properties.Resources.слов_именной;
            this.pictureBox2.Location = new System.Drawing.Point(0, 61);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(150, 40);
            this.pictureBox2.TabIndex = 0;
            this.pictureBox2.TabStop = false;
            this.pictureBox2.Click += new System.EventHandler(this.pictureBox2_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Dock = System.Windows.Forms.DockStyle.Top;
            this.pictureBox1.Image = global::BookProgram.Properties.Resources.слов_общий;
            this.pictureBox1.Location = new System.Drawing.Point(0, 21);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(150, 40);
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // DocMenu
            // 
            this.DocMenu.BackColor = System.Drawing.Color.Transparent;
            this.DocMenu.Controls.Add(this.HideMenuBtn);
            this.DocMenu.Dock = System.Windows.Forms.DockStyle.Top;
            this.DocMenu.Location = new System.Drawing.Point(0, 0);
            this.DocMenu.Name = "DocMenu";
            this.DocMenu.Size = new System.Drawing.Size(150, 21);
            this.DocMenu.TabIndex = 11;
            // 
            // HideMenuBtn
            // 
            this.HideMenuBtn.Dock = System.Windows.Forms.DockStyle.Left;
            this.HideMenuBtn.Image = global::BookProgram.Properties.Resources.hide;
            this.HideMenuBtn.Location = new System.Drawing.Point(0, 0);
            this.HideMenuBtn.Name = "HideMenuBtn";
            this.HideMenuBtn.Size = new System.Drawing.Size(22, 21);
            this.HideMenuBtn.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.HideMenuBtn.TabIndex = 0;
            this.HideMenuBtn.TabStop = false;
            // 
            // HideMenu
            // 
            this.HideMenu.BackColor = System.Drawing.Color.Transparent;
            this.HideMenu.Controls.Add(this.ShowMenuBut);
            this.HideMenu.Dock = System.Windows.Forms.DockStyle.Right;
            this.HideMenu.Location = new System.Drawing.Point(150, 0);
            this.HideMenu.Name = "HideMenu";
            this.HideMenu.Size = new System.Drawing.Size(17, 744);
            this.HideMenu.TabIndex = 10;
            this.HideMenu.Visible = false;
            // 
            // ShowMenuBut
            // 
            this.ShowMenuBut.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ShowMenuBut.Image = global::BookProgram.Properties.Resources.menud;
            this.ShowMenuBut.Location = new System.Drawing.Point(0, 0);
            this.ShowMenuBut.Name = "ShowMenuBut";
            this.ShowMenuBut.Size = new System.Drawing.Size(17, 744);
            this.ShowMenuBut.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.ShowMenuBut.TabIndex = 0;
            this.ShowMenuBut.TabStop = false;
            // 
            // panel3
            // 
            this.panel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel3.Location = new System.Drawing.Point(167, 0);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(864, 744);
            this.panel3.TabIndex = 2;
            // 
            // Spravochnik
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Transparent;
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel1);
            this.Name = "Spravochnik";
            this.Size = new System.Drawing.Size(1031, 744);
            this.panel1.ResumeLayout(false);
            this.slovari.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.DocMenu.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.HideMenuBtn)).EndInit();
            this.HideMenu.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.ShowMenuBut)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel slovari;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Panel DocMenu;
        private System.Windows.Forms.PictureBox HideMenuBtn;
        private System.Windows.Forms.Panel HideMenu;
        private System.Windows.Forms.PictureBox ShowMenuBut;
        private System.Windows.Forms.PictureBox pictureBox4;
        private System.Windows.Forms.PictureBox pictureBox3;
    }
}
