using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerWin : MonoBehaviour
{
    public AudioClip PlayerFinish;
    public float Volume;
    private AudioSource _audioSource;
    private void Awake()
    {
        _audioSource = GetComponent<AudioSource>();
    }

    private void OnCollisionEnter(Collision collision)
    {
        _audioSource.PlayOneShot(PlayerFinish, Volume);
    }
}
