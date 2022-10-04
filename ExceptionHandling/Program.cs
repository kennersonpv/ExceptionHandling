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
                var api = new YoutubeApi();
                var videos = api.GetVideos("kennerson");
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
        }
    }
}