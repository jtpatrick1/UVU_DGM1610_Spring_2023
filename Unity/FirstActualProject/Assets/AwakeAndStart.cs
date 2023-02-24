using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AwakeAndStart : MonoBehaviour
{
    public int ammoCount;
    public int enemyHealth;
    void Awake()
    {
        Debug.Log("It's Alive!!!");
        ammoCount = 10;
        enemyHealth = 3;
    }

    void Start()
    {
        Debug.Log(ammoCount);
        Debug.Log(enemyHealth);
    }
}
