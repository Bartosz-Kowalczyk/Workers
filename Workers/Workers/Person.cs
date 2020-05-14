using System;
using System.Collections.Generic;
using System.Text;

namespace Workers
{
    class Person
    {
        public string name { get; set; }
        public string login { get; set; }
        public string password
        {
            set { password = value; }
        }
    }
}
