using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AddressBook
{
    class Program
    {
        static void Main(string[] args)
        {
            AddressBook ab = new AddressBook();
            ab.navigate();
            ab.WriteToFile();
            ab.writeToFavorites();
            Console.ReadLine();
            ab.ReadToFile();
            ab.ReadToFav();
            Console.ReadLine();
            
            
        }
    }
}
