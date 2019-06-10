namespace HelloWorld
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using HelloWorld.Models;   // пространство имен моделей
    using Microsoft.AspNetCore.Builder;
    using Microsoft.AspNetCore.Hosting;
    using Microsoft.AspNetCore.Http;
    using Microsoft.EntityFrameworkCore; // пространство имен EntityFramework
    using Microsoft.Extensions.Configuration;
    using Microsoft.Extensions.DependencyInjection;
    using Microsoft.Extensions.Logging;
    using Swashbuckle.AspNetCore.Swagger;
    using Microsoft.AspNetCore.Routing;

    public class Startup
    {
        /*При запуске приложения сначала срабатывает конструктор, затем метод ConfigureServices()
         и в конце метод Configure(). Эти методы вызываются средой выполнения ASP.NET. */
        
        
        public Startup(IHostingEnvironment env)//конструктор
        {
            var builder = new ConfigurationBuilder()//создание новой конфигурации
                .SetBasePath(env.ContentRootPath)
                .AddJsonFile("appsettings.json", optional: false, reloadOnChange: true);
            Configuration = builder.Build();
             
        }

        public IConfigurationRoot Configuration { get; }
        /*интерфейс, который наследуется от IConfiguration. 
        Данный объект хранит все конфигурационные настройки в виде набора пар "ключ"-"значение".*/
        public void ConfigureServices(IServiceCollection services)// регистрирует сервисы, которые используются приложением. 
        {
            string connection = Configuration.GetConnectionString("DefaultConnection");
            services.AddDbContext<PigsContext>(options =>
                options.UseSqlServer(connection));
            services.AddCors();
            services.AddMvc()// добавление сервисов фреймворка MVC
                .AddControllersAsServices();
            services.AddSwaggerGen(c =>
            {
                c.SwaggerDoc("v1", new Info { Title = "My API", Version = "v1" });
            });
            services.AddRouting();

        }

       
        public void Configure(IApplicationBuilder app, IHostingEnvironment env, ILoggerFactory loggerFactory)
        //устанавливает, как приложение будет обрабатывать запрос.
        /*IHostingEnvironment: позволяет взаимодействовать со средой, в которой запускается приложение
         ILoggerFactory: предоставляет механизм логгирования в приложении 
         IApplicationBuilder: механизмы для настройки конвейера запросов приложения. определяет методы Run, Map, Use*/
        {
            
            app.UseSwagger();
            //метод Use добовляет в конвеер компоненты, но в этом методе может быть вызван следующий метод запроса 

            app.UseSwaggerUI(c =>
            {
                c.SwaggerEndpoint("/swagger/v1/swagger.json", "My API V1");
            });

            app.UseMvc();
            /*MVCСхема разделения данных приложения, пользовательского интерфейса на три компоненты: 
            модель,представление и контролер*/

            if (env.IsDevelopment())// если проект в процессе разработки
            {
                app.UseDeveloperExceptionPage();
                //app.Use... -представляют собой добавление компонентов middleware для обработки запроса.
            }
            
            //дальше идут маршруты   
            app.UseMvc(routes =>
            {
                routes.MapRoute(
                    name: "default",
                    template: "{controller=Demo}/{action=Pigs}/{id?}");
            });
            app.UseMvc(routes =>
            {
                routes.MapRoute(
                    name: "demo",
                    template: "{controller=Demo}/{action=Dummy}/{id?}");
            });
            app.UseMvc(routes =>
            {
                routes.MapRoute(
                    name: "demo",
                    template: "{controller=Demo}/{action=requestDummy}/{id?}");
            });
            app.UseMvc(routes =>
            {
                routes.MapRoute(
                    name: "Delete",
                    template: "{controller=Demo}/{action=Delete}/{id?}");
            });
             app.UseMvc(routes =>
            {
                routes.MapRoute(
                    name: "Edit",
                    template: "{controller=Demo}/{action=Edit}/{id?}");
            });
            
            //попытка прописать маршрут для Delete
    //          var routeBuilder = new RouteBuilder(app);
 
    //         routeBuilder.Routes.Add(new Delete());
 
    //         routeBuilder.MapRoute("{PigsApi}/{Delete}",
    //             async context => {
    //                 context.Response.ContentType = "text/html;charset=utf-8";
    //                 await context.Response.WriteAsync("двухсегментный запрос");
    //             });
 
    //         app.UseRouter(routeBuilder.Build());
 
    //         app.Run(async (context) =>
    //         {
    //             await context.Response.WriteAsync("Hello World!");
    //         });
          
    //     }
    // }

    // public class Delete : IRouter
    // {
    //     public VirtualPathData GetVirtualPath(VirtualPathContext context)
    //     {
    //         throw new NotImplementedException();
    //     }
 
    //     public Task RouteAsync(RouteContext context)
    //     {
    //         string url = context.HttpContext.Request.Path.Value.TrimEnd('/');
    //         if (url.StartsWith("/Pigs/Delete", StringComparison.OrdinalIgnoreCase))
    //         {
    //             context.Handler = async ctx =>
    //             {
    //                 ctx.Response.ContentType = "text/cshtml;charset=utf-8";
    //                 await ctx.Response.WriteAsync("href='~/Pigs/Delete/@Pig.Id' >Удалить</a></td>");
    //             };
    //         }
    //         return Task.CompletedTask;
        }
    }
}
