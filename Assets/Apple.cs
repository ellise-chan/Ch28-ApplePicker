using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Apple : MonoBehaviour
{
    [Header ("Set in Inspector")]
    public static float bottomY = -20f;        //a

    void Update()
    {
        if(transform.position.y < bottomY)
        {
            Destroy(this.gameObject);          //b

            //Get a reference to the ApplePicker componenet of Main Camera
            ApplePicker apScript = Camera.main.GetComponent<ApplePicker>();
            //Call the public AppleDestroyed() method of apScript
            apScript.AppleDestroyed();
        }
        
    }
}
