using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Diagnostics;
using System.IO;
using System.Windows.Forms;

namespace Services
{
    internal class IO_handler
    {




        // Input
        public List<string> loadFiles(string pathOfInputFiles)
        {
            List<string> fileNames = Directory.EnumerateFiles(pathOfInputFiles).Select(x => x.Substring(pathOfInputFiles.Length)).ToList();


            for (int i = 0;i<fileNames.Count;i++)
                {
                    if (!fileNames.ElementAt(i).Contains(".mp3")) { fileNames.RemoveAt(i); }
                }

            
            return fileNames;
        }


        public DateTime checkLastFileModification(string pathOfInputFiles, string fileName)
        {
            DateTime lastModified = System.IO.File.GetLastWriteTime(String.Format("{0}\\{1}", pathOfInputFiles, fileName));

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
