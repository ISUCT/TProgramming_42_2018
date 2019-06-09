namespace HelloWorld.Models
{
    using System;
    using System.Linq;
    using Microsoft.Extensions.DependencyInjection;

    public static class SampleData
    {
        public static void Initialize(DogsContext DogsContext)
        {
            var context = DogsContext;
            if (!context.Dogs.Any())
            {
                context.Dogs.AddRange(
                                    new Dog
                                    {
                                        // Id = 1,
                                        Name = "Sharik",
                                        Author = "Ivanov ",
                                        Price = 15000,
                                    },
                                    new Dog
                                    {
                                        // Id = 2,
                                        Name = "Gercog",
                                        Author = "Sidorov",
                                        Price = 25500,
                                    },
                                    new Dog
                                    {
                                        // Id = 3,
                                        Name = "Uisnech Bon Of The Best",
                                        Author = "Katya",
                                        Price = 100500,
                                    });
                context.SaveChanges();
            }
        }
    }
}