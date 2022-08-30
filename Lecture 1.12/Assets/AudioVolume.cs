using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AudioVolume : MonoBehaviour
{
    [Min(0)]
    public float volume;
    private AudioListener _audioListener;

    private void Awake()
    {
       _audioListener = GetComponent<AudioListener>();
    }

    private void Update()
    {
        AudioListener.volume = volume;
    }
}
