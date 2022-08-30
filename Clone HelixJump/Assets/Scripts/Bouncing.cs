using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bouncing : MonoBehaviour
{
    public AudioClip audioClip;
    [Min(0)]
    public float Volume;
    private AudioSource _audioSource;
    private void Awake()
    {
        _audioSource = GetComponent<AudioSource>();
    }
    private void OnCollisionEnter(Collision collision)
    {
        _audioSource.PlayOneShot(audioClip, Volume);
    }
}
