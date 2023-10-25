using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class CoinCounter : MonoBehaviour
{
    public static int Count=0;
    // public GameObject player;
    public TextMeshProUGUI coinText;
    void Update(){
        // gameObject.transform.position = new Vector3(player.transform.position.x,0,0);
        coinText.text = "Coins: "+Count.ToString();
    }
    public void Quit(){
        Application.Quit();
    }
}
