using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DestroyByScore : MonoBehaviour
{

    public GameObject gameController;
    private int score;

    // Update is called once per frame
    void Update()
    {
        score = gameController.GetComponent<GameControllerScript>().getScore();
        if (score >= 6)
            Destroy(gameObject);
        if (gameController.GetComponent<GameControllerScript>().getGameOver() == true)
            Destroy(gameObject);
    }
}
