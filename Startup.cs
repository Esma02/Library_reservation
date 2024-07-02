using Microsoft.AspNetCore.Builder;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;

namespace WebApplication2
{
    public class Startup
    {
        public IConfiguration Configuration { get; }

        public Startup(IConfiguration configuration)
        {
            Configuration = configuration;
        }

        // ConfigureServices metodu, hizmetlerin (services) yapılandırılması için kullanılır
        public void ConfigureServices(IServiceCollection services)
        {
            // Controller hizmetlerini ekleyin
            services.AddControllers();
        }

        // Configure metodu, uygulamanın HTTP isteklerini nasıl işleyeceğini belirler
        public void Configure(IApplicationBuilder app)
        {
            app.UseRouting();

            // Statik dosyaların sunulmasını etkinleştirin
            app.UseDefaultFiles();
            app.UseStaticFiles();

            // Controller endpoint'lerini eşleştirin
            app.UseEndpoints(endpoints =>
            {
                endpoints.MapControllers(); // Map controllers

                // Tüm istekleri anasayfa.html dosyasına yönlendir
                endpoints.MapFallbackToFile("index.html");
            });
        }
    }
}
