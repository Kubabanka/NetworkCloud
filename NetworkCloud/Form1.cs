using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TSST.Cloud;

namespace NetworkCloud
{
    public partial class Form1 : Form
    {
        private Cloud cloud; 

        public Form1()
        {
            InitializeComponent();
            configOpenFileDialog.Filter = "XML|*.xml";
            cloudConsoleContextMenuStrip.Items["toolStripMenuItemIncrease"].Click += toolStripMenuItemIncrease_Click;
            cloudConsoleContextMenuStrip.Items["toolStripMenuItemDecrease"].Click += toolStripMenuItemDecrease_Click;
            cloudConsoleContextMenuStrip.Items["toolStripMenuItemClearAll"].Click += toolStripMenuItemClearAll_Click;
            cloud = new Cloud();
            cloud.LinkUsed += Cloud_LinkUsed;
        }

        private void Cloud_LinkUsed(object sender, LinkUsageEventArgs e)
        {
            var message = String.Format("Message send from {0} to {1}.", e.SourceId, e.DestinationId);
            int beginning = consoleRichTextBox.Text.Length;
            consoleRichTextBox.AppendText( message + Environment.NewLine );
            if (!e.IsSuccessful)
            {
                consoleRichTextBox.SelectionStart = beginning;
                consoleRichTextBox.SelectionLength = message.Length;
                consoleRichTextBox.SelectionColor = Color.Red;
            }
            consoleRichTextBox.SelectionStart = consoleRichTextBox.Text.Length;
            consoleRichTextBox.ScrollToCaret();
        }

        private void toolStripMenuItemIncrease_Click(object sender, EventArgs e)
        {
            consoleRichTextBox.ZoomFactor += 0.5f;
        }

        private void toolStripMenuItemDecrease_Click(object sender, EventArgs e)
        {
            if (consoleRichTextBox.ZoomFactor > 1)
                consoleRichTextBox.ZoomFactor -= 0.5f;
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
            string configPath = configPathTextBox.Text;
            int port = (int) portNumericUpDown.Value;
            cloud.Initialize(configPath, port);           
        }
        
        private void cloudConsoleTextbox_TextChanged(object sender, EventArgs e)
        {
           
        }

    }
}
