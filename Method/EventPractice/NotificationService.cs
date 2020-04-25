using System;
using System.Collections.Generic;
using System.Text;

namespace EventPractice
{
    public class NotificationService
    {
        public void OnFileDownloaded(object source, FileEventArgs e)
        {
            Console.WriteLine("Notifying user that download is done..." + e.file.Title);
        }
        
    }
}
