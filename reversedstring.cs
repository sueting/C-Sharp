
using System;
public static class ReverseString{
    public static string Reverse( string s )
 {
    char[] charArray = s.ToCharArray();
    Array.Reverse( charArray );
    return new string( charArray );
 }
} 