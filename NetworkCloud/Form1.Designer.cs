namespace NetworkCloud
{
    partial class Form1
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
            this.components = new System.ComponentModel.Container();
            this.configGroupBox = new System.Windows.Forms.GroupBox();
            this.saveConfigButton = new System.Windows.Forms.Button();
            this.portNumericUpDown = new System.Windows.Forms.NumericUpDown();
            this.configPathButton = new System.Windows.Forms.Button();
            this.configPathTextBox = new System.Windows.Forms.TextBox();
            this.configOpenFileDialog = new System.Windows.Forms.OpenFileDialog();
            this.cloudGroupBox = new System.Windows.Forms.GroupBox();
            this.cloudTabControl = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.cloudConsoleTextbox = new System.Windows.Forms.TextBox();
            this.cloudConsoleContextMenuStrip = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.toolStripMenuItemIncrease = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItemDecrease = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItemClearAll = new System.Windows.Forms.ToolStripMenuItem();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.checkedListBox1 = new System.Windows.Forms.CheckedListBox();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.configGroupBox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.portNumericUpDown)).BeginInit();
            this.cloudGroupBox.SuspendLayout();
            this.cloudTabControl.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.cloudConsoleContextMenuStrip.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.tabPage3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // configGroupBox
            // 
            this.configGroupBox.AutoSize = true;
            this.configGroupBox.Controls.Add(this.saveConfigButton);
            this.configGroupBox.Controls.Add(this.portNumericUpDown);
            this.configGroupBox.Controls.Add(this.configPathButton);
            this.configGroupBox.Controls.Add(this.configPathTextBox);
            this.configGroupBox.Location = new System.Drawing.Point(8, 12);
            this.configGroupBox.Name = "configGroupBox";
            this.configGroupBox.Size = new System.Drawing.Size(988, 60);
            this.configGroupBox.TabIndex = 0;
            this.configGroupBox.TabStop = false;
            this.configGroupBox.Text = "Configuration";
            // 
            // saveConfigButton
            // 
            this.saveConfigButton.Location = new System.Drawing.Point(907, 18);
            this.saveConfigButton.Name = "saveConfigButton";
            this.saveConfigButton.Size = new System.Drawing.Size(75, 23);
            this.saveConfigButton.TabIndex = 3;
            this.saveConfigButton.Text = "OK";
            this.saveConfigButton.UseVisualStyleBackColor = true;
            this.saveConfigButton.Click += new System.EventHandler(this.saveConfigButton_Click);
            // 
            // portNumericUpDown
            // 
            this.portNumericUpDown.Location = new System.Drawing.Point(781, 21);
            this.portNumericUpDown.Maximum = new decimal(new int[] {
            10000,
            0,
            0,
            0});
            this.portNumericUpDown.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.portNumericUpDown.Name = "portNumericUpDown";
            this.portNumericUpDown.Size = new System.Drawing.Size(120, 20);
            this.portNumericUpDown.TabIndex = 2;
            this.portNumericUpDown.Value = new decimal(new int[] {
            5555,
            0,
            0,
            0});
            // 
            // configPathButton
            // 
            this.configPathButton.Location = new System.Drawing.Point(700, 18);
            this.configPathButton.Name = "configPathButton";
            this.configPathButton.Size = new System.Drawing.Size(75, 23);
            this.configPathButton.TabIndex = 1;
            this.configPathButton.Text = "Browse";
            this.configPathButton.UseVisualStyleBackColor = true;
            this.configPathButton.Click += new System.EventHandler(this.configPathButton_Click);
            // 
            // configPathTextBox
            // 
            this.configPathTextBox.Location = new System.Drawing.Point(7, 20);
            this.configPathTextBox.Name = "configPathTextBox";
            this.configPathTextBox.Size = new System.Drawing.Size(687, 20);
            this.configPathTextBox.TabIndex = 0;
            // 
            // cloudGroupBox
            // 
            this.cloudGroupBox.Controls.Add(this.cloudTabControl);
            this.cloudGroupBox.Location = new System.Drawing.Point(8, 78);
            this.cloudGroupBox.Name = "cloudGroupBox";
            this.cloudGroupBox.Size = new System.Drawing.Size(988, 447);
            this.cloudGroupBox.TabIndex = 1;
            this.cloudGroupBox.TabStop = false;
            this.cloudGroupBox.Text = "Cloud";
            // 
            // cloudTabControl
            // 
            this.cloudTabControl.Controls.Add(this.tabPage1);
            this.cloudTabControl.Controls.Add(this.tabPage2);
            this.cloudTabControl.Controls.Add(this.tabPage3);
            this.cloudTabControl.Location = new System.Drawing.Point(7, 19);
            this.cloudTabControl.Name = "cloudTabControl";
            this.cloudTabControl.SelectedIndex = 0;
            this.cloudTabControl.Size = new System.Drawing.Size(975, 422);
            this.cloudTabControl.TabIndex = 0;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.cloudConsoleTextbox);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(967, 396);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Console";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // cloudConsoleTextbox
            // 
            this.cloudConsoleTextbox.ContextMenuStrip = this.cloudConsoleContextMenuStrip;
            this.cloudConsoleTextbox.Location = new System.Drawing.Point(7, 4);
            this.cloudConsoleTextbox.Multiline = true;
            this.cloudConsoleTextbox.Name = "cloudConsoleTextbox";
            this.cloudConsoleTextbox.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.cloudConsoleTextbox.Size = new System.Drawing.Size(954, 386);
            this.cloudConsoleTextbox.TabIndex = 0;
            this.cloudConsoleTextbox.TextChanged += new System.EventHandler(this.cloudConsoleTextbox_TextChanged);
            // 
            // cloudConsoleContextMenuStrip
            // 
            this.cloudConsoleContextMenuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripMenuItemIncrease,
            this.toolStripMenuItemDecrease,
            this.toolStripMenuItemClearAll});
            this.cloudConsoleContextMenuStrip.Name = "cloudConsoleContextMenuStrip";
            this.cloudConsoleContextMenuStrip.Size = new System.Drawing.Size(193, 70);
            // 
            // toolStripMenuItemIncrease
            // 
            this.toolStripMenuItemIncrease.Name = "toolStripMenuItemIncrease";
            this.toolStripMenuItemIncrease.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.Up)));
            this.toolStripMenuItemIncrease.Size = new System.Drawing.Size(192, 22);
            this.toolStripMenuItemIncrease.Text = "Text size++";
            // 
            // toolStripMenuItemDecrease
            // 
            this.toolStripMenuItemDecrease.Name = "toolStripMenuItemDecrease";
            this.toolStripMenuItemDecrease.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.Down)));
            this.toolStripMenuItemDecrease.Size = new System.Drawing.Size(192, 22);
            this.toolStripMenuItemDecrease.Text = "Text size--";
            // 
            // toolStripMenuItemClearAll
            // 
            this.toolStripMenuItemClearAll.Name = "toolStripMenuItemClearAll";
            this.toolStripMenuItemClearAll.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.Delete)));
            this.toolStripMenuItemClearAll.Size = new System.Drawing.Size(192, 22);
            this.toolStripMenuItemClearAll.Text = "Clear All";
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.checkedListBox1);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Size = new System.Drawing.Size(967, 396);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Links";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // checkedListBox1
            // 
            this.checkedListBox1.FormattingEnabled = true;
            this.checkedListBox1.Items.AddRange(new object[] {
            "r",
            "ewr",
            "ew",
            "r",
            "ewr",
            "ew",
            "rr"});
            this.checkedListBox1.Location = new System.Drawing.Point(158, 23);
            this.checkedListBox1.Name = "checkedListBox1";
            this.checkedListBox1.Size = new System.Drawing.Size(120, 94);
            this.checkedListBox1.TabIndex = 0;
            // 
            // tabPage3
            // 
            this.tabPage3.Controls.Add(this.pictureBox1);
            this.tabPage3.Location = new System.Drawing.Point(4, 22);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage3.Size = new System.Drawing.Size(967, 396);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "Example 1";
            this.tabPage3.UseVisualStyleBackColor = true;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(139, 23);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(100, 50);
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1008, 537);
            this.Controls.Add(this.cloudGroupBox);
            this.Controls.Add(this.configGroupBox);
            this.Name = "Form1";
            this.Text = "Cloud";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.configGroupBox.ResumeLayout(false);
            this.configGroupBox.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.portNumericUpDown)).EndInit();
            this.cloudGroupBox.ResumeLayout(false);
            this.cloudTabControl.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.cloudConsoleContextMenuStrip.ResumeLayout(false);
            this.tabPage2.ResumeLayout(false);
            this.tabPage3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox configGroupBox;
        private System.Windows.Forms.TextBox configPathTextBox;
        private System.Windows.Forms.Button configPathButton;
        private System.Windows.Forms.NumericUpDown portNumericUpDown;
        private System.Windows.Forms.Button saveConfigButton;
        private System.Windows.Forms.OpenFileDialog configOpenFileDialog;
        private System.Windows.Forms.GroupBox cloudGroupBox;
        private System.Windows.Forms.TabControl cloudTabControl;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.TextBox cloudConsoleTextbox;
        private System.Windows.Forms.ContextMenuStrip cloudConsoleContextMenuStrip;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItemIncrease;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItemDecrease;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItemClearAll;
        private System.Windows.Forms.CheckedListBox checkedListBox1;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}

