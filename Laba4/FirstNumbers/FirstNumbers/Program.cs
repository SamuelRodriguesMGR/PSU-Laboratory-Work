

namespace MyConsoleApp
{
    class Program
    {
        static void Main(string[] args)
        {
            EnterNums enterNums = new EnterNums(["a", "b", "c", "d"]);
            // enterNums.RemoveAfterE("b");
            Console.WriteLine(enterNums.GetListL());
            Console.WriteLine(enterNums.ElementHaveCopy());

            enterNums.Deaf();
        }
    }
}