using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO.Compression;
using System.IO;

namespace RenameInFiles
{
    class ZipOpenClose
    {
        private char[] dotZip = { '.', 'z', 'i', 'p' };
        public bool keepOldFiles = false;
        public bool searchFiles = false;
        public void open(string[] zipFiles, string directory, List<ChangeWord> words)
        {
            string tempDir = directory + @"tmpdir\";
            string vidaPerformanceLog = tempDir + "\\" + "VIDAPerformanceLog";
            string newFilename;

            DirectoryInfo drInfo = new DirectoryInfo(tempDir);

            ReadChangeFiles rcf = new ReadChangeFiles();
            rcf.searchFiles = searchFiles;

            foreach (string file in zipFiles)
            {
                removeFilesAndFolder(tempDir);

                ZipArchive newZip = ZipFile.Open(file, ZipArchiveMode.Update);
                newZip.ExtractToDirectory(tempDir);
                              
                rcf.readFile(tempDir, tempDir, words);  //reads the files and changes the chosen words

                newFilename = file.Remove(file.IndexOf('.'), 4);
                newZip.Dispose();
                close(directory, file);
            }

            removeFilesAndFolder(tempDir);
            Directory.Delete(tempDir);
        }

        private string[] getUnpackedFiles(string tmpDir)
        {
            string[] unpackedFiles;
            unpackedFiles = Directory.GetFiles(tmpDir);
            return unpackedFiles;
        }
        
        private void close(string saveFolder, string newZipName)
        {
            string oldZipName = newZipName;
            newZipName = newZipName.Remove(newZipName.IndexOf('.'), 4);
            newZipName = newZipName.Substring(newZipName.LastIndexOf('\\') + 1);
            ZipFile.CreateFromDirectory(saveFolder + @"tmpdir\", saveFolder + newZipName + "_new.zip");

            if(!keepOldFiles)
                File.Delete(oldZipName);
        }

        private void removeFilesAndFolder(string tempDir)
        {
            //deletes tmpdir and files if it exists
            if (Directory.Exists(tempDir))
            {
                Directory.Delete(tempDir, true);
            }
            //checks if tmpdir exists
            if (!Directory.Exists(tempDir))
            {
                Directory.CreateDirectory(tempDir);
            }
        }
    }
}
