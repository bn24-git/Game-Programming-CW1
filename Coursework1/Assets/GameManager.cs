using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{
    bool gameEnded = false;

    public float restart = 1f;

    public GameObject LevelWonUI;

    public void LevelComplete()
    {
        LevelWonUI.SetActive(true);
    }

    public void End()
    {
        if(gameEnded == false)
        {
            gameEnded = true;
            Debug.Log("Game over");
            Invoke("Restart", restart);
        }

    }

    void Restart()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }
}
