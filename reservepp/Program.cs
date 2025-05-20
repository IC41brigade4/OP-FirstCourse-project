using Microsoft.Extensions.DependencyInjection;
using reservepp.Repository;

namespace reservepp
{
    internal static class Program
    {
        private static IServiceProvider serviceProvider;

        [STAThread]
        static void Main()
        {
            var services = new ServiceCollection();

            ConfigureServices(services);

            serviceProvider = services.BuildServiceProvider();

            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            var userRepository = serviceProvider.GetRequiredService<UserRepository>();
            var orderRepository = serviceProvider.GetRequiredService<OrderRepository>();
            var userService = serviceProvider.GetRequiredService<UserService>();
            var orderService = serviceProvider.GetRequiredService<OrderService>();

            // Передаем зависимости в форму
            Application.Run(new MainForm(userRepository, orderRepository, userService, orderService));
        }

        private static void ConfigureServices(ServiceCollection services)
        {
            services.AddDbContext<AppDbContext>(options =>
                options.UseSqlite("Data Source=app.db"));

            // Регистрируем репозитории и сервисы
            services.AddScoped<UserRepository>();
            services.AddScoped<OrderRepository>();
            services.AddScoped<UserService>();
            services.AddScoped<OrderService>();

            // Зарегистрируй другие зависимости по необходимости
        }
    }
}
