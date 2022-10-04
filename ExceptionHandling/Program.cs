using System;
using System.IO;

namespace ExceptionHandling
{
    class Program
    {
        static void Main(string[] args)
        {
            var streamReader = new StreamReader(@"c:\");
            try
            {
                var content = streamReader.ReadToEnd();
            }
            catch (Exception e)
            {
                Console.WriteLine("Unexpected error");
            }
            finally
            {
                streamReader.Dispose();
            }
        }
    }
}