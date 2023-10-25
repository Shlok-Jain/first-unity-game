using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class replayandquit : MonoBehaviour
{
    public GameObject replayandquitpanel;
    void Start()
    {
        replayandquitpanel.SetActive(false);
    }
    public void Restart(){
        CoinCounter.Count=0;
        SceneManager.LoadScene(0);
    }
    public void Quit(){
        Application.Quit();
    }
}
