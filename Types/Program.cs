namespace Types
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int age = 32;
            Int32 alsoAge = 32;

            char c = 'J';
            Char alsoC = 'J';

            byte b = 0;
            Byte alsoB = 1;

            Console.WriteLine("Int32 == int");
            Console.WriteLine(age);
            Console.WriteLine(alsoAge);
            Console.WriteLine("Char == char");
            Console.WriteLine(c);
            Console.WriteLine(alsoC);
            Console.WriteLine("Byte == byte");
            Console.WriteLine(b);
            Console.WriteLine(alsoB);
        }
    }
}