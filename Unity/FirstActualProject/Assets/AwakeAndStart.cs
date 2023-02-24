using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AwakeAndStart : MonoBehaviour
{
    void Awake()
    {
        Debug.Log("It's Alive!!!");
    }

    private void Start()
    {
        Debug.Log("It's Starting.");
    }
}
