namespace Pistol.Models
{
    using System;
    using System.Linq;
    using Microsoft.Extensions.DependencyInjection;

    public static class SampleData
    {
        public static void Initialize(PistolsContext PistolsContext)
        {
            var context = PistolsContext;
            if (!context.Pistols.Any())
            {
                context.Pistols.AddRange(
                                    new Pistol
                                    {
                                        Id = 1,
                                        Name = "War and peace",
                                        Kalibr = "Tolstoy ",
                                        Price = 600,
                                    },
                                    new Pistol
                                    {
                                        Id = 2,
                                        Name = "Clean code",
                                        Kalibr = "Joel Spolsky",
                                        Price = 550,
                                    },
                                    new Pistol
                                    {
                                        Id = 3,
                                        Name = "C#",
                                        Kalibr = "Troellson",
                                        Price = 500,
                                    });
                context.SaveChanges();
            }
        }
    }
}