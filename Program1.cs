using System;

namespace _5pr
{
    class Program
    {
        static void Main(string[] args)
        {
            Magazine mag = new Magazine("Журнальчик", "Цікавий", 80, "Видавництво 22", 75.0);
            Book boo = new Book("Блакитна цятка", "Науковий", 500, "Карл Саган", 400.0);
    
            mag.ShowInfo();
            mag.About_Company();
    
            Console.WriteLine();
    
            boo.ShowInfo();
            boo.About_Company();
        }
    }
}