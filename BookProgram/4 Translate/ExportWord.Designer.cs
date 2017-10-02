namespace BookProgram
{
    partial class ExportWord
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.OnlyTranc = new System.Windows.Forms.RadioButton();
            this.OnlyOrig = new System.Windows.Forms.RadioButton();
            this.button1 = new System.Windows.Forms.Button();
            this.Separat = new System.Windows.Forms.RadioButton();
            this.Tabs = new System.Windows.Forms.RadioButton();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.tableLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // OnlyTranc
            // 
            this.OnlyTranc.AutoSize = true;
            this.OnlyTranc.Dock = System.Windows.Forms.DockStyle.Fill;
            this.OnlyTranc.ForeColor = System.Drawing.Color.Black;
            this.OnlyTranc.Location = new System.Drawing.Point(4, 82);
            this.OnlyTranc.Name = "OnlyTranc";
            this.OnlyTranc.Size = new System.Drawing.Size(576, 19);
            this.OnlyTranc.TabIndex = 9;
            this.OnlyTranc.Text = "Только перевод";
            this.OnlyTranc.UseVisualStyleBackColor = true;
            this.OnlyTranc.CheckedChanged += new System.EventHandler(this.OnlyTranc_CheckedChanged);
            // 
            // OnlyOrig
            // 
            this.OnlyOrig.AutoSize = true;
            this.OnlyOrig.Dock = System.Windows.Forms.DockStyle.Fill;
            this.OnlyOrig.ForeColor = System.Drawing.Color.Black;
            this.OnlyOrig.Location = new System.Drawing.Point(4, 56);
            this.OnlyOrig.Name = "OnlyOrig";
            this.OnlyOrig.Size = new System.Drawing.Size(576, 19);
            this.OnlyOrig.TabIndex = 8;
            this.OnlyOrig.Text = "Только оригинал";
            this.OnlyOrig.UseVisualStyleBackColor = true;
            this.OnlyOrig.CheckedChanged += new System.EventHandler(this.OnlyOrig_CheckedChanged);
            // 
            // button1
            // 
            this.button1.BackgroundImage = global::BookProgram.Properties.Resources.ворд;
            this.button1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.button1.Dock = System.Windows.Forms.DockStyle.Left;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Location = new System.Drawing.Point(4, 108);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(38, 38);
            this.button1.TabIndex = 7;
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Separat
            // 
            this.Separat.AutoSize = true;
            this.Separat.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Separat.ForeColor = System.Drawing.Color.Black;
            this.Separat.Location = new System.Drawing.Point(4, 30);
            this.Separat.Name = "Separat";
            this.Separat.Size = new System.Drawing.Size(576, 19);
            this.Separat.TabIndex = 6;
            this.Separat.Text = "Перевод и оригинал отдельно";
            this.Separat.UseVisualStyleBackColor = true;
            this.Separat.CheckedChanged += new System.EventHandler(this.Separat_CheckedChanged);
            // 
            // Tabs
            // 
            this.Tabs.AutoSize = true;
            this.Tabs.Checked = true;
            this.Tabs.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Tabs.ForeColor = System.Drawing.Color.Black;
            this.Tabs.Location = new System.Drawing.Point(4, 4);
            this.Tabs.Name = "Tabs";
            this.Tabs.Size = new System.Drawing.Size(576, 19);
            this.Tabs.TabIndex = 5;
            this.Tabs.TabStop = true;
            this.Tabs.Text = "Чередовать первоод с оргигиналом";
            this.Tabs.UseVisualStyleBackColor = true;
            this.Tabs.CheckedChanged += new System.EventHandler(this.Tabs_CheckedChanged);
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.CellBorderStyle = System.Windows.Forms.TableLayoutPanelCellBorderStyle.Single;
            this.tableLayoutPanel1.ColumnCount = 1;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Controls.Add(this.button1, 0, 4);
            this.tableLayoutPanel1.Controls.Add(this.Tabs, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.Separat, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.OnlyOrig, 0, 2);
            this.tableLayoutPanel1.Controls.Add(this.OnlyTranc, 0, 3);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 6;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 25F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 25F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 25F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 25F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 44F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 19F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(584, 319);
            this.tableLayoutPanel1.TabIndex = 10;
            // 
            // ExportWord
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Transparent;
            this.Controls.Add(this.tableLayoutPanel1);
            this.Name = "ExportWord";
            this.Size = new System.Drawing.Size(584, 319);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.RadioButton OnlyTranc;
        private System.Windows.Forms.RadioButton OnlyOrig;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.RadioButton Separat;
        private System.Windows.Forms.RadioButton Tabs;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
    }
}
