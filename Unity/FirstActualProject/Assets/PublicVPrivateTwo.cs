using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PublicVPrivateTwo : MonoBehaviour
{
    private PublicVPrivateOne theOtherClass;
    void Start()
    {
        theOtherClass = new PublicVPrivateOne();
        theOtherClass.helloWorld = "this is new.";
        Debug.Log(theOtherClass.helloWorld);
    }
}
