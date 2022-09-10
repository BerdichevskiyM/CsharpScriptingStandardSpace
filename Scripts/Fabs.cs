using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Scripts
{
    abstract class Fabs
    {
        // Here properties same as these methods below (first, see "Program.cs").

        public static void MakeFoo20() { } // Static methods.

        public static Foo GetFoo21() => new(); // Static functions.

        static void Main(string[] args)
        {
            Console.WriteLine(4.0);
            Console.Read();
        }

        static void MakeFoo22() { }

        static Foo GetFoo23() => new();

        public abstract void DoFoo(); // Abstract methods.

        public abstract Foo GiveFoo(); // Abstract functions.

        protected abstract void DoFoo1();

        protected abstract Foo GiveFoo1();

        public virtual void ConvertFoo2(Foo foo) { } // Virtual methods.

        public virtual Foo ConvertFooAsFoo2(Foo foo) => new(); // Virtual functions.

        protected virtual void ConvertFoo3(Foo foo) { }

        protected virtual Foo ConvertFooAsFoo3(Foo foo) => new();

        public void MakeFoo24() { } // Instance methods.

        public Foo GetFoo25() => new(); // Instance functions.

        void MakeFoo26() { }

        Foo GetFoo27() => new();
    }
}
