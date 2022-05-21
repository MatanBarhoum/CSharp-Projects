using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ConsoleApp6
{
    public class uploadVideo
    {
        static public string VideoName { get; set; }

        public void UploadVideo(string videoName)
        {
            VideoName = videoName;
        }
        public void Execute()
        {
            Console.WriteLine("\nUploading Video to cloud...\nVideo name: {0}\nProcessing....", VideoName);
        }
    }
}
