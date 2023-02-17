using System.Collections;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.Profiling.Experimental;

public class SyntaxExample : MonoBehaviour
{
    //single line comment
    
    /*
     * How long will this last
     * I don't know
     * It could go on forever
     * Or maybe not
     */
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.G))
        {
            Debug.Log("The color is Green now");
        }

        if (Input.GetKeyDown(KeyCode.R))
        {
            Debug.Log("The color is Red now");
        }
        /*
         * closed for errors
        if (Input.GetKeyDown(KeyCode.B))
        {
            Debug.Lg("The color is Ble nw");
        }
        */
    }
}
