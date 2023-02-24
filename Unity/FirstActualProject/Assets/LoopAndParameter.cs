using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LoopAndParameter : MonoBehaviour
{
    public int userNumber;

    void Start()
    {
        for (int i = 0; i < 4; i++)
        {
            Debug.Log("hello");
        }

        void PrintNumber(int number)
        {
            Debug.Log(number);
        }

        PrintNumber(userNumber);
    }
}
