using System.Globalization;
using wedding_website.Services;

namespace wedding_website
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var builder = WebApplication.CreateBuilder(args);

            builder.Services.AddRazorPages();

            builder.Services.AddSingleton<IGuestService, GuestService>(); //Singleton, one single instance for the applications lifetime. List of _guests is not emptied every request
            builder.Services.AddScoped<IEventService, EventService>();

            var app = builder.Build();

            if (!app.Environment.IsDevelopment())
            {
                app.UseExceptionHandler("/Error");
                app.UseHsts();
            }

            app.UseHttpsRedirection();

            app.UseRouting();

            app.UseAuthorization();

            app.MapStaticAssets();
            app.MapRazorPages()
               .WithStaticAssets();

            var culture = new CultureInfo("en-GB");
            CultureInfo.DefaultThreadCurrentCulture = culture;
            CultureInfo.DefaultThreadCurrentUICulture = culture;

            app.Run();
        }
    }
}
