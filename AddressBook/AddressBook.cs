using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AddressBook
{
    public class AddressBook
    {
        List<Entries> entries = new List<Entries>();
        List<Favorites> favorites = new List<Favorites>();
        FileWrite fw = new FileWrite();

        public void navigate()
        {
            Console.WriteLine("select: search, add, add to fav, display fav");
            Console.ReadLine();
            string input = Console.ReadLine();

            switch (input)
            {
                case "search":
                    navigate();
                    break;
                case "add":
                    createEntry();
                    break;
                
            }
        }
        public AddressBook()
        {
            Entries Drew = new Entries("Drew", "Otteson", "713 Oakfield St", "2622476444");
            entries.Add(Drew);
        }
        public void WriteToFile()
        {
            string beingWritten = ("AddressBook" + Environment.NewLine);
            foreach (Entries entry in entries)
            {
                beingWritten += (Environment.NewLine + "" + entry.ToString());
            }
            fw.writeToFile("book.txt", beingWritten);
        }
        public void writeToFavorites()
        {
            string beingwritten = ("Favorites" + Environment.NewLine);
            foreach (Entries entry in entries)
            {
                beingwritten += (Environment.NewLine + "" + entry.ToString());
            }
            fw.writeToFile("favorite.txt", beingwritten);
        }
        public void ReadToFile()
        {
            StreamReader file = new StreamReader("book.txt");
            string read = file.ReadToEnd();
            Console.WriteLine(read);
            file.Close();
            Console.ReadLine();
        }
        public void ReadToFav()
        {
            StreamReader file = new StreamReader("favorite.txt");
            string read = file.ReadToEnd();
            Console.WriteLine(read);
            file.Close();
            Console.ReadLine();
        }
        public string takeUserInput(string input)
        {
            Console.WriteLine(input);
            string userInput = Console.ReadLine();
            return input;
        }
        public void createEntry()
        {
            string Name;
            string lastName;
            string Address;
            string phoneNumber;

            Name = takeUserInput("Enter first name");
            lastName = takeUserInput("Enter last name");
            Address = takeUserInput("Enter address");
            phoneNumber = takeUserInput("Enter phone number");

            entries.Add(new Entries(Name, lastName, Address, phoneNumber));
        }
        //public void searchUser(string entry)
        //{
        //    for (int i = 0; i < entries.Count; i++)
        //    {
        //        Entries search = entries[i];
        //        string searchName = search.Name;
        //    }
        }
    }

