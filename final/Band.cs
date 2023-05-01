﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace final
{
    public class Band
    {

        private string _name;

        public Band() { }

        public Band(string name)
        {
            Name = name;
        }

        public string Name 
        {
            get { return _name; }
            set { _name = value; }
        }
        public override string ToString()
        {
            return string.Format($"> {Name}\n");
        }
    }
}
