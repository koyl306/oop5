using System;

namespace _5pr
{
    public class Magazine : Publisher, IPublication
    {
        public string Publisher { get; set; }
        public double PricePerIssue { get; set; }
    
        public Magazine(string name, string type, int pages, string publisher, double pricePerIssue)
            : base(name, type, pages)
        {
            Publisher = publisher;
            PricePerIssue = pricePerIssue;
        }
    
        public void About_Company()
        {
            Console.WriteLine($"Журнал видає компанія \"{Publisher}\".");
        }
    
        public double Get_Price()
        {
            return PricePerIssue;
        }
    
        public override void ShowInfo()
        {
            Console.WriteLine($"Журнал: {Name}, тип: {Type}, сторінок: {Pages}, ціна: {Get_Price()} грн.");
        }
    }
}