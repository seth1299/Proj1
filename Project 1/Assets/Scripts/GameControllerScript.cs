using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.SceneManagement;

public class GameControllerScript : MonoBehaviour
{
    public TextMeshProUGUI restartText;
    public TextMeshProUGUI gameOverText;
    public TextMeshProUGUI fishText;

    public int fishCount;
    private int fish;

    public GameObject[] fishList;
    public GameObject timer;

    public Vector3 spawnValues;

    public float spawnWait;
    public float startWait;
    public float waveWait;

    private bool gameOver;
    private bool restart;

    // Start is called before the first frame update
    void Start()
    {
        gameOver = false;
        restart = false;
        restartText.text = "";
        gameOverText.text = "";
        StartCoroutine(spawnFish());
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey("escape"))
             Application.Quit();

        if (restart)
        {
            if (Input.GetKeyDown (KeyCode.R))
            {
                SceneManager.LoadScene("Proj1");
            }
        }
    }

    IEnumerator spawnFish()
    {
        yield return new WaitForSeconds (startWait);
        while (gameOver == false)
        {
            for (int i = 0; i < fishCount && gameOver == false; i++)
            {
                gameOver = timer.GetComponent<Timer>().getTimer();
                GameObject fish = fishList[Random.Range (0, fishList.Length)];
                Vector3 spawnPosition = new Vector3 (Random.Range (-spawnValues.x, spawnValues.x), Random.Range (-spawnValues.y, spawnValues.y), spawnValues.z);
                Quaternion spawnRotation = Quaternion.identity;
                Instantiate (fish, spawnPosition, spawnRotation);
                yield return new WaitForSeconds (spawnWait);
            }
            yield return new WaitForSeconds (waveWait);

            if (gameOver)
            {
                restartText.text = "Press 'R' to Restart";
                restart = true;
                break;
            }
        }
    }

    public void setGameOver (bool value)
    {
        gameOver = value;
    }

    public int getScore ()
    {
        return fish;
    }

    public void AddScore (int newScoreValue)
    {
        fish += newScoreValue;
        UpdateScore ();
    }

    public void UpdateScore ()
    {
        fishText.text = "Fish: " + fish;
    }

    public int getFish ()
    {
        return fish;
    }

    public bool getGameOver()
    {
        return gameOver;
    }

}
