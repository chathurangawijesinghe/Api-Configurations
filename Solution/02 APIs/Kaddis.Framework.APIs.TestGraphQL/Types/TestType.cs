using GraphQL.Types;
using Kaddis.Framework.APIs.TestGraphQL.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Kaddis.Framework.APIs.TestGraphQL.Types
{
    public class TestType : ObjectGraphType<Test>
    {
        public TestType()
        {
            Name = "Test";

            Field(x => x.Id, type: typeof(IdGraphType)).Description("The ID of the Test.");
            Field(x => x.Name).Description("The name of the Test");
            Field(x => x.Description).Description("Test description");
            Field(x => x.TestItems, type: typeof(ListGraphType<TestItemType>)).Description("Test items");
        }
    }
}
