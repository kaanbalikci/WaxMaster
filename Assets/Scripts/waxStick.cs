using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class waxStick : MonoBehaviour
{
    public static waxStick WS;

    //serialize field
    [SerializeField] private float speed = 1000f;

    //hide in inspector
    [HideInInspector] public bool isTake;

    private void Awake()
    {
        WS = this;
    }

    private void Update()
    {

        if(isTake == true)
        {
            if (Input.touchCount > 0)
            {
                Touch Touch = Input.GetTouch(0);

                if (Touch.phase == TouchPhase.Stationary || Touch.phase == TouchPhase.Moved)
                {
                    //we get the touch position
                    Vector3 touchedPos = Camera.main.ScreenToWorldPoint(new Vector3(Touch.position.x, Touch.position.y, 1.1f));
                    //sticks pos = our touch pos 
                    transform.position = new Vector3(touchedPos.x, 2.1f, touchedPos.z);                   

                }
            }
        }
    }
}   
