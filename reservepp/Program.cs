using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
namespace reservepp
{
    public class Product
    {
        public int Id { get; set; }
        public string Name { get; set; }
    }

    internal static class Program
    {

        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new RegisterForm());

            IRepository<Product> productRepository = new Repository<Product>();
            var productService = new UserService(productRepository);

            // Додавання продукту
            var apple = new Product { Name = "Apple" };
            var banana = new Product { Name = "Banana" };

            productService.AddProduct(apple);
            productService.AddProduct(banana);

            // Виводимо всі продукти
            MessageBox.Show("Products after adding:", "Сообщение");
            foreach (var product in productService.GetAllProducts())
            {
                MessageBox.Show($"ID: {product.Id}, Name: {product.Name}", "Сообщение");
            }

            // Видаляємо перший продукт 
            productService.DeleteProduct(apple.Id);

            // Виводимо продукти після видалення
            
            MessageBox.Show("After deletion:", "Сообщение");
            foreach (var product in productService.GetAllProducts())
            {
                MessageBox.Show($"ID: {product.Id}, Name: {product.Name}", "Сообщение");
            }
            
        }
    }
}
