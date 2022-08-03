using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Facade
{
    //Use the Facade pattern when you need to have a limited but
    //straightforward interface to a complex subsystem.

    //Use the Facade when you want to structure a subsystem into
    //layers.

    public static class Main_Facade
    {
        public static void Init()
        {
            var converter = new VideoConverter();
            converter.convert("Hello.wma", VideoType.Ogg);
            converter.convert("Hello.wma", VideoType.Mpeg4);
        }
    }
}
