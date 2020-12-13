using UnityEngine;

public class PlaySound : MonoBehaviour
{
    public AudioSource audioSource;

    public void PlayAudioOnce(AudioClip audioClip)
    {
        audioSource.PlayOneShot(audioClip);
    }
}
