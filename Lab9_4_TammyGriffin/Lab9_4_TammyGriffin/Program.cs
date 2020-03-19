﻿using System;
using System.Collections.Generic;
using System.Text;
using System.IO;


namespace Lab9_4_TammyGriffin
{
    class TitleHeader
    {
        public const string open = "<h1>";
        public const string close = "</h1>";

        public string CreateHeader(string text)
        {
            string TitleHeader = String.Concat(open, text, close, "\n");
            return TitleHeader;
        }
    }

    class UnorderedList
    {
        public const string open = "<ul>";
        public const string close = "</ul>";

        public string CreateListItem(string text)
        {
            string open = "<li>\n";
            string close = "</li>\n";
            string listItem = String.Concat(open, text, close, "\n");
            return listItem;
        }

        public StringBuilder CreateList(string[] listItems)
        {
            StringBuilder sb = new StringBuilder();
            sb.Append(open);
            foreach (string item in listItems)
            {
                sb.Append(item);
            }
            sb.Append(close);
            return sb;
        }
        class Program
        {
            static void Main(string[] args)
            {
                string filename = "C://weblogs//9_4Lab.html";
                TitleHeader header = new TitleHeader();
                UnorderedList list = new UnorderedList();
                StringBuilder sb = new StringBuilder();

                Console.WriteLine("Enter text for HTML header.");
                string headerElement = header.CreateHeader(Console.ReadLine());
                string[] listItems = new string[3];

                for (int i = 0; i < listItems.Length; i++)
                {
                    Console.WriteLine("Add another item to the list.");
                    listItems[i] = list.CreateListItem(Console.ReadLine());
                }

                StringBuilder listElement = list.CreateList(listItems);
                sb.Append(headerElement);
                sb.Append(listElement.ToString());

                File.AppendAllText(filename, sb.ToString());
            }

        }
    }

}

