using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RenameInFiles
{
    class ChangeWord
    {
        private string _oldWord;
        private string _newWord;
        
        public string oldWord
        {
            get { return this._oldWord; }
            set { this._oldWord = value; }
        }
        public string newWord
        {
            get { return this._newWord; }
            set { this._newWord = value; }
        }
    }
}
