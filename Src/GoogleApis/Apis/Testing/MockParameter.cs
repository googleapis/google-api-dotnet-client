using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Google.Apis.Discovery;

namespace Google.Apis.Testing
{
    public class MockParameter : IParameter
    {
        public string Name { get; set;}
        public string ParameterType { get; set; }
        public string Pattern { get; set; }
        public bool Required { get; set; }
        public string DefaultValue { get; set; }
        public string ValueType { get; set; }
        public string Description { get; set; }
        public string Maximum { get; set; }
        public string Minimum { get; set; }
        public IEnumerable<string> Enum { get; set; }
    }
}
