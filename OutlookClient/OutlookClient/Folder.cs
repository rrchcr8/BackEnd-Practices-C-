using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OutlookClient
{
    public class Folder
    {

        public String FolderName { get; set; }
        public List<Message> Content { get; set; }

        public Folder(string folderName)
        {
            FolderName = folderName;
            this.Content = new List<Message>();
        }

        

    }
}
