using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class camera_follow : MonoBehaviour
{
    public GameObject player;
    public GameObject camera;
    void Update()
    {
        if(player.transform.position.x < 0){
            camera.transform.position = new Vector3(0, camera.transform.position.y, -10);
        }
        else if(player.transform.position.x>18){
            camera.transform.position = new Vector3(18, camera.transform.position.y, -10);
        }
        else{
            camera.transform.position = new Vector3(player.transform.position.x, camera.transform.position.y, -10);
        }
    }
}
