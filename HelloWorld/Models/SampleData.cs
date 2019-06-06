namespace HelloWorld.Models
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
                                        // Id = 1,
                                        Name = "Colt",
                                        Kalibr = "0.45",
                                        Price = 600,
                                    },
                                    new Pistol
                                    {
                                        // Id = 2,
                                        Name = "Glock",
                                        Kalibr = "9x19",
                                        Price = 550,
                                    },
                                    new Pistol
                                    {
                                        // Id = 3,
                                        Name = "Pm",
                                        Kalibr = "9x18",
                                        Price = 500,
                                    });
                context.SaveChanges();
            }
        }
    }
}