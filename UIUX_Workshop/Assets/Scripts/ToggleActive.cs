using UnityEngine;

public class ToggleActive : MonoBehaviour
{
    public void ToggleActiveObject(GameObject gameObjectToToggle)
    {
        var status = gameObjectToToggle.activeSelf;
        gameObjectToToggle.SetActive(!status);
    }
}



