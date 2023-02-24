using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OtherVariableExample : MonoBehaviour
{
    public string playerHealth;
    void Start()
    {
        Debug.Log("Player Health is: " + playerHealth);
    }
}
