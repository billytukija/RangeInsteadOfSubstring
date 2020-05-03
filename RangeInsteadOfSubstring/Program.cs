using System;

namespace RangeInsteadOfSubstring
{
    class Program
    {
        static void Main(string[] args)
        {
            var text = "Je suis un bantu";

            // Console.WriteLine(text.Substring(10,6));

            // Note: Why not to use Range instead of Substring?

            Console.WriteLine(text[10..16]);
        }
    }
}
