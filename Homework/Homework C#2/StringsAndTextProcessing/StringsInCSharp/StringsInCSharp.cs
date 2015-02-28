﻿// Describe the strings in C#.
// What is typical for the string data type?
// Describe the most important methods of the String class.




/*
-Describe the strings in C#.
    A string is an object of type String whose value is text. Internally, the text is stored as a sequential read-only collection of Char objects.
    There is no null-terminating character at the end of a C# string; therefore a C# string can contain any number of embedded null characters ('\0').

-What is typical for the string data type?
    The String data type is reference type, which represents a sequence of Unicode characters and maps to System.String.
    The default value of the String type is a null reference.
    Strings are stored in the dynamic memory (managed heap). They have fixed length (String.Length),
    elements can be accessed directly by index in the range [0...Length-1].


-Describe the most important methods of the String class.
    String.Length - Gets the lenght of the string
    String.IndexOf()
    String.Join()
    String.Split()
    Sting.Trim()
    String.ToUpper()
    String.ToLower()
    String.CompareTo()
    String.LastIndexOf()
 */

