using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Home_Five.model
{
    class Book
    {
        public Book() { }
        public Book( string name, string author, string description)
        {           
            this.name = name;
            this.author = author;
            this.description = description;
        }
        private int id;

        public int Id
        {
            get { return id; }
            set { id = value; }
        }
        private string name;

        public string Name
        {
            get { return name; }
            set { name = value; }
        }
        private string description;

        public string Description
        {
            get { return description; }
            set { description = value; }
        }

        private string author;

        public string Author
        {
            get { return author; }
            set { author = value; }
        }

    }
}
