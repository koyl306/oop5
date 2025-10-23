namespace _5pr
{
    public interface IPublication
    {
        string Name { get; set; }
        string Type { get; set; }
    
        void About_Company();
        double Get_Price();
    }
}