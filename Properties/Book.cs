﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Properties
{
    internal class Book
    {
        //Instant variable
        private string title;
        private string author;
        private int pages;
        private int wordCount;

        //Constructor
        public Book(string title, string author)
        {
            //class level title = method level title
            this.title = title;
            this.author = author;
        }

        public Book(string title, string author, int pages, int wordCount)
        {
            //class level title = method level title
            this.title = title;
            this.author = author;
            this.pages = pages;
            this.wordCount = wordCount;
        }

        //Method
        //public string GetTitle()
        //{
            //return title;
        //}
        //Specify the new titile for the new book
        //public void SetTitle(string title)
        //{
            //this.title = title;
        //}

        //PROPERTIES

        //Creating properties

        public string Title
        {
            get { return title; }
            set { title = value; }
        }
        public string Author
        {
            get { return author; }
            set { author = value; }
        }




    }
}
