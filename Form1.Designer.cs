namespace KCNet_WinForms_Test
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
            FilePathTextBox = new TextBox();
            FileNameTextBox = new TextBox();
            FilePathLabel = new Label();
            label2 = new Label();
            FileNameLabel = new Label();
            SubmitButton = new Button();
            Sha256SumLabel = new Label();
            OpenFileButton = new Button();
            DoesFileExistButton = new Button();
            DoesFileExistLabel = new Label();
            DoesFileExistLabelYN = new Label();
            ResetValuesButton = new Button();
            tabControl1 = new TabControl();
            SHA256_Hashing = new TabPage();
            tab2 = new TabPage();
            label3 = new Label();
            tabControl1.SuspendLayout();
            SHA256_Hashing.SuspendLayout();
            tab2.SuspendLayout();
            SuspendLayout();
            // 
            // FilePathTextBox
            // 
            FilePathTextBox.Location = new Point(3, 79);
            FilePathTextBox.Name = "FilePathTextBox";
            FilePathTextBox.Size = new Size(314, 23);
            FilePathTextBox.TabIndex = 0;
            // 
            // FileNameTextBox
            // 
            FileNameTextBox.Location = new Point(3, 147);
            FileNameTextBox.Name = "FileNameTextBox";
            FileNameTextBox.Size = new Size(144, 23);
            FileNameTextBox.TabIndex = 1;
            // 
            // FilePathLabel
            // 
            FilePathLabel.AutoSize = true;
            FilePathLabel.Location = new Point(6, 49);
            FilePathLabel.Name = "FilePathLabel";
            FilePathLabel.Size = new Size(52, 15);
            FilePathLabel.TabIndex = 2;
            FilePathLabel.Text = "File Path";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(316, 29);
            label2.Name = "label2";
            label2.Size = new Size(95, 15);
            label2.TabIndex = 3;
            label2.Text = "SHA256 Hashing";
            // 
            // FileNameLabel
            // 
            FileNameLabel.AutoSize = true;
            FileNameLabel.Location = new Point(3, 118);
            FileNameLabel.Name = "FileNameLabel";
            FileNameLabel.Size = new Size(60, 15);
            FileNameLabel.TabIndex = 4;
            FileNameLabel.Text = "File Name";
            // 
            // SubmitButton
            // 
            SubmitButton.Location = new Point(3, 176);
            SubmitButton.Name = "SubmitButton";
            SubmitButton.Size = new Size(75, 23);
            SubmitButton.TabIndex = 5;
            SubmitButton.Text = "Submit";
            SubmitButton.UseVisualStyleBackColor = true;
            SubmitButton.Click += button1_Click;
            // 
            // Sha256SumLabel
            // 
            Sha256SumLabel.AutoSize = true;
            Sha256SumLabel.Location = new Point(6, 221);
            Sha256SumLabel.Name = "Sha256SumLabel";
            Sha256SumLabel.Size = new Size(74, 15);
            Sha256SumLabel.TabIndex = 6;
            Sha256SumLabel.Text = "SHA256 sum";
            // 
            // OpenFileButton
            // 
            OpenFileButton.Location = new Point(153, 147);
            OpenFileButton.Name = "OpenFileButton";
            OpenFileButton.Size = new Size(75, 23);
            OpenFileButton.TabIndex = 7;
            OpenFileButton.Text = "Open File";
            OpenFileButton.UseVisualStyleBackColor = true;
            OpenFileButton.Click += OpenFileButton_Click;
            // 
            // DoesFileExistButton
            // 
            DoesFileExistButton.Location = new Point(84, 176);
            DoesFileExistButton.Name = "DoesFileExistButton";
            DoesFileExistButton.Size = new Size(104, 23);
            DoesFileExistButton.TabIndex = 8;
            DoesFileExistButton.Text = "Does File Exist?";
            DoesFileExistButton.UseVisualStyleBackColor = true;
            DoesFileExistButton.Click += DoesFileExistButton_Click;
            // 
            // DoesFileExistLabel
            // 
            DoesFileExistLabel.AutoSize = true;
            DoesFileExistLabel.Location = new Point(6, 247);
            DoesFileExistLabel.Name = "DoesFileExistLabel";
            DoesFileExistLabel.Size = new Size(85, 15);
            DoesFileExistLabel.TabIndex = 9;
            DoesFileExistLabel.Text = "Does File Exist?";
            // 
            // DoesFileExistLabelYN
            // 
            DoesFileExistLabelYN.AutoSize = true;
            DoesFileExistLabelYN.Location = new Point(97, 247);
            DoesFileExistLabelYN.Name = "DoesFileExistLabelYN";
            DoesFileExistLabelYN.Size = new Size(45, 15);
            DoesFileExistLabelYN.TabIndex = 10;
            DoesFileExistLabelYN.Text = "Yes/No";
            DoesFileExistLabelYN.Click += DoesFileExistLabelYN_Click;
            // 
            // ResetValuesButton
            // 
            ResetValuesButton.Location = new Point(194, 176);
            ResetValuesButton.Name = "ResetValuesButton";
            ResetValuesButton.Size = new Size(99, 23);
            ResetValuesButton.TabIndex = 12;
            ResetValuesButton.Text = "Reset Values";
            ResetValuesButton.UseVisualStyleBackColor = true;
            ResetValuesButton.Click += ResetValuesButton_Click;
            // 
            // tabControl1
            // 
            tabControl1.Controls.Add(SHA256_Hashing);
            tabControl1.Controls.Add(tab2);
            tabControl1.Location = new Point(12, 12);
            tabControl1.Name = "tabControl1";
            tabControl1.SelectedIndex = 0;
            tabControl1.Size = new Size(776, 426);
            tabControl1.TabIndex = 13;
            // 
            // SHA256_Hashing
            // 
            SHA256_Hashing.Controls.Add(label2);
            SHA256_Hashing.Controls.Add(DoesFileExistLabelYN);
            SHA256_Hashing.Controls.Add(ResetValuesButton);
            SHA256_Hashing.Controls.Add(DoesFileExistLabel);
            SHA256_Hashing.Controls.Add(FilePathLabel);
            SHA256_Hashing.Controls.Add(Sha256SumLabel);
            SHA256_Hashing.Controls.Add(FilePathTextBox);
            SHA256_Hashing.Controls.Add(FileNameLabel);
            SHA256_Hashing.Controls.Add(DoesFileExistButton);
            SHA256_Hashing.Controls.Add(FileNameTextBox);
            SHA256_Hashing.Controls.Add(OpenFileButton);
            SHA256_Hashing.Controls.Add(SubmitButton);
            SHA256_Hashing.Location = new Point(4, 24);
            SHA256_Hashing.Name = "SHA256_Hashing";
            SHA256_Hashing.Padding = new Padding(3);
            SHA256_Hashing.Size = new Size(768, 398);
            SHA256_Hashing.TabIndex = 0;
            SHA256_Hashing.Text = "SHA256 Hashing";
            SHA256_Hashing.UseVisualStyleBackColor = true;
            // 
            // tab2
            // 
            tab2.Controls.Add(label3);
            tab2.Location = new Point(4, 24);
            tab2.Name = "tab2";
            tab2.Padding = new Padding(3);
            tab2.Size = new Size(768, 398);
            tab2.TabIndex = 1;
            tab2.Text = "Tab2";
            tab2.UseVisualStyleBackColor = true;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(30, 25);
            label3.Name = "label3";
            label3.Size = new Size(179, 15);
            label3.TabIndex = 0;
            label3.Text = "Tab #2 contains nothing for now";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(tabControl1);
            Name = "Form1";
            Text = "KCNet WinForms Test";
            tabControl1.ResumeLayout(false);
            SHA256_Hashing.ResumeLayout(false);
            SHA256_Hashing.PerformLayout();
            tab2.ResumeLayout(false);
            tab2.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private TextBox FilePathTextBox;
        private TextBox FileNameTextBox;
        private Label FilePathLabel;
        private Label label2;
        private Label FileNameLabel;
        private Button SubmitButton;
        private Label Sha256SumLabel;
        private Button OpenFileButton;
        private Button DoesFileExistButton;
        private Label DoesFileExistLabel;
        private Label DoesFileExistLabelYN;
        private Button ResetValuesButton;
        private TabControl tabControl1;
        private TabPage SHA256_Hashing;
        private TabPage tab2;
        private Label label3;
    }
}
