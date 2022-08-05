using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace State
{
    // The base state class declares methods that all concrete
    // states should implement and also provides a backreference to
    // the context object associated with the state. States can use
    // the backreference to transition the context to another state.
    public abstract class State
    {
        protected AudioPlayer player;

        // Context passes itself through the state constructor. This
        // may help a state fetch some useful context data if it's
        // needed.
        public State(AudioPlayer player)
        {
            this.player = player;
        }

        public abstract void ClickLock();
        public abstract void ClickPlay();
        public abstract void ClickNext();
        public abstract void ClickPrev();
    }

    // Concrete states implement various behaviors associated with a
    // state of the context.
    public class LockedState : State
    {
        public LockedState(AudioPlayer player) : base(player) { }

        // When you unlock a locked player, it may assume one of two
        // states.
        public override void ClickLock()
        {
            if (player.IsPlaying())
            {
                Console.WriteLine("Changing state from Locked to Playing");
                player.ChangeState(new PlayingState(player));
            }
            else
            {
                Console.WriteLine("Changing state from Locked to Ready");
                player.ChangeState(new ReadyState(player));
            }
        }

        public override void ClickNext()
        {
            //Locked, so do nothing.
        }

        public override void ClickPlay()
        {
            //Locked, so do nothing.
        }

        public override void ClickPrev()
        {
            //Locked, so do nothing.
        }
    }

    public class ReadyState : State
    {
        public ReadyState(AudioPlayer player) : base(player) { }

        public override void ClickLock()
        {
            Console.WriteLine("Changing state from Ready to Locked");
            player.ChangeState(new LockedState(player));
        }

        public override void ClickNext()
        {
            player.NextSong();
        }

        public override void ClickPlay()
        {
            player.StartPlayback();
            Console.WriteLine("Changing state from Ready to Playing");
            player.ChangeState(new PlayingState(player));
        }

        public override void ClickPrev()
        {
            player.PreviousSong();
        }
    }

    public class PlayingState : State
    {
        public PlayingState(AudioPlayer player) : base(player) { }

        public override void ClickLock()
        {
            Console.WriteLine("Changing state from Playing to Locked");
            player.ChangeState(new LockedState(player));
        }

        public override void ClickNext()
        {
            player.NextSong();
        }

        public override void ClickPlay()
        {
            player.StopPlayback();
            Console.WriteLine("Changing state from Playing to Ready");
            player.ChangeState(new ReadyState(player));
        }

        public override void ClickPrev()
        {
            player.PreviousSong();
        }
    }
}
