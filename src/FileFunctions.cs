﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

// Copied from my KCNet-GiteaReleaseChecker here
// https://git.internal.kelsoncraft.net/kelson8/KCNet-GiteaReleaseChecker

namespace FileFunctions
{
    class FileFunctions
    {
        /// <summary>
        /// Check if the file exists
        /// </summary>
        /// <param name="filePath">The file path to check</param>
        /// <param name="fileName">The file name to check</param>
        /// <returns></returns>
        public static bool CheckIfFileExists(string filePath, string fileName)
        {
            string fullPath = Path.Combine(filePath, fileName);

            //if (File.Exists(filePath + fileName))
            if (File.Exists(fullPath))
            {
                Console.WriteLine($"{filePath} {fileName}");
                return true;
            } else
            {
                Console.WriteLine($"{filePath} {fileName}");
                return false;
            }
        }
    }
}
