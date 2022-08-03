using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Facade
{
    //Third-party library
    public class VideoFile
    {
        public string fileName;
        
        public VideoFile(string fileName)
        {
            this.fileName = fileName;
        }
    }

    public class CodecFactory
    {
        public string codecName;

        public CodecFactory extract(VideoFile videoFile)
        {
            codecName = $"Codec_{videoFile.fileName}";
            return this;
        }

        //Other complex functions...
    }

    public class OggCompressionCodec
    {
        public string oggCodecName;

        public OggCompressionCodec(CodecFactory codec)
        {
            this.oggCodecName = $"{codec.codecName.Replace("wma", "ogg")}";
        }

        //Other complex functions...
    }


    public class Mpeg4CompressionCodec
    {
        public string mpeg4CodecName;

        public Mpeg4CompressionCodec(CodecFactory codec)
        {
            this.mpeg4CodecName = $"{codec.codecName.Replace("wma", "mp4")}";
        }

        //Other complex functions...
    }
}
