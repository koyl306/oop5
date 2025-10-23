using System;

namespace _5pr
{
    public abstract class Publisher
    {
        public string Name { get; set; }
        public string Type { get; set; }
        public int Pages { get; set; }
    
        public Publisher(string name, string type, int pages)
        {
            Name = name;
            Type = type;
            Pages = pages;
        }
    
        public abstract void ShowInfo();
    }
}	