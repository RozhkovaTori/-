namespace BookProgram
{
    partial class Mybooks_Glaverson
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
            this.book_gg = new System.Windows.Forms.ListBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.all_gg = new System.Windows.Forms.ListBox();
            this.panel3 = new System.Windows.Forms.Panel();
            this.add_to_book = new System.Windows.Forms.PictureBox();
            this.remove_to_book = new System.Windows.Forms.PictureBox();
            this.panel5 = new System.Windows.Forms.Panel();
            this.panel4 = new System.Windows.Forms.Panel();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.add_to_book)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.remove_to_book)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.book_gg);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel1.Location = new System.Drawing.Point(395, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(350, 531);
            this.panel1.TabIndex = 0;
            // 
            // book_gg
            // 
            this.book_gg.Dock = System.Windows.Forms.DockStyle.Fill;
            this.book_gg.FormattingEnabled = true;
            this.book_gg.Location = new System.Drawing.Point(0, 0);
            this.book_gg.Name = "book_gg";
            this.book_gg.Size = new System.Drawing.Size(350, 531);
            this.book_gg.TabIndex = 0;
            this.book_gg.DoubleClick += new System.EventHandler(this.book_gg_DoubleClick);
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.all_gg);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(350, 531);
            this.panel2.TabIndex = 1;
            // 
            // all_gg
            // 
            this.all_gg.Dock = System.Windows.Forms.DockStyle.Fill;
            this.all_gg.FormattingEnabled = true;
            this.all_gg.Location = new System.Drawing.Point(0, 0);
            this.all_gg.Name = "all_gg";
            this.all_gg.Size = new System.Drawing.Size(350, 531);
            this.all_gg.TabIndex = 0;
            this.all_gg.DoubleClick += new System.EventHandler(this.all_gg_DoubleClick);
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.add_to_book);
            this.panel3.Controls.Add(this.remove_to_book);
            this.panel3.Controls.Add(this.panel5);
            this.panel3.Controls.Add(this.panel4);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel3.Location = new System.Drawing.Point(350, 0);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(45, 531);
            this.panel3.TabIndex = 2;
            // 
            // add_to_book
            // 
            this.add_to_book.BackgroundImage = global::BookProgram.Properties.Resources.Стрелочка_1;
            this.add_to_book.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.add_to_book.Dock = System.Windows.Forms.DockStyle.Top;
            this.add_to_book.Location = new System.Drawing.Point(0, 215);
            this.add_to_book.Name = "add_to_book";
            this.add_to_book.Size = new System.Drawing.Size(45, 50);
            this.add_to_book.TabIndex = 3;
            this.add_to_book.TabStop = false;
            this.add_to_book.Click += new System.EventHandler(this.add_to_book_Click);
            this.add_to_book.MouseLeave += new System.EventHandler(this.add_to_book_MouseLeave);
            this.add_to_book.MouseHover += new System.EventHandler(this.add_to_book_MouseHover);
            // 
            // remove_to_book
            // 
            this.remove_to_book.BackgroundImage = global::BookProgram.Properties.Resources.Стрелочка_2;
            this.remove_to_book.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.remove_to_book.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.remove_to_book.Location = new System.Drawing.Point(0, 266);
            this.remove_to_book.Name = "remove_to_book";
            this.remove_to_book.Size = new System.Drawing.Size(45, 50);
            this.remove_to_book.TabIndex = 2;
            this.remove_to_book.TabStop = false;
            this.remove_to_book.Click += new System.EventHandler(this.remove_to_book_Click);
            this.remove_to_book.MouseLeave += new System.EventHandler(this.remove_to_book_MouseLeave);
            this.remove_to_book.MouseHover += new System.EventHandler(this.remove_to_book_MouseHover);
            // 
            // panel5
            // 
            this.panel5.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel5.Location = new System.Drawing.Point(0, 0);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(45, 215);
            this.panel5.TabIndex = 1;
            // 
            // panel4
            // 
            this.panel4.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel4.Location = new System.Drawing.Point(0, 316);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(45, 215);
            this.panel4.TabIndex = 0;
            // 
            // Mybooks_Glaverson
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Transparent;
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Name = "Mybooks_Glaverson";
            this.Size = new System.Drawing.Size(745, 531);
            this.panel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.add_to_book)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.remove_to_book)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.PictureBox add_to_book;
        private System.Windows.Forms.PictureBox remove_to_book;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.Panel panel4;
        public System.Windows.Forms.ListBox book_gg;
        public System.Windows.Forms.ListBox all_gg;
    }
}
