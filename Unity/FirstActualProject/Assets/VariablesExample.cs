using System.Collections;
using UnityEngine;

public class VariablesExample : MonoBehaviour
{
    public int myInt;
    public AwakeAndStart getAmmo;

    private int _pullAmmoCount;
    void Start()
    {
        //myInt = MultiplyByThree(10);
        //Debug.Log(myInt);
        _pullAmmoCount = getAmmo.ammoCount;
        Debug.Log(_pullAmmoCount);
    }

    int MultiplyByThree(int number)
    {
        int result;
        result = number * 3;
        return result;
    }
}
