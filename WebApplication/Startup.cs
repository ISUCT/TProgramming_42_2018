using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.HttpsPolicy;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;// пространство имен EntityFramework
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using WebApplication.Models;// пространство имен моделей

namespace WebApplication
{
    public class Startup
    {
         /*При запуске приложения сначала срабатывает конструктор, затем метод ConfigureServices()
         и в конце метод Configure(). Эти методы вызываются средой выполнения ASP.NET. */



        public Startup(IConfiguration configuration)//конструктор
        {
            Configuration = configuration;//переопределение конфигурации???
        }

        public IConfiguration Configuration { get; }
         /*интерфейс, который наследуется от IConfiguration. 
        Данный объект хранит все конфигурационные настройки в виде набора пар "ключ"-"значение".*/

       
        public void ConfigureServices(IServiceCollection services) // регистрирует сервисы, которые используются приложением. 
        {
            string connection = Configuration.GetConnectionString("DefaultConnection");// получаем строку подключения из файла конфигурации

            services.AddDbContext<PigContext>(options =>// добавляем контекст PigContext в качестве сервиса в приложение
                options.UseSqlServer(connection));
            services.AddMvc();

            services.AddMvc().SetCompatibilityVersion(CompatibilityVersion.Version_2_2);//для совместимости версий 
            /*позволяет приложению принимать или отклонять потенциально критические изменения в поведении, появившиеся в ASP.NET Core MVC 2.1 или более поздних версий */


        }

       
        public void Configure(IApplicationBuilder app, IHostingEnvironment env)
        //устанавливает, как приложение будет обрабатывать запрос.
        /* IApplicationBuilder: механизмы для настройки конвейера запросов приложения. определяет методы Run, Map, Use
        IHostingEnvironment: позволяет взаимодействовать со средой, в которой запускается приложение*/
        {
            if (env.IsDevelopment())// если проект в процессе разработки
            {
                app.UseDeveloperExceptionPage(); 
                //app.Use... -представляют собой добавление компонентов middleware для обработки запроса.
            }
            else
            {
                app.UseExceptionHandler("/Home/Error");//путь на представления error
              
                
            }

            app.UseHttpsRedirection();//Метод UseHttpsRedirection() объекта IApplicationBuilder добавляет для проекта переадресацию на тот же ресурс только по протоколу https

          
           //дальше идет маршрут   
            app.UseMvc(routes =>
            {
                routes.MapRoute(//создает маршрут
                    name: "default",//имя маршрута
                    template: "{controller=Home}/{action=Index}/{id?}");//путь
            });
        }
    }
}
