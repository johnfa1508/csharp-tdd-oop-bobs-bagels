﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace exercise.main.Persons
{
    public class Manager : Person
    {
        public Manager(string name, bool isManager) : base(name, isManager) 
        {
            IsManager = true;
        }
    }
}
