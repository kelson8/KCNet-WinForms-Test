using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.Security.Cryptography;

// Copied from my KCNet-GiteaReleaseChecker here
// https://git.internal.kelsoncraft.net/kelson8/KCNet-GiteaReleaseChecker

namespace KCNet_WinForms_Test.src
{
    class HashFunctions
    {
        // Display the byte array in a readable format.
        // From Microsoft https://learn.microsoft.com/en-us/dotnet/api/system.security.cryptography.sha256?view=net-9.0
        public static void PrintByteArray(byte[] array)
        {
            for (int i = 0; i < array.Length; i++)
            {
                Console.Write($"{array[i]:X2}");
                if (i % 4 == 3) Console.Write(" ");
            }
            Console.WriteLine();
        }

        /// <summary>
        /// Idea from Google Gemini
        /// This works for a file, verified with 7-zip and the test.toml file.
        /// </summary>
        /// <param name="filePath">The path to the file</param>
        /// <param name="fileName">The file to run the sha256 sum on.</param>
        public static string GetChecksumFile(string filePath, string fileName)
        {
            using (SHA256 sha256 = SHA256.Create())
            {
                if (FileFunctions.FileFunctions.CheckIfFileExists(filePath, fileName))
                {
                    try
                    {
                        using (FileStream fileStream = File.OpenRead(filePath + fileName))
                        {
                            byte[] hashBytes = sha256.ComputeHash(fileStream);
                            return BitConverter.ToString(hashBytes).Replace("-", "").ToLower();
                        }
                    }
                    catch (Exception ex)
                    {

                        Console.WriteLine($"Error calculating checksum: {ex.Message}");
                        return "Error occurred";
                    }
                }
                else
                {
                    Console.WriteLine($"File not found: {filePath}/{fileName}");
                    return "File not found";
                }
            }
        }

        // TODO Make this extract the game_and_ini-debug.zip, get the SHA256 sum from the ReVC.exe in the zip, 
        // and compare with the ReVC.exe in my Rockstar Games folder, do this with a test folder first.

        // https://peterkellner.net/2010/11/24/efficiently-generating-sha256-checksum-for-files-using-csharp/

        // https://stackoverflow.com/questions/18535427/how-to-create-sha256-hash-of-downloaded-text-file

        // https://learn.microsoft.com/en-us/dotnet/api/system.security.cryptography.sha256?view=net-9.0
        //public static void GetChecksum(string filePath, string fileName)
        // Well this seems to work.
        // It prints the sha256 a bit spaced out, and does it for a whole folder.
        // TODO Make this just do one file.
        public static void GetChecksumDirectory(string filePath)
        {
            // Check if the file exists
            //if(FileFunctions.FileFunctions.CheckIfFileExists(filePath, fileName))
            //{

            //
            // Create a DirectoryInfo object representing the specified directory.

            if (Directory.Exists(filePath))
            {


                var dir = new DirectoryInfo(filePath);

                // Get the FileInfo objects for every file in the directory.
                FileInfo[] files = dir.GetFiles();
                // Initialize a SHA256 hash object.
                using (SHA256 mySHA256 = SHA256.Create())
                {
                    // Compute and print the hash values for each file in directory.
                    foreach (FileInfo fInfo in files)
                    {
                        // https://stackoverflow.com/questions/1625042/the-process-cannot-access-the-file-because-it-is-being-used-by-another-process
                        using (FileStream fileStream = fInfo.Open(FileMode.Open, FileAccess.Read, FileShare.ReadWrite))
                        {
                            try
                            {
                                // Create a fileStream for the file.
                                // Be sure it's positioned to the beginning of the stream.
                                fileStream.Position = 0;
                                // Compute the hash of the fileStream.
                                byte[] hashValue = mySHA256.ComputeHash(fileStream);
                                // Write the name and hash value of the file to the console.
                                Console.Write($"{fInfo.Name}: ");
                                PrintByteArray(hashValue);
                            }
                            catch (IOException e)
                            {
                                Console.WriteLine($"I/O Exception: {e.Message}");
                            }
                            catch (UnauthorizedAccessException e)
                            {
                                Console.WriteLine($"Access Exception: {e.Message}");
                            }
                        }
                    }
                }
            }
            //}

        }

    }
}
