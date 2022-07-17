using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnWax : MonoBehaviour
{

    public static SpawnWax SW;

    //Serialize Fields
    [SerializeField] private Transform parentHair;
    [SerializeField] private GameObject wax;
    [SerializeField] private GameObject cleanButton;
    [SerializeField] private GameObject finishPanel;
    [SerializeField] private GameObject ClearText;

    //Hide in inspector
    [HideInInspector] public bool checkClear;

    private void Awake()
    {
        SW = this;
    }

  
    private void Update()
    {
        //if touch clean button open clear text
        if (checkClear == true)
        {
            StartCoroutine(OpenCleanText());
        }

        //if all hairs cleaned, finish game
        if (parentHair.transform.childCount == 0 && checkClear == true)
        {
            StartCoroutine(FinishGame());
        }
        else
        {
            checkClear = false;
        }

        
        //instantiate wax on the arm
        if (waxStick.WS.isTake == true)
        {
            if (Input.touchCount > 0)
            {
                Touch Touch = Input.GetTouch(0);

                if (Touch.phase == TouchPhase.Stationary || Touch.phase == TouchPhase.Moved)
                {
                    //send the ray from the touch pos
                    var ray = Camera.main.ScreenPointToRay(Touch.position);
                    RaycastHit hit;

                    if (Physics.Raycast(ray, out hit))
                    {

                        if (hit.collider.gameObject.CompareTag("Arm"))
                        {
                            //instantiate wax hit position on the arm
                            Instantiate(wax, new Vector3(hit.point.x, hit.point.y, hit.point.z), Quaternion.identity);
                            //open clean button if waxing to arm
                            cleanButton.SetActive(true);
                        }
                    }
                }
            }
        }
    }


    public IEnumerator FinishGame()
    {       
        yield return new WaitForSeconds(2f);
        finishPanel.SetActive(true);
    }

    public IEnumerator OpenCleanText()
    {
        yield return new WaitForSeconds(2f);
        ClearText.SetActive(true);
        StartCoroutine(CloseCleanText());
    }

    public IEnumerator CloseCleanText()
    {
        yield return new WaitForSeconds(1.5f);
        ClearText.SetActive(false);
    }

}
