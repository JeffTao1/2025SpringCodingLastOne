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
        Destroy(gameObject,time);
    }

    // Update is called once per frame
    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.CompareTag("Player"))
        {
            
            Destroy(gameObject);
            Destroy(collision.gameObject);
        }
    }
}
