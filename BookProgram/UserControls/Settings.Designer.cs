namespace BookProgram
{
    partial class Settings
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
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.label1 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.path = new System.Windows.Forms.TextBox();
            this.open_file = new System.Windows.Forms.PictureBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.full = new System.Windows.Forms.CheckBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.savebtn = new System.Windows.Forms.PictureBox();
            this.hidebtn = new System.Windows.Forms.PictureBox();
            this.height_f = new System.Windows.Forms.NumericUpDown();
            this.width_f = new System.Windows.Forms.NumericUpDown();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.tableLayoutPanel1.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.open_file)).BeginInit();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.savebtn)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.hidebtn)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.height_f)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.width_f)).BeginInit();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.CellBorderStyle = System.Windows.Forms.TableLayoutPanelCellBorderStyle.Single;
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 26.22378F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 73.77622F));
            this.tableLayoutPanel1.Controls.Add(this.label1, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.panel1, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.label2, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.label3, 0, 2);
            this.tableLayoutPanel1.Controls.Add(this.label4, 0, 3);
            this.tableLayoutPanel1.Controls.Add(this.label5, 0, 4);
            this.tableLayoutPanel1.Controls.Add(this.full, 1, 3);
            this.tableLayoutPanel1.Controls.Add(this.panel2, 1, 4);
            this.tableLayoutPanel1.Controls.Add(this.height_f, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this.width_f, 1, 2);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 6;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 25F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 25F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 25F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 25F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 35F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 23F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(572, 560);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(4, 1);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(143, 25);
            this.label1.TabIndex = 0;
            this.label1.Text = "Путь к общему файлу";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.path);
            this.panel1.Controls.Add(this.open_file);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(154, 4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(414, 19);
            this.panel1.TabIndex = 1;
            // 
            // path
            // 
            this.path.BackColor = System.Drawing.Color.GhostWhite;
            this.path.Dock = System.Windows.Forms.DockStyle.Fill;
            this.path.ForeColor = System.Drawing.Color.Black;
            this.path.Location = new System.Drawing.Point(0, 0);
            this.path.Name = "path";
            this.path.ReadOnly = true;
            this.path.Size = new System.Drawing.Size(389, 20);
            this.path.TabIndex = 0;
            // 
            // open_file
            // 
            this.open_file.BackgroundImage = global::BookProgram.Properties.Resources.Путь;
            this.open_file.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.open_file.Dock = System.Windows.Forms.DockStyle.Right;
            this.open_file.Location = new System.Drawing.Point(389, 0);
            this.open_file.Name = "open_file";
            this.open_file.Size = new System.Drawing.Size(25, 19);
            this.open_file.TabIndex = 1;
            this.open_file.TabStop = false;
            this.open_file.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label2.ForeColor = System.Drawing.Color.Black;
            this.label2.Location = new System.Drawing.Point(4, 27);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(143, 25);
            this.label2.TabIndex = 2;
            this.label2.Text = "Высота формы";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label3.ForeColor = System.Drawing.Color.Black;
            this.label3.Location = new System.Drawing.Point(4, 53);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(143, 25);
            this.label3.TabIndex = 3;
            this.label3.Text = "Ширина формы";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label4.ForeColor = System.Drawing.Color.Black;
            this.label4.Location = new System.Drawing.Point(4, 79);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(143, 25);
            this.label4.TabIndex = 4;
            this.label4.Text = "Открывать во весь экран";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label5.ForeColor = System.Drawing.Color.Gainsboro;
            this.label5.Location = new System.Drawing.Point(4, 105);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(143, 35);
            this.label5.TabIndex = 5;
            // 
            // full
            // 
            this.full.AutoSize = true;
            this.full.Location = new System.Drawing.Point(154, 82);
            this.full.Name = "full";
            this.full.Size = new System.Drawing.Size(15, 14);
            this.full.TabIndex = 14;
            this.full.UseVisualStyleBackColor = true;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.savebtn);
            this.panel2.Controls.Add(this.hidebtn);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(154, 108);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(414, 29);
            this.panel2.TabIndex = 15;
            // 
            // savebtn
            // 
            this.savebtn.BackColor = System.Drawing.Color.Blue;
            this.savebtn.BackgroundImage = global::BookProgram.Properties.Resources.Сохранить;
            this.savebtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.savebtn.Dock = System.Windows.Forms.DockStyle.Right;
            this.savebtn.Location = new System.Drawing.Point(355, 0);
            this.savebtn.Name = "savebtn";
            this.savebtn.Size = new System.Drawing.Size(29, 29);
            this.savebtn.TabIndex = 1;
            this.savebtn.TabStop = false;
            this.savebtn.Click += new System.EventHandler(this.savebtn_Click);
            // 
            // hidebtn
            // 
            this.hidebtn.BackColor = System.Drawing.Color.Red;
            this.hidebtn.BackgroundImage = global::BookProgram.Properties.Resources.закр;
            this.hidebtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.hidebtn.Dock = System.Windows.Forms.DockStyle.Right;
            this.hidebtn.Location = new System.Drawing.Point(384, 0);
            this.hidebtn.Name = "hidebtn";
            this.hidebtn.Size = new System.Drawing.Size(30, 29);
            this.hidebtn.TabIndex = 0;
            this.hidebtn.TabStop = false;
            this.hidebtn.Click += new System.EventHandler(this.pictureBox2_Click);
            // 
            // height_f
            // 
            this.height_f.BackColor = System.Drawing.Color.GhostWhite;
            this.height_f.Dock = System.Windows.Forms.DockStyle.Fill;
            this.height_f.ForeColor = System.Drawing.Color.Black;
            this.height_f.Location = new System.Drawing.Point(154, 30);
            this.height_f.Maximum = new decimal(new int[] {
            10000,
            0,
            0,
            0});
            this.height_f.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.height_f.Name = "height_f";
            this.height_f.Size = new System.Drawing.Size(414, 20);
            this.height_f.TabIndex = 16;
            this.height_f.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // width_f
            // 
            this.width_f.BackColor = System.Drawing.Color.GhostWhite;
            this.width_f.Dock = System.Windows.Forms.DockStyle.Fill;
            this.width_f.ForeColor = System.Drawing.Color.Black;
            this.width_f.Location = new System.Drawing.Point(154, 56);
            this.width_f.Maximum = new decimal(new int[] {
            10000,
            0,
            0,
            0});
            this.width_f.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.width_f.Name = "width_f";
            this.width_f.Size = new System.Drawing.Size(414, 20);
            this.width_f.TabIndex = 17;
            this.width_f.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // Settings
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Transparent;
            this.Controls.Add(this.tableLayoutPanel1);
            this.Name = "Settings";
            this.Size = new System.Drawing.Size(572, 560);
            this.Load += new System.EventHandler(this.Settings_Load);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.open_file)).EndInit();
            this.panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.savebtn)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.hidebtn)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.height_f)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.width_f)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TextBox path;
        private System.Windows.Forms.PictureBox open_file;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.CheckBox full;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.PictureBox savebtn;
        private System.Windows.Forms.PictureBox hidebtn;
        private System.Windows.Forms.NumericUpDown height_f;
        private System.Windows.Forms.NumericUpDown width_f;
    }
}
