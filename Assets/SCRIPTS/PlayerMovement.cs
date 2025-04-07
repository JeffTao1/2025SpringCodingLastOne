using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class PlayerMovement : MonoBehaviour
{
    public NavMeshAgent navAgent;
    [SerializeField]GameObject food;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            Ray mouseRay = Camera.main.ScreenPointToRay(Input.mousePosition);
            if (Physics.Raycast(mouseRay, out RaycastHit hitInfo))
            {
                navAgent.SetDestination(hitInfo.point);

            }

        }
        if (Input.GetMouseButtonDown(1)) {
            GameObject fooder = Instantiate(food, gameObject.transform.position, gameObject.transform.rotation);      
        
        }
    }
}
