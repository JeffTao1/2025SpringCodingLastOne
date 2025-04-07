using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class win : MonoBehaviour
{
    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.CompareTag("Player")) // only find the player tag
        {

            Destroy(gameObject); // destory the win if touch the player
            Destroy(collision.gameObject); // destory the player if touch the  win
            Debug.Log("winnnnnnnnnnnn"); 
        }
    }
}
