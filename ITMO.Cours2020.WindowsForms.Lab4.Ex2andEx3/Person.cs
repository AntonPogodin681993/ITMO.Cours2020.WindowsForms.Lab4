﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ITMO.Cours2020.WindowsForms.Lab4.Ex2
{
    public class Person
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public int Age { get; set; }

        public override string ToString()
        {
            return LastName + " " + FirstName + "\nВозраст:" + Age + "\n";
        }
    }
}
