using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace RenameInFiles
{
    class SearchFiles
    {
        private StreamWriter sw;
        public void searchFiles(string text, string path, List<ChangeWord> words )
        {
            string dir = createSummary(path);
            foreach(ChangeWord word in words)
            {
                //if (text.Contains(word.oldWord) || text.Contains(word.newWord))
                //{
                //    foundWord(path, word.oldWord, dir);
                //}    
                if (text.Contains(word.oldWord))
                {
                    foundWord(path, word.oldWord, dir);
                }
            }
            //sw.Close();
        }

        private void foundWord(string path, string word, string dir)
        {
            using (StreamWriter sw = new StreamWriter(dir, true))
            {
                sw.WriteLine($"{word} was found in {path}");
            }
        }

        private string createSummary(string path)
        {
            string dir = Path.GetDirectoryName(path);
            dir = dir + @"\search summary.txt";
            if (!File.Exists(dir))
            {
                sw = File.CreateText(dir);
                sw.Close();
            }

            return dir;
        }
    }
}
