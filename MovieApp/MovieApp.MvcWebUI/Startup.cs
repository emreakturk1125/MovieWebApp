using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.Extensions.DependencyInjection;

namespace MovieApp.MvcWebUI
{
    public class Startup
    {
        
        public void ConfigureServices(IServiceCollection services)
        {
            services.AddMvc(); // mvc servisini eklememiz gerekiyor aşağıda da aktif et
        }

         
        public void Configure(IApplicationBuilder app, IHostingEnvironment env)
        {
            app.UseMvcWithDefaultRoute();// aktif et
            //app.UseDeveloperExceptionPage(); // hata sayfalarını, detaylarını gösteriri yanlız yayınlarken bunu kapatman gerekiyor

            // proje geliştirme aşamasında hata sayfalarını göstermek istiyorsan
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }
            // static(html,css,javascript,picture) dosyalara yada sayfalara proje içinde ulaşmayı sağlar
            app.UseStaticFiles();
            app.UseStatusCodePages(); // durum kodlarını döndürmesi için

            app.UseMvc(routes =>
            {
                routes.MapRoute(
                    name: "default",
                    template: "{controller=Home}/{action=Index}/{id?}");
            });
        }
    }
}
