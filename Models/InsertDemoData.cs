using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Linq;
using TestMVC.Data;

namespace TestMVC.Models
{
    public class InsertDemoData
    {
        public static void Init(IServiceProvider serviceProvier)
        {
            using (var context = new TestMVCContext(
                serviceProvier.GetRequiredService<DbContextOptions<TestMVCContext>>()))
            {
                if (context.Order.Any())
                {
                    return;
                }
                context.Order.AddRange(
                    new Order
                    {
                        SenderCity = "Saint-Petersburg",
                        SenderAdress = "Whatever st. 12",
                        DestCity = "Moscow",
                        DestAdress = "Random st. 16",
                        Weight = 12500,
                        cargoDate = DateTime.Parse("2022-7-10")
                    },
                    new Order
                    {
                        SenderCity = "Saint-Petersburg",
                        SenderAdress = "Whatever st. 18",
                        DestCity = "Kazan",
                        DestAdress = "Some st. 15",
                        Weight = 14200,
                        cargoDate = DateTime.Parse("2022-7-8")
                    },
                    new Order
                    {
                        SenderCity = "Moscow",
                        SenderAdress = "Random st. 16",
                        DestCity = "Kazan",
                        DestAdress = "Some st. 15",
                        Weight = 700,
                        cargoDate = DateTime.Parse("2022-7-15")
                    }
                    );
                context.SaveChanges();
            }
        }
    }
}
