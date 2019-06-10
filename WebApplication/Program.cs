using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore;
using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.Logging;

namespace WebApplication
{
    public class Program
    {
        public static void Main(string[] args)
        {
            CreateWebHostBuilder(args).Build().Run();//Build -создает хост IWebHost,Run()-запускает IWebHost
        }

        public static IWebHostBuilder CreateWebHostBuilder(string[] args) =>
            WebHost.CreateDefaultBuilder(args)//Непосредственно создание IWebHostBuilder 
                .UseStartup<Startup>();//устанавливается стартовый класс приложения - класс Startup, с которого и будет начинаться обработка входящих запросов.
    } 
    
}


