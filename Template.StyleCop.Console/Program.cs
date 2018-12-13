namespace Template.StyleCop.Console
{
    using System;

    interface IFoo
    {
    }

    class B
    {
        private string _b;

        public B()
        {
            _b = "asd";
        }

        public string Foo(int a, int b)
        {
            return _b;
        }
    }

    public static class Program
    {
        public static void Main(string[] args)
        {
            if (true)
            {
                int a = 1 + 1;
            }
        }
    }
}