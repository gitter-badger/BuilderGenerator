using System.Collections.Generic;
using BuilderGenerator.Common.Attributes;

namespace Demo.Entities
{
    [GenerateBuilder]
    public class Foo
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Abbreviation { get; set; }
        public List<Bar> Bars { get; } = new();
    }
}