namespace CSharpHomework2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Bits bits = new Bits(4);

            long num = (long)bits;
            Console.WriteLine(num);
            int num1 = (int)bits;
            Console.WriteLine(num1);
            byte num2 = (byte)bits;
            Console.WriteLine(num2);

        }
    }
}
