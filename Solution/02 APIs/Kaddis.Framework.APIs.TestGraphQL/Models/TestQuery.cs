using GraphQL.Types;
using Kaddis.Framework.APIs.TestGraphQL.Types;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Kaddis.Framework.APIs.TestGraphQL.Models
{
    public class TestQuery : ObjectGraphType
    {
        public TestQuery(TestContext db)
        {
            Field<TestType>(
              "Test",
              arguments: new QueryArguments(
                new QueryArgument<IdGraphType> { Name = "id", Description = "The ID of the Author." }),
              resolve: context =>
              {
                  var id = context.GetArgument<int>("id");
                  var test = db
              .Tests
              .Include(a => a.TestItems)
              .FirstOrDefault(i => i.Id == id);
                  return test;
              });

            Field<ListGraphType<TestType>>(
              "Tests",
              resolve: context =>
              {
                  var tests = db.Tests.Include(a => a.TestItems);
                  return tests;
              });
        }
    }
}
