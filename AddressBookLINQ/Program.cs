using System;
using System.Data;

namespace AddressBookLINQ
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            //UC 2
            AddressDataBook adb = new AddressDataBook();
            DataTable table = adb.AddData();
            //UC 3
            adb.DisplayAddressBook(table);
        }
    }
}
