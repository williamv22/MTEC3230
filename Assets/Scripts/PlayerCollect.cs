using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class PlayerCollect : MonoBehaviour
{

    public int objects = 5;
    public GameObject collected;
    public GameObject lose;
    public float timeRemaining = 10;
    public bool timerIsRunning = false;
    public Text timeText;
    

    // Start is called before the first frame update
    void Start()
    {
        timerIsRunning = true;
        lose.SetActive(false);
        collected.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        if (objects == 0)
        {
            collected.SetActive(true);
        }

        if (timerIsRunning)
        {
            if (timeRemaining > 0)
            {
                timeRemaining -= Time.deltaTime;
                DisplayTime(timeRemaining);
            }
            else 
            {
                Debug.Log("Time has run out!");
                timeRemaining = 0;
                timerIsRunning = false;
                lose.SetActive(true);
            }
        }




    }
    void DisplayTime(float timeToDisplay)
    {
        timeToDisplay += 1;

        float minutes = Mathf.FloorToInt(timeToDisplay / 60);
        float seconds = Mathf.FloorToInt(timeToDisplay % 60);

        timeText.text = string.Format("{0:00}:{1:00}", minutes, seconds);
    }


    private void OnGUI()
    {
        GUI.Label(new Rect(10, 40, 600, 600), "Objects Remaining: " + objects);
       
    }



}
