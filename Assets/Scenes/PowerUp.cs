using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PowerUp : MonoBehaviour
{
    void OnTriggerEnter2D(){
        Destroy(gameObject);
        death.isPowerUp = true;

    }
}
