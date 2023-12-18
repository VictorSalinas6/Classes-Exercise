namespace Classes
{
    public class Program
    {
        static void Main(string[] args)
        {
            var myCar = new Car();
            myCar.Make = "Nissan";
            myCar.Model = "Vento";
            myCar.Year = 2019;

            myCar.Properties();
        }
    }
}
