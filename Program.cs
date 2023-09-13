using Fluxor;
using FluxorTest.Components;

namespace FluxorTest
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var builder = WebApplication.CreateBuilder(args);

            // Add services to the container.
            builder.Services.AddRazorComponents()
                .AddServerComponents();

            builder.Services.AddFluxor(options => options.ScanAssemblies(typeof(Program).Assembly));

            var app = builder.Build();

            // Configure the HTTP request pipeline.
            if (!app.Environment.IsDevelopment())
            {
                app.UseExceptionHandler("/Error");
            }

            app.UseStaticFiles();

            app.MapRazorComponents<App>()
              .AddServerRenderMode();

            app.Run();
        }
    }
}
