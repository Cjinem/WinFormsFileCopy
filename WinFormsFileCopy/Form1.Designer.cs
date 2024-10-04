namespace WinFormsFileCopy
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            panel1 = new Panel();
            btnClose = new Button();
            btnCopy = new Button();
            label3 = new Label();
            chkRecursive = new CheckBox();
            btnDestDir = new Button();
            btnSourceDir = new Button();
            label2 = new Label();
            label1 = new Label();
            cboFilter = new ComboBox();
            cboDest = new ComboBox();
            cboSource = new ComboBox();
            listBox1 = new ListBox();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = SystemColors.ActiveBorder;
            panel1.Controls.Add(btnClose);
            panel1.Controls.Add(btnCopy);
            panel1.Controls.Add(label3);
            panel1.Controls.Add(chkRecursive);
            panel1.Controls.Add(btnDestDir);
            panel1.Controls.Add(btnSourceDir);
            panel1.Controls.Add(label2);
            panel1.Controls.Add(label1);
            panel1.Controls.Add(cboFilter);
            panel1.Controls.Add(cboDest);
            panel1.Controls.Add(cboSource);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(800, 269);
            panel1.TabIndex = 0;
            // 
            // btnClose
            // 
            btnClose.Location = new Point(543, 155);
            btnClose.Name = "btnClose";
            btnClose.Size = new Size(140, 23);
            btnClose.TabIndex = 10;
            btnClose.Text = "Close";
            btnClose.UseVisualStyleBackColor = true;
            btnClose.Click += btnClose_Click;
            // 
            // btnCopy
            // 
            btnCopy.Location = new Point(543, 126);
            btnCopy.Name = "btnCopy";
            btnCopy.Size = new Size(140, 23);
            btnCopy.TabIndex = 9;
            btnCopy.Text = "Copy";
            btnCopy.UseVisualStyleBackColor = true;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(543, 60);
            label3.Name = "label3";
            label3.Size = new Size(33, 15);
            label3.TabIndex = 8;
            label3.Text = "Filter";
            // 
            // chkRecursive
            // 
            chkRecursive.AutoSize = true;
            chkRecursive.Location = new Point(352, 83);
            chkRecursive.Name = "chkRecursive";
            chkRecursive.Size = new Size(73, 19);
            chkRecursive.TabIndex = 7;
            chkRecursive.Text = "recursive";
            chkRecursive.UseVisualStyleBackColor = true;
            // 
            // btnDestDir
            // 
            btnDestDir.AutoSize = true;
            btnDestDir.BackColor = SystemColors.ButtonFace;
            btnDestDir.Location = new Point(318, 146);
            btnDestDir.Name = "btnDestDir";
            btnDestDir.Size = new Size(28, 25);
            btnDestDir.TabIndex = 6;
            btnDestDir.Text = "...";
            btnDestDir.UseVisualStyleBackColor = false;
            // 
            // btnSourceDir
            // 
            btnSourceDir.AutoSize = true;
            btnSourceDir.BackColor = SystemColors.ButtonFace;
            btnSourceDir.Location = new Point(318, 81);
            btnSourceDir.Name = "btnSourceDir";
            btnSourceDir.Size = new Size(28, 25);
            btnSourceDir.TabIndex = 5;
            btnSourceDir.Text = "...";
            btnSourceDir.UseVisualStyleBackColor = false;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(63, 126);
            label2.Name = "label2";
            label2.Size = new Size(67, 15);
            label2.TabIndex = 4;
            label2.Text = "Destination";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(66, 60);
            label1.Name = "label1";
            label1.Size = new Size(43, 15);
            label1.TabIndex = 3;
            label1.Text = "Source";
            // 
            // cboFilter
            // 
            cboFilter.FormattingEnabled = true;
            cboFilter.Items.AddRange(new object[] { "*.*", "*.pdf", "*.png" });
            cboFilter.Location = new Point(543, 83);
            cboFilter.Name = "cboFilter";
            cboFilter.Size = new Size(160, 23);
            cboFilter.TabIndex = 2;
            cboFilter.Text = "*.*";
            // 
            // cboDest
            // 
            cboDest.FormattingEnabled = true;
            cboDest.Items.AddRange(new object[] { "C:\\temp1", "C:\\temp2" });
            cboDest.Location = new Point(63, 146);
            cboDest.Name = "cboDest";
            cboDest.Size = new Size(249, 23);
            cboDest.TabIndex = 1;
            cboDest.Text = "C:\\temp2";
            // 
            // cboSource
            // 
            cboSource.FormattingEnabled = true;
            cboSource.Items.AddRange(new object[] { "C:\\temp1", "C:\\temp2" });
            cboSource.Location = new Point(63, 81);
            cboSource.Name = "cboSource";
            cboSource.Size = new Size(249, 23);
            cboSource.TabIndex = 0;
            cboSource.Text = "C:\\temp1";
            // 
            // listBox1
            // 
            listBox1.Dock = DockStyle.Bottom;
            listBox1.FormattingEnabled = true;
            listBox1.ItemHeight = 15;
            listBox1.Location = new Point(0, 266);
            listBox1.Name = "listBox1";
            listBox1.Size = new Size(800, 184);
            listBox1.TabIndex = 1;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(listBox1);
            Controls.Add(panel1);
            Name = "Form1";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "WinFormsFileCopy";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Button btnClose;
        private Button btnCopy;
        private Label label3;
        private CheckBox chkRecursive;
        private Button btnDestDir;
        private Button btnSourceDir;
        private Label label2;
        private Label label1;
        private ComboBox cboFilter;
        private ComboBox cboDest;
        private ComboBox cboSource;
        private ListBox listBox1;
    }
}
