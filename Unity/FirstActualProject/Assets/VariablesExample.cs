using System.Collections;
using UnityEngine;

public class VariablesExample : MonoBehaviour
{
    public int myInt;
    void Start()
    {
        myInt = MultiplyByThree(10);
        Debug.Log(myInt);
        
    }

    int MultiplyByThree(int number)
    {
        int result;
        result = number * 3;
        return result;
    }
}
