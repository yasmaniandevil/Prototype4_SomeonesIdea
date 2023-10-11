using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using Unity.Mathematics;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class GameManager : MonoBehaviour
{
    public float totalTime = 60.0f;
    private float currentTime;
    private bool isGameActive = false;
    
    public TMP_Text timerText;
    public TMP_Text resultText;

    //public float timeLeft;
    //public bool TimerOn = false;

    
    
    // Start is called before the first frame update
    void Start()
    {
        //TimerOn = true;
        StartGame();
    }

    // Update is called once per frame
    void Update()
    {
        /*//if timer is on
        if (TimerOn)
        {
            //and if time left is greater than 0
            if (timeLeft > 0)
            {
                //subtract time left from actual time
                timeLeft -= Time.deltaTime;
                updateTimer(timeLeft);
            }
            else
            {
                Debug.Log("Time is up");
                timeLeft = 0;
                TimerOn = false;
            }
        }*/

        if (isGameActive)
        {
            currentTime -= Time.deltaTime;
            UpdateTimerText();

            if (currentTime <= 0)
            {
                EndGame(false);
            }
        }
    }

    /*void updateTimer(float currentTime)
    {
        currentTime += 1;

        float minutes = Mathf.FloorToInt(currentTime / 60);
        float seconds = Mathf.FloorToInt(currentTime % 60);

        timerText.text = string.Format("{0:00} : {1:00}", minutes, seconds);
    }*/

    void StartGame()
    {
        currentTime = totalTime;
        //Debug.Log("Start Game Total Time: " + totalTime);
        //Debug.Log("Start Game Current Time: " + currentTime);
        isGameActive = true;
        Debug.Log("Is Game Active in Start set to true: " + isGameActive);
        UpdateTimerText();
        resultText.text = "";
    }

    void EndGame(bool hasPlayerWon)
    {
        isGameActive = false;
        Debug.Log("End Game is Game Active bool (false)" + isGameActive);
        
        if (hasPlayerWon)
        {
            Debug.Log("End Game PlayerHasWon bool: " + hasPlayerWon);
            resultText.text = "You win";
        }
        else
        {
            resultText.text = "Game Over";
        }
    }

    void UpdateTimerText()
    {
        timerText.text = "Time: " + Mathf.Max(0, Mathf.CeilToInt(currentTime));
        //Debug.Log(currentTime);
    }

    public void WinGame()
    {
        EndGame(true);
    }
    public void SceneLoader()
    {
        SceneManager.LoadScene(1);
    }
}
