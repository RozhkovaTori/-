namespace BookProgram
{
    partial class Mybooks_Location
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
            this.body = new System.Windows.Forms.Panel();
            this.dynamic_content = new System.Windows.Forms.Panel();
            this.fix_content = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.описание = new System.Windows.Forms.TextBox();
            this.изображение = new System.Windows.Forms.PictureBox();
            this.название = new System.Windows.Forms.TextBox();
            this.menu = new System.Windows.Forms.Panel();
            this.save = new System.Windows.Forms.PictureBox();
            this.add_new = new System.Windows.Forms.PictureBox();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.body.SuspendLayout();
            this.fix_content.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.изображение)).BeginInit();
            this.menu.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.save)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.add_new)).BeginInit();
            this.SuspendLayout();
            // 
            // body
            // 
            this.body.Controls.Add(this.dynamic_content);
            this.body.Controls.Add(this.fix_content);
            this.body.Dock = System.Windows.Forms.DockStyle.Fill;
            this.body.Location = new System.Drawing.Point(0, 0);
            this.body.Name = "body";
            this.body.Size = new System.Drawing.Size(705, 531);
            this.body.TabIndex = 0;
            // 
            // dynamic_content
            // 
            this.dynamic_content.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dynamic_content.Location = new System.Drawing.Point(0, 272);
            this.dynamic_content.Name = "dynamic_content";
            this.dynamic_content.Size = new System.Drawing.Size(705, 259);
            this.dynamic_content.TabIndex = 1;
            // 
            // fix_content
            // 
            this.fix_content.Controls.Add(this.pictureBox1);
            this.fix_content.Controls.Add(this.описание);
            this.fix_content.Controls.Add(this.изображение);
            this.fix_content.Controls.Add(this.название);
            this.fix_content.Dock = System.Windows.Forms.DockStyle.Top;
            this.fix_content.Location = new System.Drawing.Point(0, 0);
            this.fix_content.Name = "fix_content";
            this.fix_content.Size = new System.Drawing.Size(705, 272);
            this.fix_content.TabIndex = 0;
            this.fix_content.Visible = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox1.BackgroundImage = global::BookProgram.Properties.Resources.Удалить;
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pictureBox1.Location = new System.Drawing.Point(669, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(30, 30);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 3;
            this.pictureBox1.TabStop = false;
            // 
            // описание
            // 
            this.описание.Location = new System.Drawing.Point(284, 50);
            this.описание.Multiline = true;
            this.описание.Name = "описание";
            this.описание.Size = new System.Drawing.Size(397, 202);
            this.описание.TabIndex = 2;
            // 
            // изображение
            // 
            this.изображение.BackgroundImage = global::BookProgram.Properties.Resources.Для_пикчербоксов;
            this.изображение.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.изображение.Location = new System.Drawing.Point(12, 50);
            this.изображение.Name = "изображение";
            this.изображение.Size = new System.Drawing.Size(266, 171);
            this.изображение.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.изображение.TabIndex = 1;
            this.изображение.TabStop = false;
            this.изображение.DoubleClick += new System.EventHandler(this.изображение_DoubleClick);
            // 
            // название
            // 
            this.название.Location = new System.Drawing.Point(12, 12);
            this.название.Multiline = true;
            this.название.Name = "название";
            this.название.Size = new System.Drawing.Size(362, 30);
            this.название.TabIndex = 0;
            // 
            // menu
            // 
            this.menu.Controls.Add(this.save);
            this.menu.Controls.Add(this.add_new);
            this.menu.Dock = System.Windows.Forms.DockStyle.Right;
            this.menu.Location = new System.Drawing.Point(705, 0);
            this.menu.Name = "menu";
            this.menu.Size = new System.Drawing.Size(40, 531);
            this.menu.TabIndex = 1;
            // 
            // save
            // 
            this.save.BackgroundImage = global::BookProgram.Properties.Resources.Сохранить;
            this.save.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.save.Dock = System.Windows.Forms.DockStyle.Top;
            this.save.Location = new System.Drawing.Point(0, 50);
            this.save.Name = "save";
            this.save.Size = new System.Drawing.Size(40, 50);
            this.save.TabIndex = 1;
            this.save.TabStop = false;
            this.save.Click += new System.EventHandler(this.save_Click);
            // 
            // add_new
            // 
            this.add_new.BackgroundImage = global::BookProgram.Properties.Resources.добавить;
            this.add_new.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.add_new.Dock = System.Windows.Forms.DockStyle.Top;
            this.add_new.Location = new System.Drawing.Point(0, 0);
            this.add_new.Name = "add_new";
            this.add_new.Size = new System.Drawing.Size(40, 50);
            this.add_new.TabIndex = 0;
            this.add_new.TabStop = false;
            this.add_new.Click += new System.EventHandler(this.add_Click);
            // 
            // Mybooks_Location
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Transparent;
            this.Controls.Add(this.body);
            this.Controls.Add(this.menu);
            this.Name = "Mybooks_Location";
            this.Size = new System.Drawing.Size(745, 531);
            this.body.ResumeLayout(false);
            this.fix_content.ResumeLayout(false);
            this.fix_content.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.изображение)).EndInit();
            this.menu.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.save)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.add_new)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel body;
        private System.Windows.Forms.Panel menu;
        private System.Windows.Forms.PictureBox add_new;
        private System.Windows.Forms.PictureBox save;
        private System.Windows.Forms.Panel fix_content;
        private System.Windows.Forms.TextBox описание;
        private System.Windows.Forms.PictureBox изображение;
        private System.Windows.Forms.TextBox название;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.Panel dynamic_content;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}
