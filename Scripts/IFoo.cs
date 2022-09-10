
namespace Scripts
{
    interface IFoo
    {
        Foo ToFoo(int f);

        int GetF();

        private int GetAutoF() => 0;
    }
}
