using KCNet_WinForms_Test.src;
using System.Runtime.InteropServices.ObjectiveC;

namespace KCNet_WinForms_Test
{
    // Well I figured out how to remove the extra events
    // without deleting the label or whatever is being removed.

    // 1. Open the Form1.cs designer.
    // 2. Click on the item to remove an event from, press F4 on it to bring up the properties window.
    // 3. Click on the lighting bolt to bring up the events, and remove the value from the 'Click' event.
    // 4. Remove the function in Form1.cs (This code file)

    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            // Well I set the window title in the designer, not sure where it goes in the code.
            //Form1 form = new Form1();
            //form.Text = "KCNet Test";
        }

        /// <summary>
        /// Submit button, puts the SHA256 hash below
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
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

        /// <summary>
        /// Open a file dialog
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
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

        /// <summary>
        /// Check if the file exists
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
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
