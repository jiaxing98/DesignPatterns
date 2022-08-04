using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proxy
{
    // The GUI class, which used to work directly with a service
    // object, stays unchanged as long as it works with the service
    // object through an interface. We can safely pass a proxy
    // object instead of a real service object since they both
    // implement the same interface.
    public class YouTubeManager
    {
        protected IThirdPartyYoutubeLib service;

        public YouTubeManager(IThirdPartyYoutubeLib service)
        {
            this.service = service;
        }

        public void RenderVideoPage(int id)
        {
            Console.WriteLine($"Rendering video {id} ...");
            var video = service.GetVideoInfo(id);
            if (video == null)
                Console.WriteLine($"Video {id} cannot be found.");
        }

        public void RenderListPanel()
        {
            Console.WriteLine($"Rendering a list of videos ...");
            service.ListVideos().ForEach(x => Console.Write($"Video {x.id} "));
            Console.WriteLine();
        }
    }
}
