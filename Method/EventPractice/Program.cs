using System;

namespace EventPractice
{
    class Program
    {
        static void Main(string[] args)
        {
            var file = new File() { Title = "FileName" };
            var downlaodHelper = new DownloadHelper(); // publisher
            var unpackService = new UnpackService();
            var notifyService = new NotificationService();
            downlaodHelper.FileDownloaded += unpackService.OnFileDownloaded;
            downlaodHelper.FileDownloaded += notifyService.OnFileDownloaded;

            downlaodHelper.Download(file);

        }
    }
}
