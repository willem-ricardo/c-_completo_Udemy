﻿using System;
using System.Collections.Generic;
using System.Text;

namespace Composition.Entities
{
    class Department
    {
        public string Name { get; set; }

        public Department(string name)
        {
            Name = name;
        }
    }
}
