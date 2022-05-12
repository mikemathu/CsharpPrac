using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP
{
    internal class Book
    {
        //Instant variables
        private string title;
        private string author;
        private int pages;
        private int wordCount;

        //constructor
        public Book(string title, string author)
        {
            this.title = title;
            this.author = author;
        }

        public Book(string title, string author, int pages, int wordCount)
        {
            this.title = title;
            this.author =author;
            this.pages = pages;
            this.wordCount = wordCount;
        }

        //Methods
        //Retrive the current title of the book
        public string GetTitle()
        {
            return title;
        }

        public string GetAuthor()
        {
            return author;
        }

        //Specify the new title for the book
        public void SetTitle(string title)
        {
            this.title = title;
        }

        //Supply the text of the book and update the word count ccordingly
        public void AssignWordCountFromText(string text)
        {
            wordCount = text.Split(' ').Length;
        }
    }
}
