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

    public void ReachFinish()
    {
       Game.OnPlayerReachedFinish();
       Rigidbody.velocity = Vector3.zero;
    }

    public void Die()
    {
        Game.OnPlayerDied();
        Rigidbody.velocity = Vector3.zero;
    }

    private void Update()
    {
        var speed = Rigidbody.velocity.magnitude;
        if(speed > 30)
        {
            Destroy(CurrentPlatform.gameObject);
            _audio.Play();
            _platformDestroyedCounter++;
            Rigidbody.velocity = Vector3.zero;
        }
    }
}
