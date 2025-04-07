using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DOgKill : MonoBehaviour
{
    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.CompareTag("Player"))// find the player
        {

            Destroy(gameObject);//if the bullet touch the player the bullet will gonna
            Destroy(collision.gameObject);//if toucch player die;
        }
    }
}
