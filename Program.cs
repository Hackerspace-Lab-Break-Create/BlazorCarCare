using System;
using System.Net.Http;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Components.WebAssembly.Hosting;
using Microsoft.Extensions.DependencyInjection;
using Blazored.LocalStorage;
using Fluxor;
using BlazorCarCare.Services;

namespace BlazorCarCare
{
    public class Program
    {
        public static async Task Main(string[] args)
        {
            var builder = WebAssemblyHostBuilder.CreateDefault(args);
            builder.RootComponents.Add<App>("#app");

            var services = builder.Services;

            services.AddScoped(sp => new HttpClient { BaseAddress = new Uri(builder.HostEnvironment.BaseAddress) });

            services.AddBlazoredLocalStorage();

            services.AddScoped<CarService>();
            services.AddScoped<AlertService>();

            #region Fluxor
            services.AddFluxor(options =>
            {
                options.ScanAssemblies(System.Reflection.Assembly.GetExecutingAssembly());
                options.UseReduxDevTools(); //TODO: hide on prod
            });
            #endregion Fluxor

            await builder.Build().RunAsync();
        }
    }
}
