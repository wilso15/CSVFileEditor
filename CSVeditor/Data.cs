using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSVeditor
{
    public class Data
    {
        List<List<string>> mainListData;
        public Data(List<List<string>> mainListData)
        {
            this.mainListData = new List<List<string>>();
        }

        public List<string> CreateNewList()
        {
            List <string> nameList = new List<string>();
            return nameList;
        }

        public void WriteMainListToFile(List<List<string>> y)
        {
            FileWriter.WriteToFile("../../CSVeditor.txt", y);
        }
    }
}

