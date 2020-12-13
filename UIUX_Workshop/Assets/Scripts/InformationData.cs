using UnityEngine;
using UnityEngine.UI;

public class InformationData : MonoBehaviour
{
    public Text informationText;

    public void Initialize(string text)
    {
        informationText.text = text;
    }
}

