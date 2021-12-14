using UnityEngine;
using UnityEngine.Events;

public class CallEventsScript : MonoBehaviour
{
    public UnityEvent events;
    
    public void InvokeEvents()
    { 
        events.Invoke();   
    }
}


