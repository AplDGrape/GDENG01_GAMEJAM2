using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Obstacle : MonoBehaviour
{
    FPSScript playerMovement;
    //RetryScene retryscene;

    // Start is called before the first frame update
    void Start()
    {
        playerMovement = GameObject.FindObjectOfType<FPSScript>();
    }

    private void OnTriggerEnter(Collider collision)
    {
        if (collision.gameObject.name == "Player")
        {
            playerMovement.Death();
            RetryScene.gameOver = true;
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
