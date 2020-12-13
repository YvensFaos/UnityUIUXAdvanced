using System.Collections.Generic;
using UnityEngine;

public class ActivateDeactivateScript : MonoBehaviour
{
    public List<GameObject> objects;

    public void ActivateObjects()
    {
        objects.ForEach(obj => obj.SetActive(true));
    }
    
    public void DeactivateObjects()
    {
        objects.ForEach(obj => obj.SetActive(false));
    }
}