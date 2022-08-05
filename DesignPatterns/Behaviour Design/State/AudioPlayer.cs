using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace State
{
    // The AudioPlayer class acts as a context. It also maintains a
    // reference to an instance of one of the state classes that
    // represents the current state of the audio player.
    public class AudioPlayer
    {
        private State _state;

        public AudioPlayer()
        {
            _state = new ReadyState(this);

            // Context delegates handling user input to a state
            // object. Naturally, the outcome depends on what state
            // is currently active, since each state can handle the
            // input differently.
        }

        public bool IsPlaying()
        {
            return _state is PlayingState;
        }

        public void ChangeState(State state)
        {
            _state = state;
        }
        
        public void ClickLock()
        {
            _state.ClickLock();
        }

        public void ClickPlay()
        {
            _state.ClickPlay();
        }

        public void ClickPrev()
        {
            _state.ClickPrev();
        }

        public void ClickNext()
        {
            _state.ClickNext();
        }

        public void StartPlayback()
        {
            Console.WriteLine("Start playing the song...");
        }

        public void StopPlayback()
        {
            Console.WriteLine("Stop playing the song...");
        }

        public void NextSong()
        {
            Console.WriteLine("Playing next song...");
        }

        public void PreviousSong()
        {
            Console.WriteLine("Playing last song...");
        }
    }
}
