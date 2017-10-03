namespace BookProgram
{
    partial class CFormDialog
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
            this.Body = new System.Windows.Forms.Panel();
            this.pictureBox5 = new System.Windows.Forms.PictureBox();
            this.pictureBox4 = new System.Windows.Forms.PictureBox();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.TopBar = new System.Windows.Forms.Panel();
            this.caption = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.resizeForm = new System.Windows.Forms.PictureBox();
            this.BottomBar = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            this.TopBar.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.resizeForm)).BeginInit();
            this.BottomBar.SuspendLayout();
            this.SuspendLayout();
            // 
            // Body
            // 
            this.Body.AutoSize = true;
            this.Body.BackColor = System.Drawing.Color.Transparent;
            this.Body.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Body.Location = new System.Drawing.Point(0, 20);
            this.Body.Name = "Body";
            this.Body.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.Body.Size = new System.Drawing.Size(800, 614);
            this.Body.TabIndex = 13;
            // 
            // pictureBox5
            // 
            this.pictureBox5.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox5.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox5.Dock = System.Windows.Forms.DockStyle.Right;
            this.pictureBox5.Image = global::BookProgram.Properties.Resources.н_с_свернуть;
            this.pictureBox5.Location = new System.Drawing.Point(729, 0);
            this.pictureBox5.Name = "pictureBox5";
            this.pictureBox5.Size = new System.Drawing.Size(25, 20);
            this.pictureBox5.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox5.TabIndex = 2;
            this.pictureBox5.TabStop = false;
            this.pictureBox5.Click += new System.EventHandler(this.pictureBox5_Click);
            this.pictureBox5.MouseLeave += new System.EventHandler(this.pictureBox5_MouseLeave);
            this.pictureBox5.MouseHover += new System.EventHandler(this.pictureBox5_MouseHover);
            // 
            // pictureBox4
            // 
            this.pictureBox4.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox4.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox4.Dock = System.Windows.Forms.DockStyle.Right;
            this.pictureBox4.Image = global::BookProgram.Properties.Resources.н_с_развернуть;
            this.pictureBox4.Location = new System.Drawing.Point(754, 0);
            this.pictureBox4.Name = "pictureBox4";
            this.pictureBox4.Size = new System.Drawing.Size(23, 20);
            this.pictureBox4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox4.TabIndex = 2;
            this.pictureBox4.TabStop = false;
            this.pictureBox4.Click += new System.EventHandler(this.pictureBox4_Click);
            this.pictureBox4.MouseLeave += new System.EventHandler(this.pictureBox4_MouseLeave);
            this.pictureBox4.MouseHover += new System.EventHandler(this.pictureBox4_MouseHover);
            // 
            // pictureBox3
            // 
            this.pictureBox3.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.pictureBox3.Dock = System.Windows.Forms.DockStyle.Right;
            this.pictureBox3.Image = global::BookProgram.Properties.Resources.н_с_закрыть;
            this.pictureBox3.Location = new System.Drawing.Point(777, 0);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(23, 20);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox3.TabIndex = 2;
            this.pictureBox3.TabStop = false;
            this.pictureBox3.Click += new System.EventHandler(this.pictureBox3_Click);
            this.pictureBox3.MouseLeave += new System.EventHandler(this.pictureBox3_MouseLeave);
            this.pictureBox3.MouseHover += new System.EventHandler(this.pictureBox3_MouseHover);
            // 
            // TopBar
            // 
            this.TopBar.BackColor = System.Drawing.Color.Transparent;
            this.TopBar.Controls.Add(this.caption);
            this.TopBar.Controls.Add(this.pictureBox5);
            this.TopBar.Controls.Add(this.pictureBox4);
            this.TopBar.Controls.Add(this.pictureBox3);
            this.TopBar.Controls.Add(this.pictureBox1);
            this.TopBar.Dock = System.Windows.Forms.DockStyle.Top;
            this.TopBar.Location = new System.Drawing.Point(0, 0);
            this.TopBar.Name = "TopBar";
            this.TopBar.Size = new System.Drawing.Size(800, 20);
            this.TopBar.TabIndex = 10;
            this.TopBar.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Osnova_MouseDown);
            this.TopBar.MouseMove += new System.Windows.Forms.MouseEventHandler(this.Osnova_MouseMove);
            this.TopBar.MouseUp += new System.Windows.Forms.MouseEventHandler(this.Osnova_MouseUp);
            // 
            // caption
            // 
            this.caption.Dock = System.Windows.Forms.DockStyle.Fill;
            this.caption.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.caption.Location = new System.Drawing.Point(87, 0);
            this.caption.Name = "caption";
            this.caption.Size = new System.Drawing.Size(642, 20);
            this.caption.TabIndex = 3;
            this.caption.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Osnova_MouseDown);
            this.caption.MouseMove += new System.Windows.Forms.MouseEventHandler(this.Osnova_MouseMove);
            this.caption.MouseUp += new System.Windows.Forms.MouseEventHandler(this.Osnova_MouseUp);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox1.Dock = System.Windows.Forms.DockStyle.Left;
            this.pictureBox1.Image = global::BookProgram.Properties.Resources.Имя;
            this.pictureBox1.Location = new System.Drawing.Point(0, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(87, 20);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 2;
            this.pictureBox1.TabStop = false;
            // 
            // resizeForm
            // 
            this.resizeForm.Dock = System.Windows.Forms.DockStyle.Right;
            this.resizeForm.Image = global::BookProgram.Properties.Resources.triangle;
            this.resizeForm.Location = new System.Drawing.Point(784, 0);
            this.resizeForm.Name = "resizeForm";
            this.resizeForm.Size = new System.Drawing.Size(16, 16);
            this.resizeForm.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.resizeForm.TabIndex = 0;
            this.resizeForm.TabStop = false;
            this.resizeForm.MouseDown += new System.Windows.Forms.MouseEventHandler(this.resize_MouseDown);
            this.resizeForm.MouseMove += new System.Windows.Forms.MouseEventHandler(this.resize_MouseMove);
            this.resizeForm.MouseUp += new System.Windows.Forms.MouseEventHandler(this.resize_MouseUp);
            // 
            // BottomBar
            // 
            this.BottomBar.BackColor = System.Drawing.Color.Transparent;
            this.BottomBar.Controls.Add(this.resizeForm);
            this.BottomBar.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.BottomBar.Location = new System.Drawing.Point(0, 634);
            this.BottomBar.Name = "BottomBar";
            this.BottomBar.Size = new System.Drawing.Size(800, 16);
            this.BottomBar.TabIndex = 12;
            // 
            // CFormDialog
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::BookProgram.Properties.Resources.Основной_фон;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(800, 650);
            this.Controls.Add(this.Body);
            this.Controls.Add(this.TopBar);
            this.Controls.Add(this.BottomBar);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "CFormDialog";
            this.Text = "CFormDialog";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            this.TopBar.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.resizeForm)).EndInit();
            this.BottomBar.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        public System.Windows.Forms.Panel Body;
        private System.Windows.Forms.PictureBox pictureBox5;
        private System.Windows.Forms.PictureBox pictureBox4;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.Panel TopBar;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox resizeForm;
        private System.Windows.Forms.Panel BottomBar;
        private System.Windows.Forms.Label caption;
    }
}