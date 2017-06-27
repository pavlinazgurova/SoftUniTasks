using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PhotoGallery
{
    class PhotoGallery
    {
        static void Main(string[] args)
        {
            var photoNumber = int.Parse(Console.ReadLine());
            var day = int.Parse(Console.ReadLine());
            var month = int.Parse(Console.ReadLine());
            var year = int.Parse(Console.ReadLine());
            var hours = int.Parse(Console.ReadLine());
            var minutes = int.Parse(Console.ReadLine());
            var size = int.Parse(Console.ReadLine());
            var width = int.Parse(Console.ReadLine());
            var height = int.Parse(Console.ReadLine());

            string orientation = "square";
            if (width > height)
            {
                orientation = "landscape";
            }
            else if (height > width)
            {
                orientation = "portrait";
            }
            var sizeByte = 0.0;
            string format = string.Empty;
            if (size <= 1000.0)
            {
                sizeByte = size;
                format = "B";
            }
            else if (size <= 1000000.0)
            {
                sizeByte = (double)size / 1000.0;
                format = "KB";
            }
            else
            {
                sizeByte = (double)size / 1000000.0;
                format = "MB";
            }

            Console.WriteLine($"Name: DSC_{photoNumber:d4}.jpg");
            Console.WriteLine($"Date Taken: {day:d2}/{month:d2}/{year} {hours:d2}:{minutes:d2}");
            Console.WriteLine($"Size: {sizeByte}{format}");
            Console.WriteLine($"Resolution: {width}x{height} ({orientation})");
        }
    }
}
