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
            SuspendLayout();
            // 
            // FilePathTextBox
            // 
            FilePathTextBox.Location = new Point(12, 78);
            FilePathTextBox.Name = "FilePathTextBox";
            FilePathTextBox.Size = new Size(314, 23);
            FilePathTextBox.TabIndex = 0;
            // 
            // FileNameTextBox
            // 
            FileNameTextBox.Location = new Point(12, 142);
            FileNameTextBox.Name = "FileNameTextBox";
            FileNameTextBox.Size = new Size(144, 23);
            FileNameTextBox.TabIndex = 1;
            // 
            // FilePathLabel
            // 
            FilePathLabel.AutoSize = true;
            FilePathLabel.Location = new Point(12, 60);
            FilePathLabel.Name = "FilePathLabel";
            FilePathLabel.Size = new Size(52, 15);
            FilePathLabel.TabIndex = 2;
            FilePathLabel.Text = "File Path";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(348, 9);
            label2.Name = "label2";
            label2.Size = new Size(95, 15);
            label2.TabIndex = 3;
            label2.Text = "SHA256 Hashing";
            // 
            // FileNameLabel
            // 
            FileNameLabel.AutoSize = true;
            FileNameLabel.Location = new Point(12, 113);
            FileNameLabel.Name = "FileNameLabel";
            FileNameLabel.Size = new Size(60, 15);
            FileNameLabel.TabIndex = 4;
            FileNameLabel.Text = "File Name";
            // 
            // SubmitButton
            // 
            SubmitButton.Location = new Point(12, 181);
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
            Sha256SumLabel.Location = new Point(12, 267);
            Sha256SumLabel.Name = "Sha256SumLabel";
            Sha256SumLabel.Size = new Size(74, 15);
            Sha256SumLabel.TabIndex = 6;
            Sha256SumLabel.Text = "SHA256 sum";
            // 
            // OpenFileButton
            // 
            OpenFileButton.Location = new Point(162, 141);
            OpenFileButton.Name = "OpenFileButton";
            OpenFileButton.Size = new Size(75, 23);
            OpenFileButton.TabIndex = 7;
            OpenFileButton.Text = "Open File";
            OpenFileButton.UseVisualStyleBackColor = true;
            OpenFileButton.Click += OpenFileButton_Click;
            // 
            // DoesFileExistButton
            // 
            DoesFileExistButton.Location = new Point(93, 181);
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
            DoesFileExistLabel.Location = new Point(12, 308);
            DoesFileExistLabel.Name = "DoesFileExistLabel";
            DoesFileExistLabel.Size = new Size(85, 15);
            DoesFileExistLabel.TabIndex = 9;
            DoesFileExistLabel.Text = "Does File Exist?";
            // 
            // DoesFileExistLabelYN
            // 
            DoesFileExistLabelYN.AutoSize = true;
            DoesFileExistLabelYN.Location = new Point(103, 308);
            DoesFileExistLabelYN.Name = "DoesFileExistLabelYN";
            DoesFileExistLabelYN.Size = new Size(45, 15);
            DoesFileExistLabelYN.TabIndex = 10;
            DoesFileExistLabelYN.Text = "Yes/No";
            // 
            // ResetValuesButton
            // 
            ResetValuesButton.Location = new Point(203, 181);
            ResetValuesButton.Name = "ResetValuesButton";
            ResetValuesButton.Size = new Size(99, 23);
            ResetValuesButton.TabIndex = 12;
            ResetValuesButton.Text = "Reset Values";
            ResetValuesButton.UseVisualStyleBackColor = true;
            ResetValuesButton.Click += ResetValuesButton_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(ResetValuesButton);
            Controls.Add(DoesFileExistLabelYN);
            Controls.Add(DoesFileExistLabel);
            Controls.Add(DoesFileExistButton);
            Controls.Add(OpenFileButton);
            Controls.Add(Sha256SumLabel);
            Controls.Add(SubmitButton);
            Controls.Add(FileNameLabel);
            Controls.Add(label2);
            Controls.Add(FilePathLabel);
            Controls.Add(FileNameTextBox);
            Controls.Add(FilePathTextBox);
            Name = "Form1";
            Text = "KCNet WinForms Test";
            ResumeLayout(false);
            PerformLayout();
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
    }
}
