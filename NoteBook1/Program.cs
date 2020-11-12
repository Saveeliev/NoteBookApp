using System;
using System.Windows.Forms;
using DataBase;
using Infrastructure;
using Infrastructure.Services;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;

namespace NoteBookApp
{
    internal static class Program
    {
        [STAThread]
        private static void Main()
        {
            var host = Host.CreateDefaultBuilder()
               .ConfigureServices((context, serviceCollection) =>
               {
                   ConfigureServices(context.Configuration, serviceCollection);
               })
               .Build();

            Application.SetHighDpiMode(HighDpiMode.SystemAware);
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            var services = host.Services;

            var mainForm = services.GetRequiredService<MainForm>();
            Application.Run(mainForm);
        }

        private static void ConfigureServices(IConfiguration configuration,
        IServiceCollection services)
        {
            services.AddSingleton<MainForm>();
            services.AddSingleton<AddNoteForm>();
            services.AddSingleton<NotesBuilder>();
            services.AddSingleton<AccountForm>();

            services.AddScoped<LoginControl>();
            services.AddScoped<RegisterControl>();
            services.AddTransient<UserInterfaceControl>();

            services.AddScoped<IUserService, UserService>();
            services.AddScoped<INoteService, NoteService>();
            services.AddScoped<IDataProvider, DataProvider>();

            services.AddDbContext<Context>();
        }
    }
}