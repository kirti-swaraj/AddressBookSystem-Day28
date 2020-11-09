﻿// --------------------------------------------------------------------------------------------------------------------
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
            Console.WriteLine("Welcome to address book manager!");
            AddressBookDataTable.AddDataIntoTable();
            AddressBookDataTable.DisplayTableContents();
            //UC 4
            AddressBookDataTable.EditExistingContact("Virendra", "Sehwag", 136119);
            AddressBookDataTable.DisplayTableContents();
        }
    }
}