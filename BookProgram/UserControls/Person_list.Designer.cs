namespace BookProgram
{
    partial class Arxivper
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
            this.pech = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panel3 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.Arxivlist = new System.Windows.Forms.ListBox();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.удалитьВыбранногоПерсонажаToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.arhifper_body = new System.Windows.Forms.Panel();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.panel4 = new System.Windows.Forms.Panel();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panel2.SuspendLayout();
            this.contextMenuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.panel4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Transparent;
            this.panel1.Controls.Add(this.panel4);
            this.panel1.Controls.Add(this.pech);
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Controls.Add(this.panel3);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel1.Location = new System.Drawing.Point(997, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(40, 824);
            this.panel1.TabIndex = 0;
            // 
            // pech
            // 
            this.pech.BackgroundImage = global::BookProgram.Properties.Resources.ворд;
            this.pech.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pech.Dock = System.Windows.Forms.DockStyle.Top;
            this.pech.Location = new System.Drawing.Point(0, 49);
            this.pech.Name = "pech";
            this.pech.Size = new System.Drawing.Size(40, 46);
            this.pech.TabIndex = 6;
            this.pech.Click += new System.EventHandler(this.pech_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImage = global::BookProgram.Properties.Resources.новый_герой;
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.pictureBox1.Dock = System.Windows.Forms.DockStyle.Top;
            this.pictureBox1.Location = new System.Drawing.Point(0, 10);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(40, 39);
            this.pictureBox1.TabIndex = 2;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // panel3
            // 
            this.panel3.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel3.Location = new System.Drawing.Point(0, 0);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(40, 10);
            this.panel3.TabIndex = 3;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.Transparent;
            this.panel2.Controls.Add(this.Arxivlist);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(191, 824);
            this.panel2.TabIndex = 1;
            // 
            // Arxivlist
            // 
            this.Arxivlist.BackColor = System.Drawing.Color.White;
            this.Arxivlist.ContextMenuStrip = this.contextMenuStrip1;
            this.Arxivlist.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Arxivlist.Font = new System.Drawing.Font("Monotype Corsiva", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Arxivlist.FormattingEnabled = true;
            this.Arxivlist.ItemHeight = 18;
            this.Arxivlist.Location = new System.Drawing.Point(0, 0);
            this.Arxivlist.Name = "Arxivlist";
            this.Arxivlist.Size = new System.Drawing.Size(191, 824);
            this.Arxivlist.TabIndex = 0;
            this.Arxivlist.Click += new System.EventHandler(this.Arxivlist_Click);
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.удалитьВыбранногоПерсонажаToolStripMenuItem});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(254, 26);
            // 
            // удалитьВыбранногоПерсонажаToolStripMenuItem
            // 
            this.удалитьВыбранногоПерсонажаToolStripMenuItem.Name = "удалитьВыбранногоПерсонажаToolStripMenuItem";
            this.удалитьВыбранногоПерсонажаToolStripMenuItem.Size = new System.Drawing.Size(253, 22);
            this.удалитьВыбранногоПерсонажаToolStripMenuItem.Text = "Удалить выбранного персонажа";
            this.удалитьВыбранногоПерсонажаToolStripMenuItem.Click += new System.EventHandler(this.удалитьВыбранногоПерсонажаToolStripMenuItem_Click);
            // 
            // arhifper_body
            // 
            this.arhifper_body.Dock = System.Windows.Forms.DockStyle.Fill;
            this.arhifper_body.Location = new System.Drawing.Point(191, 0);
            this.arhifper_body.Name = "arhifper_body";
            this.arhifper_body.Size = new System.Drawing.Size(806, 824);
            this.arhifper_body.TabIndex = 2;
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackgroundImage = global::BookProgram.Properties.Resources.Удалить;
            this.pictureBox2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pictureBox2.Dock = System.Windows.Forms.DockStyle.Top;
            this.pictureBox2.Location = new System.Drawing.Point(0, 23);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(40, 23);
            this.pictureBox2.TabIndex = 7;
            this.pictureBox2.TabStop = false;
            this.pictureBox2.Visible = false;
            // 
            // panel4
            // 
            this.panel4.Controls.Add(this.pictureBox2);
            this.panel4.Controls.Add(this.pictureBox3);
            this.panel4.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel4.Location = new System.Drawing.Point(0, 112);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(40, 712);
            this.panel4.TabIndex = 8;
            // 
            // pictureBox3
            // 
            this.pictureBox3.BackgroundImage = global::BookProgram.Properties.Resources.добавить;
            this.pictureBox3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pictureBox3.Dock = System.Windows.Forms.DockStyle.Top;
            this.pictureBox3.Location = new System.Drawing.Point(0, 0);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(40, 23);
            this.pictureBox3.TabIndex = 8;
            this.pictureBox3.TabStop = false;
            // 
            // Arxivper
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Transparent;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.Controls.Add(this.arhifper_body);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Name = "Arxivper";
            this.Size = new System.Drawing.Size(1037, 824);
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panel2.ResumeLayout(false);
            this.contextMenuStrip1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.panel4.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel pech;
        public System.Windows.Forms.ListBox Arxivlist;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem удалитьВыбранногоПерсонажаToolStripMenuItem;
        private System.Windows.Forms.Panel arhifper_body;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.PictureBox pictureBox3;
    }
}
