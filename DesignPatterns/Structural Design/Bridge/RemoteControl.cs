using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bridge
{
    public class RemoteControl
    {
        protected IDevice device;

        public RemoteControl(IDevice device)
        {
            this.device = device;
        }

        public void TogglePower()
        {
            if(device.IsEnabled()) device.Disable();
            else device.Enable();
        }

        public void VolumeUp()
        {
            device.SetVolume(device.GetVolume() + 10);
        }

        public void VolumeDown()
        {
            device.SetVolume(device.GetVolume() - 10);
        }

        public void ChannelUp()
        {
            device.SetChannel(device.GetChannel() + 1);
        }

        public void ChannelDown()
        {
            device.SetChannel(device.GetChannel() - 1);
        }
    }

    public class AdvancedRemoteControl : RemoteControl
    {
        public AdvancedRemoteControl(IDevice device) : base(device) { }

        public void Mute()
        {
            device.SetVolume(0);
        }
    }
}
