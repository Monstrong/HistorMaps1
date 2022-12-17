using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ToggleSoung : MonoBehaviour
{
    public AudioListener audioListener;

    public void DisableSound(bool IsMuted)
    {
        audioListener.enabled = IsMuted;
    }
}