using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bridge
{
    public interface IDevice
    {
        bool IsEnabled();
        void Enable();
        void Disable();
        int GetVolume();
        void SetVolume(int volume);
        int GetChannel();
        void SetChannel(int channel);
    }

    public class TV : IDevice
    {
        private bool _turnOn;
        private int _volume;
        private int _channel;

        public bool IsEnabled()
        {
            return _turnOn;
        }

        public void Disable()
        {
            _turnOn = false;
        }

        public void Enable()
        {
            _turnOn = true;
        }

        public int GetChannel()
        {
            return _channel;
        }

        public void SetChannel(int channel)
        {
            _channel = channel;
        }

        public int GetVolume()
        {
            return _volume;
        }

        public void SetVolume(int volume)
        {
            _volume = volume;
        }
    }

    public class Radio : IDevice
    {
        private bool _turnOn;
        private int _volume;
        private int _channel;

        public bool IsEnabled()
        {
            return _turnOn;
        }

        public void Disable()
        {
            _turnOn = false;
        }

        public void Enable()
        {
            _turnOn = true;
        }

        public int GetChannel()
        {
            return _channel;
        }

        public void SetChannel(int channel)
        {
            _channel = channel;
        }

        public int GetVolume()
        {
            return _volume;
        }

        public void SetVolume(int volume)
        {
            _volume = volume;
        }
    }
}