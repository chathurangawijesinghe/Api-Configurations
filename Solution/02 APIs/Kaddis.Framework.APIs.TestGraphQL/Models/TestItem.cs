using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace Kaddis.Framework.APIs.TestGraphQL.Models
{
    public class TestItem
    {
        public long Id { get; set; }

        public string Name { get; set; }

        public string Description { get; set; }

        public long TestItemId { get; set; }

        [ForeignKey("TestItemId")]
        public Test Test { get; set; }
    }
}
