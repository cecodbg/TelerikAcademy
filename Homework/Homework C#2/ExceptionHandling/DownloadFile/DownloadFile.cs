// Write a program that downloads a file from Internet (e.g. Ninja image) and stores it the current directory.
// Find in Google how to download files in C#.
// Be sure to catch all exceptions and to free any used resources in the finally block.


using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Net;

namespace DownloadFile
{
    class DownloadFile
    {
        static void Main()
        {
            string url = "https://encrypted-tbn3.gstatic.com/images?q=tbn:ANd9GcRSlqXppC9mxbyK7UbR4l1xNosM3wDFg5eIYwu5AinEjIqQdEVA";
            string fileName = "download.jpg";
            WebClient client = new WebClient();

            try
            {
                client.DownloadFile(url, fileName);
            }
            catch (ArgumentNullException)
            {
                Console.WriteLine("The address parameter is null.");
            }
            catch (WebException)
            {
                Console.WriteLine("The URI formed by combining BaseAddress and address is invalid.-or-filename is null or Empty.-or-The file does not exist.-or- An error occurred while downloading data.");
            }
            catch (NotSupportedException)
            {
                Console.WriteLine("The method has been called simultaneously on multiple threads.");
            }
            finally
            {
                client.Dispose();
            }
        }
    }
}
