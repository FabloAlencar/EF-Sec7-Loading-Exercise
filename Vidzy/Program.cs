using System;
using System.Data.Entity;
using System.Linq;

namespace Vidzy
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            var dbContext = new VidzyContext();

            var videos = dbContext.Videos.Include(v => v.Genre).ToList();

            foreach (var video in videos)
                Console.WriteLine("Video: {0}, Genre: {1} ", video.Name, video.Genre.Name);

            Console.ReadLine();
        }
    }
}