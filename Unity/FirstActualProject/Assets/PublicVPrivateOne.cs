using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PublicVPrivateOne : MonoBehaviour
{
    public string helloWorld;

    private int myPreciousInt = 4;

    void Start()
    {
        helloWorld = "hi there.";
        Debug.Log(helloWorld);
        Debug.Log(myPreciousInt);
    }
}