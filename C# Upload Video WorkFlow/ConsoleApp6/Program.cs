using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ConsoleApp6
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Choose video: ");
            var result = Console.ReadLine();
            uploadVideo uploadvideo = new uploadVideo();
            uploadvideo.UploadVideo(result);
            Workflow VideoToCloud = new Workflow();
            VideoToCloud.Run();
            Console.WriteLine("\nUploading completed.");
            Console.ReadLine();
        }

        }
    }

