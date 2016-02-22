using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AddressBook
{
    public class FileWrite
    {
       
        public void writeToFile(string filePath, string message)
        {
            using (StreamWriter sw = new StreamWriter(filePath))
            {
                sw.Write(message);
            }
        }
    }
}
