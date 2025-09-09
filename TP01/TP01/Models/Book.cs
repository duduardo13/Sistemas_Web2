using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TP01.Models
{
    public class Book
    {
        //Properties
        public string name { get; set; }
        public Author[] authors { get; set; }
        public double price { get; set; }
        public int qty { get; set; }

        //Constructors
        public Book(string name, Author[] authors, double price)
        {
            this.name = name;
            this.authors = authors;
            this.price = price;
            this.qty = 0;
        }

        public Book(string name, Author[] authors, double price, int qty)
        {
            this.name = name;
            this.authors = authors;
            this.price = price;
            this.qty = qty;
        }

        public string getName()
        {
            return this.name;
        }

        public Author[] getAuthors()
        {
            return this.authors;
        }

        public double getPrice()
        {
            return this.getPrice();
        }

        public void setPrice(double price)
        {
            this.price = price;
        }

        public int getQty()
        {
            return this.qty;
        }

        public void setQty(int qty)
        {
            this.qty = qty;
        }

        public override string ToString()
        {
            var authors = string.Join(", ", this.authors.Select(a => a.ToString()));
            return $"Book[name={this.name}, authors={{{authors}}}, price={this.price}, qty={this.qty}]";
        }

        public string getAuthorNames()
        {
            var authorNames = this.authors.Select(a => a.name).ToArray();
            return string.Join(", ", authorNames);
        }
    }

}
