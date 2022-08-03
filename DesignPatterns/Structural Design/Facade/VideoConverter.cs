using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Facade
{
    public enum VideoType
    {
        Ogg = 0,
        Mpeg4 = 1
    }

    public class VideoConverter
    {
        public void convert(string fileName, VideoType videoType)
        {
            var file = new VideoFile(fileName);
            var sourceCodec = new CodecFactory().extract(file);

            if(videoType == VideoType.Mpeg4)
            {
                var destinationCodec = new Mpeg4CompressionCodec(sourceCodec);

                Console.WriteLine($"Converting to {videoType} ...");
                Console.WriteLine($"{fileName} has converted to {destinationCodec.mpeg4CodecName}");
            }
            else
            {
                var destinationCodec = new OggCompressionCodec(sourceCodec);

                Console.WriteLine($"Converting to {videoType} ...");
                Console.WriteLine($"{fileName} has converted to {destinationCodec.oggCodecName}");
            }
        }
    }
}
