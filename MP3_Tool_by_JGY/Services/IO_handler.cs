﻿using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;

namespace Services
{
    internal class IO_handler
    {

        public List<string> GetFileNamesInPath(string path)
        {
            List<string> fileNames = new List<string>();

            foreach (var fileitem in Directory.GetFiles(path)){
                if (Path.GetExtension(fileitem) == ".mp3" )
                {
                    fileNames.Add(fileitem);
                }
            }
            return fileNames;
        }

        public DateTime checkLastFileModification(string pathOfInputFiles, string fileName) // I'm not sure what this is for but you are probably looking for FileSystemWatcher ?
        {
            DateTime lastModified = File.GetLastWriteTime(String.Format($"{pathOfInputFiles}\\{fileName}"));
            return lastModified;
        }

























        // Output
        public void createFolder(string path)
        {
            bool exists = System.IO.Directory.Exists(path);

            if (!exists)
                System.IO.Directory.CreateDirectory(path);
        }











        public void move(string inputFolder, string inputFile, string outputFolder, string outputFile)
        {
            // Create output folder
            createFolder(outputFolder);

            // Create a FileInfo  
            System.IO.FileInfo fileInfo = new System.IO.FileInfo(inputFolder + inputFile);





            try
            {
                // Check if file is there  
                if (fileInfo.Exists)
                {
                    // Copy file with a new name.  
                    fileInfo.MoveTo(outputFolder + outputFile);

                    Console.WriteLine(String.Format("File {0} moved.", outputFile));
                }
            }
            catch (Exception)
            {
                Console.WriteLine(String.Format("File already created: {0}", outputFile));
            }
        }















        public void rename(string inputFolder, string inputFile, string outputFolder, string outputFile)
        {
            // Create output folder
            createFolder(outputFolder);

            // Create a FileInfo  
            System.IO.FileInfo fileInfo = new System.IO.FileInfo(inputFolder + inputFile);





            try
            {
                // Check if file is there  
                if (fileInfo.Exists)
                {
                    // Copy file with a new name.  
                    fileInfo.MoveTo(outputFolder + outputFile);

                    Console.WriteLine(String.Format("File {0} moved.", outputFile));
                }
            }
            catch (Exception)
            {
                Console.WriteLine(String.Format("File already created: {0}", outputFile));
            }
        }
















        public void copy(string inputFolder, string inputFile, string outputFolder, string outputFile)
        {
            // Create output folder
            createFolder(outputFolder);

            // Create a FileInfo  
            System.IO.FileInfo fileInfo = new System.IO.FileInfo(inputFolder + inputFile);



            try
            {
                // Check if file is there  
                if (fileInfo.Exists)
                {
                    // Copy file with a new name.  
                    fileInfo.CopyTo(outputFolder + outputFile);

                    Console.WriteLine(String.Format("File {0} copied.", outputFile));
                }
            }
            catch (Exception)
            {
                Console.WriteLine(String.Format("File already created: {0}", outputFile));
            }
            




        }




        public void openExplorer(string folderPath)
        {
         
                if (Directory.Exists(folderPath))
                {
                    ProcessStartInfo startInfo = new ProcessStartInfo
                    {
                        Arguments = folderPath,
                        FileName = "explorer.exe"
                    };

                    Process.Start(startInfo);
                };

 
        }
    






    }
}
