using NodeCanvas.Framework;
using ParadoxNotion.Design;
using UnityEngine;
using System.Collections;
using UnityEngine.AI;

namespace NodeCanvas.Tasks.Conditions {

	public class WAIT : ConditionTask {
		public GameObject ENEMY;
        public Renderer Renderer;
         public NavMeshAgent moveB;
        //Use for initialization. This is called only once in the lifetime of the task.
        //Return null if init was successfull. Return an error string otherwise
        protected override string OnInit(){
            moveB = ENEMY.GetComponent<NavMeshAgent>();
            return null;
		}

        //Called whenever the condition gets enabled.
        protected override void OnEnable()
        {




          
           
        }
        IEnumerator waittime()
        {
            
            yield return new WaitForSeconds(0.5f);
            if (moveB != null)
            {
                moveB.isStopped = false;  
            }
            Renderer.material.color = Color.red;

            
        }

        //Called whenever the condition gets disabled.
        protected override void OnDisable() {
			
		}

		//Called once per frame while the condition is active.
		//Return whether the condition is success or failure.
		protected override bool OnCheck() {

            if (moveB != null)
            {
                moveB.isStopped = true;

            }
            StartCoroutine(waittime());
            return true;
		}
		
	}
}