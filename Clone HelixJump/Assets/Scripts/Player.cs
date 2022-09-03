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
    public GameObject PlayerDestroedeFffect;
    public GameObject PlatformDestroedEffect;
    public GameObject PlayerWinEffect;


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

    private void GameOver()
    {
        Game.OnPlayerDied();
    }

    private void Won()
    {
        Game.OnPlayerReachedFinish();
    }

    public void ReachFinish()
    {
        PlayerWinEffect.SetActive(true);
        PlayerWinEffect.GetComponent<ParticleSystem>().Stop();
        Instantiate(PlayerWinEffect, transform.position, transform.rotation);
        Invoke("Won", 2f);
        Rigidbody.velocity = Vector3.zero;
    }

    public void Die()
    {
        //GetComponent<Renderer>().sharedMaterial = PlayerDestroed;
        PlayerDestroedeFffect.SetActive(true);
        PlayerDestroedeFffect.GetComponent<ParticleSystem>().Stop();
        Instantiate(PlayerDestroedeFffect, transform.position, transform.rotation);
        gameObject.SetActive(false);
        Invoke("GameOver", 2f);
        Rigidbody.velocity = Vector3.zero;
    }

    private void Update()
    {
        var speed = Rigidbody.velocity.magnitude;
        if(speed > 25)
        {
            if(!(CurrentPlatform.name == "Platform_Finish"))
            {
                //for(int i= 0; i < child.childCount; i++)
                //{
                //    Renderer r = child.GetChild(i).GetComponent<Renderer>();
                //    r.sharedMaterial = PlatformDestoed;
                //    child.GetChild(i).GetComponent<MeshCollider>().enabled = false;
                CurrentPlatform.gameObject.SetActive(false);
                PlatformDestroedEffect.SetActive(true);
                PlatformDestroedEffect.GetComponent<ParticleSystem>().Stop();
                Instantiate(PlatformDestroedEffect, CurrentPlatform.transform.GetChild(0).position, PlayerDestroedeFffect.transform.rotation);
                Destroy(CurrentPlatform.gameObject, 1);
                _audio.Play();
                _platformDestroyedCounter++;
                Rigidbody.velocity = new Vector3(0, BounceSpeed - 5, 0);
            }          
        }
    }
}
