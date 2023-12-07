using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace clipboard_see
{
    public partial class Form1 : Form
    {
        string laststring_clipboard;
        public Form1()
        {
            InitializeComponent();
        }
        private  void Fn_get_clipboard()
        {
            if (Clipboard.GetText() != laststring_clipboard) { 
                laststring_clipboard=Clipboard.GetText();
                textBox1.Text += laststring_clipboard+ System.Environment.NewLine;
            }
        }
        private async void Form1_Load(object sender, EventArgs e)
        {
           
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            Fn_get_clipboard();
        }
    }
}
