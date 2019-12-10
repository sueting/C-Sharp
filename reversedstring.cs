using System;
static class ReverseString{
    public static string Reverse( string s )
 {
    char[] charArray = s.ToCharArray();
    Array.Reverse( charArray );
    return new string( charArray );
 }
} 

namespace C_Sharp
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(ReverseString.Reverse("framework"));
            Console.WriteLine(ReverseString.Reverse("test"));
            Console.WriteLine(ReverseString.Reverse("c sharp"));
        }
    }
}

