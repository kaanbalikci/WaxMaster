using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class buttonMenager : MonoBehaviour
{
    [SerializeField] private GameObject cleanOBJ;
    [SerializeField] private GameObject takeButton;
    [SerializeField] private GameObject cleanButton;
    [SerializeField] private GameObject arm;

    private Animator anim;
   

    private void Awake()
    {
        anim = arm.GetComponent<Animator>();
    }

    public void StartButton()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
    }

    public void TakeButton()
    {
        waxStick.WS.isTake = true;
        Destroy(takeButton);
        
    }

    public void CleanButton()
    {
        Instantiate(cleanOBJ);
        cleanButton.SetActive(false);
        SpawnWax.SW.checkClear = true;
    }

    public void RestartGame()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 0);
        anim.SetTrigger("Start");
    }



}
