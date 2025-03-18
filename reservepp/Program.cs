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
            //Application.Run(new Form1());
            IRepository<Product> productRepository = new Repository<Product>();
            var productService = new UserService(productRepository);

            // Добавляем продукты
            var apple = new Product { Name = "Apple" };
            var banana = new Product { Name = "Banana" };

            productService.AddProduct(apple);
            productService.AddProduct(banana);

            // Выводим все продукты
            MessageBox.Show("Products after adding:", "Сообщение");
            foreach (var product in productService.GetAllProducts())
            {
                MessageBox.Show($"ID: {product.Id}, Name: {product.Name}", "Сообщение");
            }

            // Удаляем первый продукт
            productService.DeleteProduct(apple.Id);

            // Выводим продукты после удаления
            
            MessageBox.Show("After deletion:", "Сообщение");
            foreach (var product in productService.GetAllProducts())
            {
                MessageBox.Show($"ID: {product.Id}, Name: {product.Name}", "Сообщение");
            }
        }
    }
}
