using System;
using System.Collections.Generic;

namespace ExceptionHandling
{
    public class YoutubeApi
    {
        public List<Video> GetVideos(string user)
        {
            try
            {
                //Access Youtube web service
                // Read the data
                // Create a list of Video objects
                throw new Exception("Oops, some low level Youtube error. ");
            }
            catch (Exception e)
            {
                throw new YoutubeException("Could not fetch Youtube Videos", e);
            }

            return new List<Video>();
        }
    }
}