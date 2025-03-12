using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace modul4_103022300121
{
    class FanLaptop
    {
        public enum FanState { QUIET, BALANCED, PERFORMANCE, TURBO };
        public enum Trigger { MODE_UP, MODE_DOWN , TURBO_SHORTCUT};

        class Transition
        {
            public FanState PrevState { get; }
            public FanState NextState { get; }
            public Trigger Trigger { get; }

            public Transition(FanState prevState, FanState nextState, Trigger trigger)
            {
                PrevState = prevState;
                NextState = nextState;
                Trigger = trigger;
            }
        }

        private FanState currentState;
        private List<Transition> transitions;

        public FanLaptop()
        {
            currentState = FanState.QUIET;
            transitions = new List<Transition>
            {
                new Transition(FanState.QUIET, FanState.BALANCED, Trigger.MODE_UP),
                new Transition(FanState.BALANCED, FanState.PERFORMANCE, Trigger.MODE_UP),
                new Transition(FanState.PERFORMANCE, FanState.BALANCED, Trigger.MODE_DOWN),
                new Transition(FanState.BALANCED, FanState.QUIET, Trigger.MODE_DOWN),
                new Transition(FanState.QUIET, FanState.TURBO, Trigger.TURBO_SHORTCUT),
                new Transition(FanState.TURBO, FanState.QUIET, Trigger.TURBO_SHORTCUT),
                new Transition(FanState.PERFORMANCE, FanState.TURBO, Trigger.MODE_UP),
                new Transition(FanState.TURBO, FanState.PERFORMANCE, Trigger.MODE_DOWN)

            };
        }
        private Transition GetNextState(FanState prevState, Trigger trigger)
        {
            Transition t = null;
            foreach (var transition in transitions)
            {
                if (transition.PrevState == prevState && transition.Trigger == trigger)
                {
                    t = transition;
                    return t;
                }
            }
            return t;
        }
        public void ActivateTrigger(Trigger trigger)
        {
            Transition transition = GetNextState(currentState, trigger);
            
            if(transition != null)
            {
                currentState = transition.NextState;
                Console.WriteLine($"Fan {transition.PrevState} berubah menjadi {transition.NextState}");
            }
            else
            {
                Console.WriteLine("Tidak ada jalur.");
            }
            
        }

        public FanState GetCurrentState()
        {
            return currentState;
        }
    }
}

