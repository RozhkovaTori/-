using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BookProgram {
    public partial class InputText : UserControl {
        string content = "";
        string[] temp_end = new string[0];
        public InputText() {
            InitializeComponent();  
        }
        private void button1_Click(object sender, EventArgs e) {
            if (backgroundWorker1.IsBusy != true && !String.IsNullOrEmpty(richTextBox1.Text)) {
                content = richTextBox1.Text;
                backgroundWorker1.RunWorkerAsync();
                MainTranslate.selfref.loadpic.Visible = true;
                MainTranslate.selfref.loadpic.BringToFront();
            }
            else {
                CFormMessage s = new CFormMessage("Поле ввода пустое");
                s.Show();
            }
        }
        private void backgroundWorker1_DoWork(object sender, DoWorkEventArgs e) {
            content = content.Replace("…", "...");
            content = content.Replace("\n", " ");
            while (content.Contains("  ")) content = content.Replace("  ", " ");
            StringBuilder find = new StringBuilder(content);
            for (int i = 1; i < find.Length - 1; i++)
                if (find[i - 1] == '.' || find[i - 1] == '?' || find[i - 1] == '!' || find[i - 1] == ';')
                    if (find[i] == ' ' && (Char.IsUpper(find[i + 1]) || find[i + 1] == '-'))
                        find[i] = '~';
            string[] temp_end = find.ToString().Split('~');
            MainTranslate.selfref.original_line = temp_end;
        }
        private void backgroundWorker1_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e) {
            MainTranslate.selfref.loadpic.Visible = false;
            this.Hide();
            MainTranslate.selfref.init_panel();
        }
    }
}
