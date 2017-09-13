namespace BookProgram
{
    partial class CFormMessage
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
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.TopBar = new System.Windows.Forms.Panel();
            this.name_form = new System.Windows.Forms.Label();
            this.content_form = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            this.TopBar.SuspendLayout();
            this.SuspendLayout();
            // 
            // pictureBox3
            // 
            this.pictureBox3.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox3.BackgroundImage = global::BookProgram.Properties.Resources.н_с_закрыть;
            this.pictureBox3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox3.Dock = System.Windows.Forms.DockStyle.Right;
            this.pictureBox3.Location = new System.Drawing.Point(394, 0);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(23, 26);
            this.pictureBox3.TabIndex = 2;
            this.pictureBox3.TabStop = false;
            this.pictureBox3.Click += new System.EventHandler(this.pictureBox3_Click);
            this.pictureBox3.MouseLeave += new System.EventHandler(this.pictureBox3_MouseLeave);
            this.pictureBox3.MouseHover += new System.EventHandler(this.pictureBox3_MouseHover);
            // 
            // TopBar
            // 
            this.TopBar.BackColor = System.Drawing.Color.Transparent;
            this.TopBar.Controls.Add(this.name_form);
            this.TopBar.Controls.Add(this.pictureBox3);
            this.TopBar.Dock = System.Windows.Forms.DockStyle.Top;
            this.TopBar.Location = new System.Drawing.Point(0, 0);
            this.TopBar.Name = "TopBar";
            this.TopBar.Size = new System.Drawing.Size(417, 26);
            this.TopBar.TabIndex = 14;
            this.TopBar.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Osnova_MouseDown);
            this.TopBar.MouseMove += new System.Windows.Forms.MouseEventHandler(this.Osnova_MouseMove);
            this.TopBar.MouseUp += new System.Windows.Forms.MouseEventHandler(this.Osnova_MouseUp);
            // 
            // name_form
            // 
            this.name_form.BackColor = System.Drawing.Color.Transparent;
            this.name_form.Dock = System.Windows.Forms.DockStyle.Fill;
            this.name_form.Font = new System.Drawing.Font("Modern No. 20", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.name_form.ForeColor = System.Drawing.Color.Gainsboro;
            this.name_form.Location = new System.Drawing.Point(0, 0);
            this.name_form.Name = "name_form";
            this.name_form.Size = new System.Drawing.Size(394, 26);
            this.name_form.TabIndex = 4;
            // 
            // content_form
            // 
            this.content_form.BackColor = System.Drawing.Color.Transparent;
            this.content_form.Dock = System.Windows.Forms.DockStyle.Fill;
            this.content_form.Font = new System.Drawing.Font("Monotype Corsiva", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.content_form.ForeColor = System.Drawing.Color.Black;
            this.content_form.Location = new System.Drawing.Point(0, 26);
            this.content_form.Name = "content_form";
            this.content_form.Size = new System.Drawing.Size(417, 104);
            this.content_form.TabIndex = 15;
            // 
            // CFormMessage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.BackgroundImage = global::BookProgram.Properties.Resources.Основной_фон;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(417, 130);
            this.Controls.Add(this.content_form);
            this.Controls.Add(this.TopBar);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "CFormMessage";
            this.Text = "CFormMessage";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            this.TopBar.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.Panel TopBar;
        private System.Windows.Forms.Label content_form;
        private System.Windows.Forms.Label name_form;
    }
}