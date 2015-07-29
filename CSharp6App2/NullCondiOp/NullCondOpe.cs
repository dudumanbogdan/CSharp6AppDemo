using System;

namespace CSharp6App2.NullCondiOp
{
    public class FooBar
    {
        public Foo Foo { get; set; }
    }

    public class Foo
    {
        public Bar Bar { get; set; }
    }

    public class Bar
    {
        public void SayBar()
        {
            Console.WriteLine("Say bar");
        }
    }
}
