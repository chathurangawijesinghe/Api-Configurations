using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Grpc.Core;
using Kaddis.Framework.APIs.gRPC.Protos;
using Microsoft.Extensions.Logging;

namespace Kaddis.Framework.APIs.gRPC
{
    public class TesterService : Tester.TesterBase
    {
        private readonly ILogger<TesterService> _logger;

        public TesterService(ILogger<TesterService> logger)
        {
            _logger = logger;
        }

        public override Task<TestReply> GetTests(TestRequest request, ServerCallContext context)
        {
            var tests = new List<Test>
            {
                new Test
                {
                    Id = 1,
                    Name = "test 1",
                    Description = "test description 1",
                    TestItems = {}
                },
                new Test
                {
                    Id = 2,
                    Name = "test 2",
                    Description = "test description 2"
                }
            };

            var result = new TestReply();
            result.Tests.AddRange(tests);

            return Task.FromResult(result);
        }
    }
}
