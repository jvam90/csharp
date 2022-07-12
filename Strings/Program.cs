namespace Strings
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string name = "Joao Victor Alves Martins";
            string anotherString = new string('a', 2);

            string bar = "John\\bar";
            string newLine = "John\nNew Line";

            string unicodeExample = "\u03a3";

            string verbatim = @"C:\Users\jvam90\source\repos\CSharpStuff";

            //Console.WriteLine(name);
            //Console.WriteLine(anotherString);
            //Console.WriteLine(bar);
            //Console.WriteLine(newLine);
            //Console.WriteLine(unicodeExample);
            Console.WriteLine(verbatim);

        }
    }
}