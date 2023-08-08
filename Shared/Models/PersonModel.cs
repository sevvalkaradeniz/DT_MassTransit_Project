﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Person.Model.Models
{
    public class PersonModel
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Surname { get; set; }
        public int Age { get; set; }

        public string Gender { get; set; }      
        public string Birthday { get; set; }
        public string City { get; set; }
    }
}
