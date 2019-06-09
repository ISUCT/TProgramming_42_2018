namespace HelloWorld.Models
{
    using System;
    using System.Linq;
    using Microsoft.Extensions.DependencyInjection;

    public static class SampleData
    {
        public static void Initialize(PigsContext PigsContext)
        {
            var context = PigsContext;
            if (!context.Pigs.Any())
            {
                context.Pigs.AddRange(
                                    new Pig
                                    {
                                        // Id = 1,
                                        Name = "Funtik",
                                        Author = "Smit ",
                                        Price = 6000,
                                    },
                                    new Pig
                                    {
                                        // Id = 2,
                                        Name = "Piatochok",
                                        Author = "Spolsky",
                                        Price = 5500,
                                    },
                                    new Pig
                                    {
                                        // Id = 3,
                                        Name = "Hrjusha",
                                        Author = "Tit",
                                        Price = 5000,
                                    });
                context.SaveChanges();
            }
        }
    }
}