using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace NetworkCloud
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            configOpenFileDialog.Filter = "XML|*.xml";
            cloudConsoleContextMenuStrip.Items["toolStripMenuItemIncrease"].Click += toolStripMenuItemIncrease_Click;
            cloudConsoleContextMenuStrip.Items["toolStripMenuItemDecrease"].Click += toolStripMenuItemDecrease_Click;
            cloudConsoleContextMenuStrip.Items["toolStripMenuItemClearAll"].Click += toolStripMenuItemClearAll_Click;
        }

        private void toolStripMenuItemIncrease_Click(object sender, EventArgs e)
        {
            consoleRichTextBox.Font = new Font(consoleRichTextBox.Font.FontFamily, consoleRichTextBox.Font.Size + 1f);
        }

        private void toolStripMenuItemDecrease_Click(object sender, EventArgs e)
        {
            float newSize = consoleRichTextBox.Font.Size - 1f;
            if (newSize > 8)
            {
                consoleRichTextBox.Font = new Font(consoleRichTextBox.Font.FontFamily, newSize);
            }
        }

        private void toolStripMenuItemClearAll_Click(object sender, EventArgs e)
        {
            consoleRichTextBox.Text = string.Empty;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
        }

        private void configPathButton_Click(object sender, EventArgs e)
        {
            var result = configOpenFileDialog.ShowDialog();
            if (result == DialogResult.OK)
            {
                configPathTextBox.Text = configOpenFileDialog.FileName;
            }
        }

        private void saveConfigButton_Click(object sender, EventArgs e)
        {
#warning start server here!
        }

        private void cloudConsoleTextbox_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
