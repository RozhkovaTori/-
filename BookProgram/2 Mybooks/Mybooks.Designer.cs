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
            this.panel1.SuspendLayout();
            this.contextMenuStrip1.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.newbook)).BeginInit();
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
            this.panel1.Size = new System.Drawing.Size(168, 815);
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
            this.mybook.Size = new System.Drawing.Size(168, 815);
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
            this.panel2.Location = new System.Drawing.Point(168, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(951, 40);
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
            this.kniga.Dock = System.Windows.Forms.DockStyle.Fill;
            this.kniga.Location = new System.Drawing.Point(168, 40);
            this.kniga.Name = "kniga";
            this.kniga.Size = new System.Drawing.Size(951, 775);
            this.kniga.TabIndex = 2;
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
    }
}
