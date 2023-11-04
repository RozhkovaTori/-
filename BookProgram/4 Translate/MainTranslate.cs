using System;
using System.Collections.Generic;
using System.IO;
using System.Text;
using System.Windows.Forms;

namespace BookProgram
{
    public partial class MainTranslate : UserControl
    {
        public string[] original_line;
        public string[] translate_line;
        public string filepath;
        public static MainTranslate selfref { get; set; }
        public MainTranslate()
        {
            InitializeComponent();

            selfref = this;
            centering_loadpic();

            InputText it = new InputText();
            it.Dock = DockStyle.Fill;
            Controls.Add( it );
            Controls.SetChildIndex( it, 0 );

            openFileDialog1.Filter = "txt tag files (*.txtt)|*.txtt";
            saveFileDialog1.Filter = "txt tag files (*.txtt)|*.txtt";
        }
        public void centering_loadpic()
        {
            loadpic.Left = Width / 2 - loadpic.Width / 2;
            loadpic.Top = Height / 2 - loadpic.Height / 2;
        }
        private void Main_Resize( object sender, EventArgs e )
        {
            centering_loadpic();
            main_space_resize();
        }
        public void main_space_resize()
        {
            mainspace.Width = Width - 20; //20 отступ справа что бы скрол бар не загораживал 
        }
        public void init_panel()
        {
            AutoScroll = true;
            menuStrip1.Visible = true;

            original_with.Controls.Clear();
            translate_with.Controls.Clear();

            foreach( string t in original_line )
            {
                RichTextBox temp = new RichTextBox();
                temp.Dock = DockStyle.Fill;
                temp.Text = t;
                original_with.Controls.Add( temp );
            }
            foreach( string t in original_line )
            {
                RichTextBox temp = new RichTextBox();
                temp.Dock = DockStyle.Fill;
                translate_with.Controls.Add( temp );
            }
            mainspace.Height = original_with.Height + 140;
            main_space_resize();
        }
        private void открытьФайлToolStripMenuItem_Click( object sender, EventArgs e )
        {
            if( openFileDialog1.ShowDialog() == DialogResult.OK )
                if( !String.IsNullOrEmpty( File.ReadAllText( openFileDialog1.FileName, Encoding.UTF8 ) ) )
                {
                    filepath = openFileDialog1.FileName;

                    original_with.Controls.Clear();
                    translate_with.Controls.Clear();

                    original_line = new string[0];
                    translate_line = new string[0];

                    string[] temp_content = File.ReadAllLines( openFileDialog1.FileName, Encoding.UTF8 );
                    foreach( string s in temp_content )
                    {
                        string[] delimetr = s.Split( new string[] { "<delimetr>" }, StringSplitOptions.RemoveEmptyEntries );
                        Array.Resize( ref original_line, original_line.Length + 1 );
                        Array.Resize( ref translate_line, translate_line.Length + 1 );
                        original_line[original_line.Length - 1] = delimetr[0];
                        if( delimetr.Length > 1 ) translate_line[translate_line.Length - 1] = delimetr[1];
                        else translate_line[translate_line.Length - 1] = "";
                    }
                    foreach( string t in original_line )
                    {
                        RichTextBox temp = new RichTextBox();
                        temp.Dock = DockStyle.Fill;
                        temp.Text = t;
                        original_with.Controls.Add( temp );
                    }
                    foreach( string t in translate_line )
                    {
                        RichTextBox temp = new RichTextBox();
                        temp.Dock = DockStyle.Fill;
                        temp.Text = t;
                        translate_with.Controls.Add( temp );
                    }

                    mainspace.Height = original_with.Height + 140;
                    main_space_resize();

                }
                else
                {
                    CFormMessage s = new CFormMessage( "Файл пустой" );
                    s.Show();
                }
        }
        private void сохранитьToolStripMenuItem_Click( object sender, EventArgs e )
        {
            if( !String.IsNullOrEmpty( filepath ) )
            {
                save_in_file( filepath );
                CFormMessage s = new CFormMessage( "Файл сохранен" );
                s.Show();
            }
        }
        private void сохранитьКакToolStripMenuItem_Click( object sender, EventArgs e )
        {
            if( saveFileDialog1.ShowDialog() == DialogResult.OK )
            {
                save_in_file( saveFileDialog1.FileName );
                CFormMessage s = new CFormMessage( "Файл создан и сохранен" );
                s.Show();
            }
        }
        void save_in_file( string path )
        {
            string save_content = "";
            for( int i = 0; i < original_with.Controls.Count; i++ )
                save_content += original_with.Controls[i].Text + "<delimetr>" + translate_with.Controls[i].Text + "\n";
            File.WriteAllText( path, save_content, Encoding.UTF8 );
        }
        private void экспортВВордToolStripMenuItem_Click( object sender, EventArgs e )
        {
            List<string> original_temp = new List<string>();
            List<string> translate_temp = new List<string>();
            foreach( RichTextBox rt in original_with.Controls )
                original_temp.Add( rt.Text );
            foreach( RichTextBox rt in translate_with.Controls )
                translate_temp.Add( rt.Text );
            CFormDialog f = new CFormDialog( new ExportWord( original_temp.ToArray(), translate_temp.ToArray() ) );
            f.Show();
        }
        private void ввестиНовыйТекстToolStripMenuItem_Click( object sender, EventArgs e )
        {
            InputText it = new InputText();
            it.Dock = DockStyle.Fill;
            Controls.Add( it );
            Controls.SetChildIndex( it, 0 );
            menuStrip1.Visible = false;
        }
    }
}
