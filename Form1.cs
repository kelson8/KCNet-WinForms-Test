using KCNet_WinForms_Test.src;
using System.Runtime.InteropServices.ObjectiveC;

namespace KCNet_WinForms_Test
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        // This was a test.
        private void label1_Click(object sender, EventArgs e)
        {

        }

        // Submit button
        // TODO Make this work on other directories, it only works on "./"
        private void button1_Click(object sender, EventArgs e)
        {
            string filePath = FilePathTextBox.Text + "\\";
            string fileName = FileNameTextBox.Text;


            if (filePath != null && fileName != null)
            {
                string fileHash = HashFunctions.GetChecksumFile(filePath, fileName);


                // Combine the filePath and fileName to check it
                //string fullPath = Path.Combine(filePath, fileName);
                //MessageBox.Show($"Trying to access {fullPath}");


                // TODO Make this work properly if the file isn't found, instead of displaying "SHA256 of file"
                //Sha256SumLabel.Text = $"SHA256 of file {filePath}{fileName}: {fileHash}";
                Sha256SumLabel.Text = $"SHA256 of file {fileName}: {fileHash}";

                //Sha256SumLabel.Text = $"File path: {filePath} File name: {fileName}";
            }



        }

        private void OpenFileButton_Click(object sender, EventArgs e)
        {
            // Add a open file dialog
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.Filter = "All files (*.*)|*.*";
            openFileDialog.Title = "Select a file";

            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                FilePathTextBox.Text = Path.GetDirectoryName(openFileDialog.FileName);
                FileNameTextBox.Text = Path.GetFileName(openFileDialog.FileName);


                //string fullPath = Path.Combine(filePath, fileName);
                //MessageBox.Show($"Trying to access {fullPath}");
            }
        }

        private void DoesFileExistButton_Click(object sender, EventArgs e)
        {
            string filePath = FilePathTextBox.Text;
            string fileName = FileNameTextBox.Text;

            if (filePath != null && fileName != null)
            {
                if (FileFunctions.FileFunctions.CheckIfFileExists(filePath, fileName))
                {
                    DoesFileExistLabelYN.Text = $"File {fileName} exists.";
                }
                else
                {
                    DoesFileExistLabelYN.Text = $"File {fileName} doesn't exist.";
                }
            }

        }


        private void label1_Click_1(object sender, EventArgs e)
        {

        }

        private void label1_Click_2(object sender, EventArgs e)
        {

        }

        /// <summary>
        /// Reset all values back to nothing
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void ResetValuesButton_Click(object sender, EventArgs e)
        {
            DoesFileExistLabelYN.Text = "";
            FilePathTextBox.Text = "";
            FileNameTextBox.Text = "";
            Sha256SumLabel.Text = "";
        }
    }
}
