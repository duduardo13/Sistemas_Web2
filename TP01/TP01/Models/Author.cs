﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TP01.Models
{
    public class Author
    {
        public string name { get; set; }
        public string email { get; set; }
        public char gender { get; set; }

        public Author(string name, string email, char gender)
        {
            this.name = name;
            this.email = email;
            this.gender = gender;
        }

        public override string ToString()
        {
            return $"Author[name={this.name}, email={this.email}, gender={this.gender}]";
        }
    }
}
