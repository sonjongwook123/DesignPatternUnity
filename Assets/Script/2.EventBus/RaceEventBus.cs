using System.Collections.Generic;
using UnityEngine.Events;

namespace Chapter.EventBus
{
    public class RaceEventBus
    {
        private static readonly IDictionary<RaceEventType, UnityEvent>
        Events = new Dictionary<RaceEventType,UnityEvent>();
        
        public static void Subscribe(RaceEventType eventType, UnityAction listener)
        {
            UnityEvent thisEvent;
                                                        
            if(Events.TryGetValue(eventType,out thisEvent))
            {
                thisEvent.AddListener(listener);
            }
            else
            {
                thisEvent = new UnityEvent();
                thisEvent.AddListener(listener);
                Events.Add(eventType, thisEvent);
            }
        }

        public static void Unsubscribe(RaceEventType type, UnityAction listener)
        {
            UnityEvent thisEvent;
            
            if(Events.TryGetValue(type, out thisEvent))
            {
                thisEvent.Invoke();
            }
        }

        public static void Publish(RaceEventType type)
        {
            UnityEvent thisEvent;

            if(Events.TryGetValue(type, out thisEvent))
            {
                thisEvent.Invoke();
            }
        }
    }
}

namespace Chapter.EventBus
{
    public enum RaceEventType
    {
        COUNTDOWN, START, RESTART, PAUSE, STOP, FINISH, QUIT
    }
}