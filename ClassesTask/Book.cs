using System;
using System.Collections.Generic;


public class Book
{
    /*public Book(string title, string author, string content)
    {
        Console.WriteLine("Title: " + title + " Author: " + author + " Content: " + content);
    } */

    public class Title
    {
        private Book perent;

        string title;
        public void Show(string _title)
        {
            title = _title;
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine(title);
            Console.ResetColor();
        }
    }
    public class Author
    {
        private Book perent;
        string author;
        public void Show(string _author)
        {
            author = _author;
            Console.ForegroundColor = ConsoleColor.Blue;
            Console.WriteLine(author);
            Console.ResetColor();
        }

    }
    public class Content
    {
        private Book perent;
        string content;
        public void Show(string _content)
        {
            content = _content;
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine(content);
            Console.ResetColor();
        }

    }
}