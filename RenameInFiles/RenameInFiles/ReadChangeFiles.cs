using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;


namespace RenameInFiles
{
    class ReadChangeFiles
    {
        public bool keepOldFiles;
        public bool searchFiles;
        private string saveFolder;

        public void readFile(string savePath, string filePath, List<ChangeWord> words)
        {
            string[] files = Directory.GetFiles(filePath);
            saveFolder = savePath;

            foreach(string file in files)
            {
                string text = File.ReadAllText(file,Encoding.Default);
                if(!searchFiles)
                {
                    changeFile(text, file, words);
                }                    
                else if(searchFiles)
                {
                    SearchFiles searchFiles = new SearchFiles();
                    searchFiles.searchFiles(text, file, words);
                }
            }
        }

        private void changeFile(string text, string file, List<ChangeWord> words)
        {
            foreach(ChangeWord word in words)
            {
                text = System.Text.RegularExpressions.Regex.Replace(text,
                    word.oldWord, word.newWord);              
            }
            if (Path.GetExtension(file) != ".zip")
            {
                File.WriteAllText(renameFileName(file), text);
                if(!keepOldFiles)
                    File.Delete(file);    
            }                
            else
                File.WriteAllText(file, text);
        }

        private string renameFileName(string file)
        {
            string dir = Path.GetDirectoryName(file);
            string extension = Path.GetExtension(file);
            string fileName = Path.GetFileNameWithoutExtension(file);
            file = Path.Combine(saveFolder, fileName + "_new" + extension);
                        
            return file;
        }
    }
}
