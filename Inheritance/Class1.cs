using System;
using System.Collections.Generic;
using System.Text;

namespace Inheritance
{
    public class Animal
    {
        public string Breathing { get; set; }
        public string Order { get; set; }
        public string Tail { get; set; }
        public string Longevity { get; set; }
    }
    public class Bird : Animal
    {
        public string Colors { get; set; }
        public string Name { get; set; }
        public string Diet { get; set; }
        public string Size { get; set; }
    }
    public class Reptile : Animal
    {
        public string Name { get; set; }
        public string Colors { get; set; }
        public string Size { get; set; }
        public string Diet { get; set; }
    }










}
