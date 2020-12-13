using UnityEngine;

public class CreateAttachObject : MonoBehaviour
{
    public GameObject objectToBeCreated;
    public GameObject objectToBeAttached;

    public void CreateAttach()
    {
        if (objectToBeCreated != null && objectToBeAttached != null)
        {
            Instantiate(objectToBeCreated, objectToBeAttached.transform);    
        }
    }
}


