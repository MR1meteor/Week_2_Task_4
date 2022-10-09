namespace Task4v2
{
    class Program
    { 
        static void Main(string[] args)
        {
            Product chocolate = new Product(28, 10, "Шоколадка");
            Product bun = new Product(chocolate);

            chocolate.SetData(70, 30);
            bun.SetData("Булочка");
        }
    }
}