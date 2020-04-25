using System;
using System.Threading;


namespace EventPractice
{
   
    public class DownloadHelper
    {
        //step1 create a delegate
        //public delegate void FileDownloadedEventHandler(object source, FileEventArgs args);
      
        //step2 create an event based on that delegate
        public event EventHandler<FileEventArgs> FileDownloaded;
        //step3 raise the event
        protected virtual void OnFileDownloaded(File file)
        {
            if (FileDownloaded != null)
            {
                FileDownloaded(this, new FileEventArgs() {file = file });
            }
        }
        public void Download(File file)
        {
            Console.WriteLine("Downloading file...");
            Thread.Sleep(4000);

            //Step3-1
            OnFileDownloaded(file);
        }
        
    }
}
