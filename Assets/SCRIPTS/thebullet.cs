using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using UnityEngine;

public class thebullet : MonoBehaviour
{
    float time = 3f;
    // Start is called before the first frame update
    void Start()
    {
        Destroy(gameObject,time);// if not get player collision it will destroy in 3s
    }

    // Update is called once per frame
    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.CompareTag("Player")) // only find the player tag
        {
            
            Destroy(gameObject); // destory the bullet if touch the player
            Destroy(collision.gameObject); // destory the player if touch the  bullet
        }
    }
}
