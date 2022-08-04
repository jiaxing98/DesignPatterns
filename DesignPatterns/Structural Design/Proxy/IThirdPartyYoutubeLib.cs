using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proxy
{
    public interface IThirdPartyYoutubeLib
    {
        List<Video> ListVideos();
        Video? GetVideoInfo(int id);
        void DownloadVideo(int id);
    }

    public class Video
    {
        public int id;

        public Video(int id)
        {
            this.id = id;
        }
    }

    // The concrete implementation of a service connector. Methods
    // of this class can request information from YouTube. The speed
    // of the request depends on a user's internet connection as
    // well as YouTube's. The application will slow down if a lot of
    // requests are fired at the same time, even if they all request
    // the same information.
    public class ThirdPartyYoutubeClass : IThirdPartyYoutubeLib
    {
        private List<Video> videos = new List<Video>() { new Video(1), new Video(2), new Video(3) };
        public List<Video> ListVideos()
        {
            Console.WriteLine($"Getting videos from library...");
            return videos;
        }

        public Video? GetVideoInfo(int id)
        {
            Console.WriteLine($"Getting video {id} from library...");
            return videos.Find(x => x.id == id);
        }

        public void DownloadVideo(int id)
        {
            Console.WriteLine($"Downloading video {id} ...");
        }
    }

    // To save some bandwidth, we can cache request results and keep
    // them for some time. But it may be impossible to put such code
    // directly into the service class. For example, it could have
    // been provided as part of a third party library and/or defined
    // as `final`. That's why we put the caching code into a new
    // proxy class which implements the same interface as the
    // service class. It delegates to the service object only when
    // the real requests have to be sent.
    public class CachedYoutubeClass : IThirdPartyYoutubeLib
    {
        private IThirdPartyYoutubeLib service;
        private Video? videoCache;
        private List<Video>? listCache;
        public bool needReset;

        public CachedYoutubeClass(IThirdPartyYoutubeLib service)
        {
            this.service = service;
        }

        public List<Video> ListVideos()
        {
            if(listCache == null || needReset)
            {
                listCache = service.ListVideos();
            }
            else
            {
                Console.WriteLine($"Getting videos from cahce...");
            }
            return listCache;
        }

        public Video? GetVideoInfo(int id)
        {
            if(videoCache == null || videoCache.id != id || needReset)
            {
                videoCache = service.GetVideoInfo(id);
            }
            else
            {
                Console.WriteLine($"Getting video {id} from cahce...");
            }
            return videoCache;
        }

        public void DownloadVideo(int id)
        {
            service.DownloadVideo(id);
        }
    }
}
