using System;
using System.IO;

namespace ExceptionHandling
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                using (var streamReader = new StreamReader(@"c:\"))
                {
                    var content = streamReader.ReadToEnd();
                }
            }
            catch (Exception e)
            {
                Console.WriteLine("Unexpected error");
            }
        }
    }
}