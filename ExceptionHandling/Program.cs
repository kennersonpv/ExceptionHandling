using System;
using System.IO;

namespace ExceptionHandling
{
    class Program
    {
        static void Main(string[] args)
        {
            StreamReader streamReader = null;
            try
            {
                streamReader = new StreamReader(@"c:\");
                var content = streamReader.ReadToEnd();
            }
            catch (Exception e)
            {
                Console.WriteLine("Unexpected error");
            }
            finally
            {
                if(streamReader != null)
                    streamReader.Dispose();
            }
        }
    }
}