namespace BookProgram
{
    partial class Mybooks_Newbook
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
            this.обложка = new System.Windows.Forms.PictureBox();
            this.CompliteBtnmu = new System.Windows.Forms.Label();
            this.название = new System.Windows.Forms.TextBox();
            this.о_книге = new System.Windows.Forms.TextBox();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.panel1 = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.жанр = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.обложка)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // обложка
            // 
            this.обложка.BackgroundImage = global::BookProgram.Properties.Resources.Для_пикчербоксов;
            this.обложка.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.обложка.Location = new System.Drawing.Point(15, 16);
            this.обложка.Name = "обложка";
            this.обложка.Size = new System.Drawing.Size(285, 412);
            this.обложка.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.обложка.TabIndex = 2;
            this.обложка.TabStop = false;
            this.обложка.Click += new System.EventHandler(this.обложка_Click);
            // 
            // CompliteBtnmu
            // 
            this.CompliteBtnmu.AutoSize = true;
            this.CompliteBtnmu.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.CompliteBtnmu.Font = new System.Drawing.Font("Monotype Corsiva", 15.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CompliteBtnmu.ForeColor = System.Drawing.Color.Black;
            this.CompliteBtnmu.Location = new System.Drawing.Point(612, 496);
            this.CompliteBtnmu.Name = "CompliteBtnmu";
            this.CompliteBtnmu.Size = new System.Drawing.Size(100, 27);
            this.CompliteBtnmu.TabIndex = 27;
            this.CompliteBtnmu.Text = "Записать";
            this.CompliteBtnmu.Click += new System.EventHandler(this.CompliteBtnmu_Click);
            // 
            // название
            // 
            this.название.BackColor = System.Drawing.Color.GhostWhite;
            this.название.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.название.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.название.Font = new System.Drawing.Font("Monotype Corsiva", 20.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.название.ForeColor = System.Drawing.Color.Black;
            this.название.Location = new System.Drawing.Point(306, 29);
            this.название.Multiline = true;
            this.название.Name = "название";
            this.название.Size = new System.Drawing.Size(393, 47);
            this.название.TabIndex = 28;
            this.название.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // о_книге
            // 
            this.о_книге.BackColor = System.Drawing.Color.GhostWhite;
            this.о_книге.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.о_книге.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.о_книге.Font = new System.Drawing.Font("Monotype Corsiva", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.о_книге.ForeColor = System.Drawing.Color.Black;
            this.о_книге.Location = new System.Drawing.Point(309, 88);
            this.о_книге.Multiline = true;
            this.о_книге.Name = "о_книге";
            this.о_книге.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.о_книге.Size = new System.Drawing.Size(436, 405);
            this.о_книге.TabIndex = 29;
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.о_книге);
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Controls.Add(this.жанр);
            this.panel1.Controls.Add(this.название);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(745, 531);
            this.panel1.TabIndex = 30;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::BookProgram.Properties.Resources.Изменить;
            this.pictureBox1.Location = new System.Drawing.Point(705, 50);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(25, 25);
            this.pictureBox1.TabIndex = 29;
            this.pictureBox1.TabStop = false;
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
            this.жанр.Location = new System.Drawing.Point(25, 434);
            this.жанр.Name = "жанр";
            this.жанр.Size = new System.Drawing.Size(254, 26);
            this.жанр.TabIndex = 0;
            // 
            // Mybooks_Newbook
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackColor = System.Drawing.Color.Transparent;
            this.Controls.Add(this.CompliteBtnmu);
            this.Controls.Add(this.обложка);
            this.Controls.Add(this.panel1);
            this.Name = "Mybooks_Newbook";
            this.Size = new System.Drawing.Size(745, 531);
            this.Resize += new System.EventHandler(this.Mybooks_Newbook_Resize);
            ((System.ComponentModel.ISupportInitialize)(this.обложка)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.PictureBox обложка;
        private System.Windows.Forms.Label CompliteBtnmu;
        private System.Windows.Forms.TextBox название;
        private System.Windows.Forms.TextBox о_книге;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.ComboBox жанр;
    }
}
