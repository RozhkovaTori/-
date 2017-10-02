using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Word = Microsoft.Office.Interop.Word;

namespace BookProgram {
    public partial class ExportWord : UserControl {
        string[] original, translate;
        int mod = 1; // 1 - default 2 3 4
        public ExportWord(string[] original_trade, string[] translate_trade) {
            InitializeComponent();
           
            original = original_trade;
            translate = translate_trade;
        }
        private void button1_Click(object sender, EventArgs e) {
            string content = "";
            if (mod == 1)
                for (int i = 0; i < original.Length; i++)
                    content += original[i] + "\n" + translate[i] + "\n";
            if (mod == 2) {
                content += "Оригинал\n";
                foreach (string s in original)
                    content += s + " ";
                content += "Перевод\n";
                foreach (string s in translate)
                    content += s + " ";
            }
            if (mod == 3)
                foreach (string s in original)
                    content += s + " ";
            if (mod == 4)
                foreach (string s in translate)
                    content += s + " ";
            export(content);
            CFormDialog.CRefDialog.CloseCFormDialog();
        }
        void export(string text) {
            try {
                Microsoft.Office.Interop.Word.Application winword =
                    new Microsoft.Office.Interop.Word.Application();

                winword.Visible = false;


                object missing = System.Reflection.Missing.Value;

                //Создание нового документа
                Microsoft.Office.Interop.Word.Document document =
                    winword.Documents.Add(ref missing, ref missing, ref missing, ref missing);

                //добавление новой страницы
                winword.Selection.InsertNewPage();

                //Добавление текста в документ
                document.Content.SetRange(0, 0);
                document.Content.Text = text + Environment.NewLine;

                winword.Visible = true;
            }
            catch (Exception ex) {
                CFormMessage s = new CFormMessage(ex.Message);
                s.Show();
            }
        }
        private void Tabs_CheckedChanged(object sender, EventArgs e) { mod = 1; }
        private void Separat_CheckedChanged(object sender, EventArgs e) { mod = 2; }
        private void OnlyOrig_CheckedChanged(object sender, EventArgs e) { mod = 3; }
        private void OnlyTranc_CheckedChanged(object sender, EventArgs e) { mod = 4; }
    }
}
