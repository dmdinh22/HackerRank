using System;
using System.Collections.Generic;
using System.IO;

namespace HackerRank.ThirtyDOC
{
    abstract class Book
    {
        protected String title;
        protected String author;

        public Book(String t, String a)
        {
            title = t;
            author = a;
        }
        public abstract void display();
    }
    class MyBook : Book
    {
        private int price = 0;

        public MyBook(string title, string author, int price) : base(title, author)
        {
            this.price = price;
        }

        public override void display()
        {
            Console.WriteLine("Title: {0} \nAuthor: {1} \nPrice: {2}", title, author, price);
        }
    }

}