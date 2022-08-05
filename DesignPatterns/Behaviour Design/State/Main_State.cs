using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace State
{
    //Use the State pattern when you have an object that behaves
    //differently depending on its current state, the number of states
    //is enormous, and the state-specific code changes frequently.

    //Use the pattern when you have a class polluted with massive
    //conditionals that alter how the class behaves according to the
    //current values of the class’s fields.

    //Use State when you have a lot of duplicate code across similar
    //states and transitions of a condition-based state machine.
    public static class Main_State
    {
        public static void Init()
        {
            AudioPlayer player = new AudioPlayer();

            player.ClickPlay();
            player.ClickNext();
            player.ClickPrev();
            player.ClickLock();
        }
    }
}
