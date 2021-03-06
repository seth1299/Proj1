using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class Pickup : MonoBehaviour
{
    
    public TextMeshProUGUI winText;
    public TextMeshProUGUI fishText;
    public AudioSource collectSound;
    public GameObject gameController;
    public GameObject musicController;
    private bool victory;

    void Start()
    {
        winText.text = "";
    }

    public void OnTriggerEnter2D(Collider2D other)
    {
            collectSound.Play();
            other.gameObject.SetActive(false);
            gameController.GetComponent<GameControllerScript>().AddScore(1);
            //gameController.GetComponent<GameControllerScript>().UpdateScore();
            if (gameController.GetComponent<GameControllerScript>().getFish() >= 6)
            {
                musicController.GetComponent<MusicController>().playSound(true);
                victory = true;
                winText.text = "You win!";
                gameController.GetComponent<GameControllerScript>().setGameOver(true);
            }

            
    }

}
