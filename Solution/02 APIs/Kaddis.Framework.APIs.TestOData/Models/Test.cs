using System;
using System.Collections.Generic;

namespace Kaddis.Framework.APIs.TestOData.Models
{
    public class Test
    {
        public long Id { get; set; }

        public string Name { get; set; }

        public string Description { get; set; }

        public List<TestItem> TestItems { get; set; }
    }
}
