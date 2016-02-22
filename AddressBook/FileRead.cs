using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AddressBook
{
    public class FileRead
    {
        public string fileName;

        public string readFrom(string fileName)
        {
            StreamReader reader = new StreamReader(fileName);
            string read = reader.ReadToEnd();
            reader.Close();
            return read;
        }
    }
}
