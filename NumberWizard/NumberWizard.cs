using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NumberWizard : MonoBehaviour {
    int max;
    int min;
    int guess;

    // Start is called before the first frame update
    void Start ()
    {
        Debug.Log("Welcome to Number Wizard");
        Debug.Log("Game Keys: Up Arrow = Higher, Down Arrow = Lower, Enter/Return = Correct");
        Debug.Log("Pick a number, don't forget it...");
        StartGame();
    }

    void StartGame()
    {
        max = 1000;
        min = 1;
        guess = 500;
        Debug.Log("The highest number you can pick is: " + max);
        Debug.Log("The lowest number you can pick is: " + min);
        Debug.Log("Is your number is lower or higher than: " + guess);
        max = max + 1;
    }

    // Update is called once per frame
    void Update ()
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
            Debug.Log("Yay, I win!");
            Debug.Log("Play again? y/n");
        }
        if (Input.GetKeyDown(KeyCode.Y))
        {
            StartGame();
        }
        else if (Input.GetKeyDown(KeyCode.N))
        {
            Debug.Log("Thanks for playing!");
        }
    }

    void NextGuess()
    {
        guess = (max + min) / 2;
        Debug.Log("Is it higher or lower than: " + guess);
    }
}
