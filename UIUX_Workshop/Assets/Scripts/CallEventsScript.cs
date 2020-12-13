using UnityEngine;
using UnityEngine.Events;

public class CallEventsScript : MonoBehaviour
{
    public UnityEvent events;
    
    private void InvokeEvents()
    { 
        events.Invoke();   
    }
}


