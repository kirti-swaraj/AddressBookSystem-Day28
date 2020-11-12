// --------------------------------------------------------------------------------------------------------------------
// <copyright file="Program.cs" company="Bridgelabz">
//   Copyright © 2018 Company
// </copyright>
// <creator Name="Kirti Swaraj"/>
// --------------------------------------------------------------------------------------------------------------------
namespace AddressBook_LINQ
{
    using System;

    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to address book manager!\n");
            AddressBookDataTable.AddDataIntoTable();
            AddressBookDataTable.DisplayTableContents();
            //UC 4
            AddressBookDataTable.EditExistingContact("Virendra", "Sehwag", 136119);
            AddressBookDataTable.DisplayTableContents();
            //UC 5
            AddressBookDataTable.DeleteContact("Virendra", "Sehwag");
            AddressBookDataTable.DisplayTableContents();
            //UC 6
            AddressBookDataTable.RetrievePersonFromACityOrState("Mumbai", "Karnataka");
            //UC 7
            AddressBookDataTable.GetCountOfContactInCityOrState();
        }
    }
}