using System;

namespace _5pr
{
    public class Book : Publisher, IPublication
    {
        public string Author { get; set; }
        public double BasePrice { get; set; }
    
        public Book(string name, string type, int pages, string author, double basePrice)
            : base(name, type, pages)
        {
            Author = author;
            BasePrice = basePrice;
        }
    
        public void About_Company()
        {
            Console.WriteLine($"Книгу надруковано у видавництві \"33\". Автор: {Author}");
        }
    
        public double Get_Price()
        {
            return BasePrice + (Pages * 0.1);
        }
    
        public override void ShowInfo()
        {
            Console.WriteLine($"Книга: {Name}, автор: {Author}, сторінок: {Pages}, ціна: {Get_Price()} грн.");
        }
    }
}