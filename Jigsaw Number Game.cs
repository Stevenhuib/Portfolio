using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NumberWizard : MonoBehaviour
{
    int max;
    int min;
    int guess;
       
    void Start()

    {

     StartGame();

    }


    void StartGame()

    {
        max = 666;
        min = 1;
        guess = 333;


        Debug.Log("You wanna play a game?");
        Debug.Log("Pick a number, if you play fair I will maybe spare you a hand...");
        Debug.Log("The highest number you can pick is: " + max);
        Debug.Log("The lowest number you can pick is: " + min);
        Debug.Log("Tell me if your number is higher or lower than: " + guess);
        Debug.Log("Push Up for Higher, Push Down for Lower, Push Enter for Correct");
        max = max + 1;

    }



    // Update is called once per frame

    void Update()

    {

        if (Input.GetKeyDown(KeyCode.UpArrow))

        {

            min = guess;
            NextGuess();

        }

        else if (Input.GetKeyDown(KeyCode.DownArrow))

        {

            max = guess;
            NextGuess();

        }

        else if (Input.GetKeyDown(KeyCode.Return))

        {

            Debug.Log("Perfect, you can keep a hand, which one you wanna keep?");
            StartGame();

        }

    }

    void NextGuess()

    {

        guess = (max + min) / 2;
        Debug.Log("Is it higher or lower than..." + guess);

    }

}