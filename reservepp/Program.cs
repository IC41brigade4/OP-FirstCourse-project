

using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using Microsoft.Extensions.Logging;

namespace reservepp
{
    public class Program
    {
        private static IServiceProvider _serviceProvider;

        [STAThread]
        public static void Main(string[] args)
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            SQLitePCL.Batteries.Init();
            var host = CreateHostBuilder(args).Build();
            _serviceProvider = host.Services;

            // Створення бази даних при запуску
            using (var scope = _serviceProvider.CreateScope())
            {
                var context = scope.ServiceProvider.GetRequiredService<AppDbContext>();
                context.Database.EnsureCreated();
            }

            // Запуск головної форми
            using (var scope = _serviceProvider.CreateScope())
            {
                var mainForm = scope.ServiceProvider.GetRequiredService<MainForm>();
                Application.Run(mainForm);
            }
        }

        public static IHostBuilder CreateHostBuilder(string[] args) =>
    Host.CreateDefaultBuilder(args)
        .ConfigureLogging(logging =>
        {
            logging.ClearProviders();    // Відключаємо всі провайдери
            logging.AddConsole();        // Додаємо консольний логгер (підтримується всюди)
            // Не додаємо AddEventLog(), щоб уникнути помилки
        })
        .ConfigureServices((hostContext, services) =>
        {
            // Налаштування DbContext
            services.AddDbContext<AppDbContext>(options =>
                options.UseSqlite("Data Source=app.db"));

            // Реєстрація репозиторіїв
            services.AddScoped<UserRepository>();
            services.AddScoped<OrderRepository>();

            // Реєстрація сервісів
            services.AddScoped<IUserService, UserService>();
            services.AddScoped<IOrderService, OrderService>();

            // Реєстрація фабрик
            services.AddScoped<UserActionFactory>();

            // Реєстрація форм
            services.AddScoped<MainForm>();
            services.AddScoped<LoginForm>();
            services.AddScoped<RegisterForm>();
            services.AddScoped<OfficerForm>();
            services.AddScoped<ConscriptForm>();
            services.AddScoped<TCKForm>();
            services.AddScoped<OfficerOrder>();
        });

        // Метод для автентифікації
        public static bool LetMeIn(string password, int docId, IUserService userService)
        {
            return userService.AuthenticateUser(docId, password);
        }

        // Метод для отримання сервіс-провайдера
        public static IServiceProvider GetServiceProvider()
        {
            return _serviceProvider;
        }
    }
}