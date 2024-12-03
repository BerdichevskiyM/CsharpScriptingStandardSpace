using System;

public enum E // Other type (secondary type) example. It could be delegate, subclass and etc.
{
    A,
    B
}

enum E1
{
    A,
    B
}

namespace Scripts
{
    public enum E
    {
        A,
        B
    }

    enum E1
    {
        A,
        B
    }

    class Program : Fabs, IFoo
    {
        public enum E
        {
            A,
            B
        }

        enum E1
        {
            A,
            B
        }

        public const float Pi = 7f; // Consts.
        const float Ji = 3.14f;

        public static Foo Foo; // Static common fields.
        static Foo foo1;
        public static int F; // Static C# built-in type fields.
        static int f1;

        public Foo _foo; // Instance common fields.
        Foo _foo1;
        public int _f; // Instance C# built-in type fields.
        int _f1;

        public Program(Foo foo, int f)
        {
            _foo = foo;
            _f = f;
            Foo5 = foo;
        }

        public static event Action GoToFoo;

        public event Action GoToFoo1;

        event Action GoToFoo2;

        public static Foo Foo => new(); // Static getters.

        public static Foo Foo1 { get; set; } // Static getters-setters.

        static Foo Foo2 => new();

        static Foo Foo3 { get; set; }

        public Foo Foo4 => new(); // Instance getters.

        public Foo Foo5 { get; init; } // Instance getters-initters.

        public Foo Foo6 { get; set; } // Instance getters-setters.

        Foo Foo7 { get; }

        Foo Foo8 { get; init; }

        Foo Foo9 { get; set; }

        public static void MakeFoo() { } // Static methods.

        public static Foo GetFoo() => new(); // Static functions.

        static void Main(string[] args)
        {
            Console.WriteLine(4.0);
            Console.Read();
        }

        static void MakeFoo1() { }

        static Foo GetFoo1() => new();

        public virtual void ConvertFoo(Foo foo) { } // Virtual methods.

        public virtual Foo ConvertFooAsFoo(Foo foo) => new(); // Virtual functions.

        protected virtual void ConvertFoo1(Foo foo) { }

        protected virtual Foo ConvertFooAsFoo1(Foo foo) => new();

        public override void DoFoo() // Override methods.
        {
            throw new NotImplementedException();
        }

        public override Foo GiveFoo() // Override functions.
        {
            throw new NotImplementedException();
        }

        protected override void DoFoo1()
        {
            throw new NotImplementedException();
        }

        protected override Foo GiveFoo1()
        {
            throw new NotImplementedException();
        }

        public void MakeFoo2() { } // Instance methods.

        public Foo ToFoo(int f) => new(); // Implicit interface implementation.

        public Foo GetFoo2() => new(); // Instance functions.

        void MakeFoo3() { }

        Foo GetFoo3() => new();

        int IFoo.GetF() => _f; // Explicit interface implementation.
    }
}
