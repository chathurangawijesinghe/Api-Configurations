using Microsoft.AspNetCore.Builder;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Kaddis.Framework.APIs.TestGraphQL.Models
{
    public static class DbInitializer
    {
        public static void Initialize(IApplicationBuilder app)
        {
            using (var serviceScope = app.ApplicationServices.CreateScope())
            {
                var context = serviceScope.ServiceProvider.GetService<TestContext>();
                context.Database.EnsureCreated();

                context.Tests.AddRange(
                    new Test
                    {
                        Id = 1,
                        Name = "Test 1",
                        Description = "Test description 1"
                    },
                    new Test
                    {
                        Id = 2,
                        Name = "Test 2",
                        Description = "Test description 2"
                    }
                );

                context.TestItems.AddRange(
                    new TestItem
                    {
                        Id = 1,
                        Name = "TestItem 1",
                        Description = "TestItem description 1",
                        TestItemId = 1
                    },
                    new TestItem
                    {
                        Id = 2,
                        Name = "TestItem 2",
                        Description = "TestItem description 2",
                        TestItemId = 1
                    },
                    new TestItem
                    {
                        Id = 3,
                        Name = "TestItem 3",
                        Description = "TestItem description 3",
                        TestItemId = 3
                    },
                    new TestItem
                    {
                        Id = 4,
                        Name = "TestItem 4",
                        Description = "TestItem description 4",
                        TestItemId = 4
                    });

                context.SaveChanges();
            }
        }
    }
}
