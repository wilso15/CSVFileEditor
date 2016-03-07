using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSVeditor
{
    public class FileWriter
    {
        public static void WriteToFile(string filename, List<List<string>> metaData)
        {
            using (StreamWriter streamwriter = new StreamWriter(filename))

                foreach (var item in metaData)
                {
                    foreach (var x in item)
                    {
                        streamwriter.Write(x + ",");
                    }
                    streamwriter.Write(Environment.NewLine);
                }
        }
    }
}

