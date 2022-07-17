using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class camRotate : MonoBehaviour
{
    void Update()
    {
        //camera rotating around the table
        transform.Rotate(0, 0.08f, 0);
    }
}
