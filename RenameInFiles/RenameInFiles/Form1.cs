using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace RenameInFiles
{
    public partial class Form1 : Form
    {
        private List<ChangeWord> words = new List<ChangeWord>();        
        private string filePath;
        private string savePath;
        private string[] fileNameStrings;
        private bool keepOldFiles = false;
        private bool searchFiles = false;

        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog();
            ofd.Multiselect = true;
            if(ofd.ShowDialog() == DialogResult.OK)
            {
                fileNameStrings = ofd.FileNames;
                filePath = Path.GetDirectoryName(fileNameStrings[0]) + @"\";
                savePath = Path.GetDirectoryName(fileNameStrings[0]) + @"\";
            }
        }

        private void destinationDirectoryButton_Click(object sender, EventArgs e)
        {
            FolderBrowserDialog fbd = new FolderBrowserDialog();
            if (fbd.ShowDialog() == DialogResult.OK)
            {
                savePath = fbd.SelectedPath.ToString();
                savePath = savePath + @"\";
            }
        }

        private void oldWord_TextChanged(object sender, EventArgs e)
        {

        }

        private void addWordsButton_Click(object sender, EventArgs e)
        {
            bool bothWordsExist = false;
            if (newWordTextbox.ReadOnly)
                newWordTextbox.Text = "\"\"";

            if(oldWordTextbox.Text == "" || newWordTextbox.Text == "")
            {
                MessageBox.Show("If you want to remove a word use \"\" ");
            }
            else
            {
                words.Add(new ChangeWord()
                {
                    oldWord = oldWordTextbox.Text,
                    newWord = newWordTextbox.Text
                });
                bothWordsExist = true;
            }
            
            if(bothWordsExist)
            {
                ListViewItem displayWords = new ListViewItem(oldWordTextbox.Text);
                displayWords.SubItems.Add(newWordTextbox.Text);
                listView1.Items.Add(displayWords);
            }

            oldWordTextbox.Text = string.Empty;
            newWordTextbox.Text = string.Empty;
        }

        private void addToListview(ref ChangeWord words)
        {
            
        }

        private void listView1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void checkBoxSearchFiles(object sender, EventArgs e)
        {
            searchFiles = chkSearchFiles.Checked;            
            newWordTextbox.ReadOnly = true;
        }

        private void keepOldFilesCheckbox_CheckedChanged(object sender, EventArgs e)
        {
            keepOldFiles = keepOldFilesCheckbox.Checked;
        }

        private void newWordTextbox_TextChanged(object sender, EventArgs e)
        {

        }

        private void executeBtn_Click(object sender, EventArgs e)
        {
            //string filePath;
            string extension;
            int numOfFiles = 0;

            //filePath = Path.GetDirectoryName(fileNameStrings[0]) + @"\";
            extension = Path.GetExtension(fileNameStrings[0]);
            numOfFiles = fileNameStrings.Length;
            
            if(Path.GetExtension(fileNameStrings[0]) == ".zip")
            {
                ZipOpenClose zipFile = new ZipOpenClose();
                zipFile.keepOldFiles = keepOldFiles;
                zipFile.searchFiles = searchFiles;
                zipFile.open(fileNameStrings, savePath, words);
            }
            else
            {
                ReadChangeFiles rcf = new ReadChangeFiles();
                rcf.keepOldFiles = keepOldFiles;
                rcf.searchFiles = searchFiles;
                rcf.readFile(savePath, filePath, words);
            }
            listView1.Items.Clear();
        }
    }
}
