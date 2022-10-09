namespace Task4v2
{
    public class Product
    {
        public static int ProductsQuantity = 0;
        public int ID { get; }
        public int Price { get; private set; }
        public int Quantity { get; private set; }
        public string Name { get; private set; }

        public Product(int price, int quantity, string name)
        {
            ProductsQuantity++;
            ID = ProductsQuantity;
            Price = price;
            Quantity = quantity;
            Name = name;
        }

        public Product(Product product)
        {
            ProductsQuantity++;
            ID = ProductsQuantity;
            Price = product.Price;
            Quantity = product.Quantity;
            Name = product.Name;
        }

        public void SetData(string name) 
        { 
            Name = name;
            Console.WriteLine($"Имя товара {ID} сменено на '{Name}'");
        }

        public void SetData(int price, int quantity) 
        { 
            Price = price;
            Quantity = quantity;
            Console.WriteLine($"Цена товара {ID} изменена и стала '{Price}', количество товара теперь '{Quantity}'");
        }
    }
}
