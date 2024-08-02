using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Obfuscator
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            this.ActiveControl = inputBox;
        }

        private void inputBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void inputBox_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                Debug.WriteLine("Enter key pressed.");
                ObfuscateButton_Click(sender, e);
                e.SuppressKeyPress = true;             }
        }
        private void ObfuscateButton_Click(object sender, EventArgs e)
        {
            string inputText = inputBox.Text.ToLower();
            string obfText = inputText.Replace("o", "0").Replace("i","1").Replace("e","3").Replace("a","4");

            outputBox.Text = obfText;
        }

        private void copyButton_Click(object sender, EventArgs e)
        {
            Clipboard.SetText(outputBox.Text);
        }
    }
} 
