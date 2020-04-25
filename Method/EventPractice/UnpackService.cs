using System;
using System.Collections.Generic;
using System.Text;

namespace EventPractice
{
    public class UnpackService
    {
        public void OnFileDownloaded(object source, FileEventArgs e)
        {
            Console.WriteLine("UnpackerService: Unpacking the file..." + e.file.Title);
        }
    }
}
