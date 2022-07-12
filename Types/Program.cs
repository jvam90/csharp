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

            sbyte sb = 1;
            SByte alsoSb = 2;

            float f = 0.0f;
            Single alsoF = 0.0f;

            double d = 3.14;
            Double alsoD = 3.14;

            decimal dec = 4.5M;
            Decimal alsoDec = 4.5M; 

            Console.WriteLine("Int32 == int");
            Console.WriteLine(age);
            Console.WriteLine(alsoAge);
            Console.WriteLine("Char == char");
            Console.WriteLine(c);
            Console.WriteLine(alsoC);
            Console.WriteLine("Byte == byte");
            Console.WriteLine(b);
            Console.WriteLine(alsoB);
            Console.WriteLine("SByte == sbyte");
            Console.WriteLine(sb);
            Console.WriteLine(alsoSb);
            Console.WriteLine("Single == float");
            Console.WriteLine(f);
            Console.WriteLine(alsoF);
            Console.WriteLine("Double == double");
            Console.WriteLine(sb);
            Console.WriteLine(alsoSb);
            Console.WriteLine("Decimal == decimal");
            Console.WriteLine(dec);
            Console.WriteLine(alsoDec);
        }
    }
}