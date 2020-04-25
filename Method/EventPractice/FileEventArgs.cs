using System;
using System.Collections.Generic;
using System.Text;

namespace EventPractice
{
    public class FileEventArgs:EventArgs
    {
        public File file { get; set; }
    }
}
