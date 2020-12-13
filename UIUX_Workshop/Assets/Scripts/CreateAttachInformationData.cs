using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CreateAttachInformationData : MonoBehaviour
{
    public InformationData objectToBeCreated;
    public GameObject objectToBeAttached;

    public void CreateAttachWithText(string text)
    {
        if (objectToBeCreated != null && objectToBeAttached != null)
        {
            var info = Instantiate(objectToBeCreated, 
                objectToBeAttached.transform);
            info.Initialize(text);
        }
    }
}

