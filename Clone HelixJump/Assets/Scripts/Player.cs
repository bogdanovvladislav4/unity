using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    public float BounceSpeed;
    public Rigidbody Rigidbody;
    public Platform CurrentPlatform;
    public Game Game;
    public Material PlatformDestoed;
    public Material PlayerDestroed;
    public AudioClip PlayerDestroedSounds;


    internal int _platformDestroyedCounter = 0;
    private AudioSource _audio;

    private void Awake()
    {
        _audio = GetComponent<AudioSource>();
    }

    public void Bounce()
    {
        Rigidbody.velocity = new Vector3(0, BounceSpeed, 0);
    }

    public void GameOver()
    {
        Game.OnPlayerDied();
    }

    public void ReachFinish()
    {
       Game.OnPlayerReachedFinish();
       Rigidbody.velocity = Vector3.zero;
    }

    public void Die()
    {
        GetComponent<Renderer>().sharedMaterial = PlayerDestroed;
        _audio.PlayOneShot(PlayerDestroedSounds);
        Invoke("GameOver", 1f);
        Rigidbody.velocity = Vector3.zero;
    }

    private void Update()
    {
        var speed = Rigidbody.velocity.magnitude;
        if(speed > 25)
        {
            Transform child = CurrentPlatform.transform.GetChild(0);
            for(int i= 0; i < child.childCount; i++)
            {
                Renderer r = child.GetChild(i).GetComponent<Renderer>();
                r.sharedMaterial = PlatformDestoed;
                child.GetChild(i).GetComponent<MeshCollider>().enabled = false;
            }
            Destroy(CurrentPlatform.gameObject, 1);
            _audio.Play();
            _platformDestroyedCounter++;
            Rigidbody.velocity = new Vector3(0, BounceSpeed - 5, 0);
        }
    }
}
