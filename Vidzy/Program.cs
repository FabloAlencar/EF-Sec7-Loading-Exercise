namespace Vidzy
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            var dbContext = new VidzyContext();

            var videos = dbContext.Videos;

            foreach (var video in videos)
                System.Console.WriteLine("Video: {0}, Genre: {1} ", video.Name, video.Genre.Name);
        }
    }
}