using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MusicController : MonoBehaviour
{
    public AudioSource backgroundMusic;
    public AudioSource lossMusic;
    public AudioSource victoryMusic;

    void Start()
    {
        backgroundMusic.Play();
    }

    public void playSound(bool victory)
    {
        backgroundMusic.Stop();
        if (victory == true)
        {
            victoryMusic.Play();
        }
        else
        {
            Debug.Log("Playing loss music...");
            lossMusic.Play();
        }
    }


    /*
    public AudioClip backgroundMusic;
    public AudioClip victoryMusic;
    public AudioClip lossMusic;
    public GameObject gameController;
    */
/*
    public void playSound(bool victory)
    {
        backgroundMusic.Stop();
        if (victory == true)
            victoryMusic.Play();
        else
            lossMusic.Play();
    }

    // Start is called before the first frame update
    void Start()
    {
        backgroundMusic.Play();
    }

    // Update is called once per frame
    void Update()
    {
        
    }*/
}
