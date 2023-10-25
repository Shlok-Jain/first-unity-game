using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class death : MonoBehaviour
{
    public GameObject replayandquitpanel;
    public static bool isPowerUp = false;
    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.CompareTag("Player") && !isPowerUp)
        {
            Destroy(collision.gameObject);
            replayandquitpanel.SetActive(true);
            // SceneManager.LoadScene(1);

        }
    }
    void Update(){
        if(isPowerUp){
            gameObject.GetComponent<PolygonCollider2D>().isTrigger = true;
        }
    }

    public void Restart()
    {
        int sceneIndex=SceneManager.GetActiveScene().buildIndex;
        SceneManager.LoadScene(sceneIndex);
    }
}
