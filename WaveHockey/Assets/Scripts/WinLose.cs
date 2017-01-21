using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class WinLose : MonoBehaviour {

    static bool done = false;
    static Text info;
    static string tlooser;

    private void Start()
    {
         info = GetComponent<Text>();
         done = false;
    }

    public static void DisplayWinner(string looser)
    {
        done = true;
        tlooser = looser;
        Display();
    }

    private static void Display()
    {
        string text;
        if (done)
        {
            if (tlooser.Contains("1"))
            {
                text = "Player 2 Wins";
            }
            else
            {
                text = "Player 1 Wins";
            }

            info.text = text;
        }
    }
}
