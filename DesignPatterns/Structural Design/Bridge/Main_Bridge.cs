using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bridge
{
    //Use the Bridge pattern when you want to divide and organize
    //a monolithic class that has several variants of some functionality
    //(for example, if the class can work with various database servers).

    //Use the pattern when you need to extend a class in several
    //orthogonal(independent) dimensions.

    //Use the Bridge if you need to be able to switch implementations
    //at runtime.

    public static class Main_Bridge
    {
        public static void Init()
        {
            var tv = new TV();
            var tvRemote = new RemoteControl(tv);

            var radio = new Radio();
            var radioRemote = new AdvancedRemoteControl(radio);

            Console.WriteLine($"TV volume: {tv.GetVolume()}");
            Console.WriteLine($"Turning up the TV volume...");
            tvRemote.VolumeUp();
            Console.WriteLine($"TV volume now: {tv.GetVolume()}");

            Console.WriteLine($"Turning up the radio volume...");
            radioRemote.VolumeUp();
            radioRemote.VolumeUp();
            Console.WriteLine($"radio volume now: {radio.GetVolume()}");
            Console.WriteLine($"Mute the radio");
            radioRemote.Mute();
            Console.WriteLine($"radio volume now: {radio.GetVolume()}");
        }
    }
}
