using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerDeath : MonoBehaviour
{
    public AudioClip PlayerDied;
    private AudioSource _audioSource;
    private void Awake()
    {
        _audioSource = GetComponent<AudioSource>();
    }

    private void OnCollisionEnter(Collision collision)
    {
        _audioSource.PlayOneShot(PlayerDied);
    }

}
