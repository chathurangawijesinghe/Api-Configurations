using System.Threading.Tasks;
using GraphQL;
using GraphQL.Types;
using Kaddis.Framework.APIs.TestGraphQL.Models;
using Microsoft.AspNetCore.Mvc;

namespace Kaddis.Framework.APIs.TestGraphQL.Controllers
{
    [Route("graphql")]
    [ApiController]
    public class QueryController : Controller
    {
        private readonly TestContext _dbContext;

        public QueryController(TestContext dbContext) => _dbContext = dbContext;

        public async Task<IActionResult> Post([FromBody] GraphQLQuery query)
        {
            var inputs = query.Variables.ToInputs();

            var schema = new Schema
            {
                Query = new TestQuery(_dbContext)
            };

            var result = await new DocumentExecuter().ExecuteAsync(_ =>
            {
                _.Schema = schema;
                _.Query = query.Query;
                _.OperationName = query.OperationName;
                _.Inputs = inputs;
            });

            if (result.Errors?.Count > 0)
            {
                return BadRequest();
            }

            return Ok(result);
        }
    }
}