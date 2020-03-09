using GraphQL.Types;
using Kaddis.Framework.APIs.TestGraphQL.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Kaddis.Framework.APIs.TestGraphQL.Types
{
    public class TestItemType : ObjectGraphType<TestItem>
    {
        public TestItemType()
        {
            Name = "TestItem";

            Field(x => x.Id, type: typeof(IdGraphType)).Description("The ID of the TestItem.");
            Field(x => x.Name).Description("The name of the TestItem");
            Field(x => x.Description).Description("TestItem description");
        }
    }
}
