using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DOgKill : MonoBehaviour
{
    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.CompareTag("Player"))
        {

            Destroy(gameObject);
            Destroy(collision.gameObject);
        }
    }
}
