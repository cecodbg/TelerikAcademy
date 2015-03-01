// Write a program that enters file name along with its full file path (e.g. C:\WINDOWS\win.ini), reads its contents and prints it on the console.
// Find in MSDN how to use System.IO.File.ReadAllText(…).
// Be sure to catch all possible exceptions and print user-friendly error messages.

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Security;

namespace ReadFileContents
{
    class ReadFileContents
    {
        static void Main()
        {
            Console.WriteLine("Enter full file path: ");
            string inString = Console.ReadLine();
            string text = string.Empty;
            try
            {
                text = File.ReadAllText(inString);
            }
            catch (ArgumentNullException)
            {
                Console.WriteLine("Path is null.");
            }
            catch (ArgumentException)
            {
                Console.WriteLine("Path is a zero-length string, contains only white space, or contains one or more invalid characters as defined by InvalidPathChars.");
            }
            catch (PathTooLongException)
            {
                Console.WriteLine("The specified path, file name, or both exceed the system-defined maximum length. For example, on Windows-based platforms, paths must be less than 248 characters, and file names must be less than 260 characters.");
            }
            catch (DirectoryNotFoundException ex)
            {
                Console.WriteLine(ex.Message);
            }
            catch (NotSupportedException)
            {
                Console.WriteLine("Path is in an invalid format.");
            }
            catch (FileNotFoundException)
            {
                Console.WriteLine("The file specified in path was not found.");
            }
            catch (IOException ex)
            {
                Console.WriteLine("path specified a file that is read-only.-or-This operation is not supported on the current platform.-or-path specified a directory.-or-The caller does not have the required permission.");
            }
            catch (UnauthorizedAccessException ex)
            {
                Console.WriteLine(ex.Message);
            }
            catch (SecurityException)
            {
                Console.WriteLine("The caller does not have the required permission.");
            }
            Console.WriteLine(text);
        }
    }
}
