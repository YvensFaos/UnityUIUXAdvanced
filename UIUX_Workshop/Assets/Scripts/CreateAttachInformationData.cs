using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class CreateAttachInformationData : MonoBehaviour
{
    public InformationData objectToBeCreated;
    public GameObject objectToBeAttached;
    public InputField inputField;

    public void CreateAttachWithText()
    {
        if (objectToBeCreated != null && objectToBeAttached != null)
        {
            var info = Instantiate(objectToBeCreated, 
                objectToBeAttached.transform);
            var trimmedText = inputField.text.Trim();
            if (trimmedText.Length > 0)
            {
                info.Initialize(trimmedText);    
            }
            inputField.text = "";
        }
    }
}

