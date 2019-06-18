namespace HRS
{
    public interface IBaseEmployee
    {
        int Age { get; set; }
        int ID { get; set; }
        string Name { get; set; }
        void PrintFile(IBaseEmployee employee);
    }
}