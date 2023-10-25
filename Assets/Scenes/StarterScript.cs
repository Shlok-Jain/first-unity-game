using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class StarterScript : MonoBehaviour
{
    public static bool IsFirstTime = true;
    public GameObject starter;
    void Start()
    {
        if(IsFirstTime){
            starter.SetActive(true);
        }
        else{
            starter.SetActive(false);
        }
        IsFirstTime = false;
    }
    public void StartGame(){
        SceneManager.LoadScene(0);
    }
    public void Quit(){
        Application.Quit();
    }
}
