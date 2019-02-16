using UnityEngine;
using UnityEngine.Audio;

public class AudioController : MonoBehaviour
{

    public void ToggleMute(bool shouldMute)
    {
        AudioListener.volume = shouldMute ? 0 : 1;
    }
}