using NodeCanvas.Framework;
using ParadoxNotion.Design;
using UnityEngine.AI;
using UnityEngine;


namespace NodeCanvas.Tasks.Actions {

	public class backToD : ActionTask {
        public bool TORF = true;
        public Transform Thediamond;//where the enemy gonna move to
        public NavMeshAgent thewalker;


        //Use for initialization. This is called only once in the lifetime of the task.
        //Return null if init was successfull. Return an error string otherwise
        protected override string OnInit()
        {
            return null;
        }

        //This is called once each time the task is enabled.
        //Call EndAction() to mark the action as finished, either in success or failure.
        //EndAction can be called from anywhere.
        protected override void OnExecute()
        {

            thewalker.SetDestination(Thediamond.position);
           
        }
        protected override void OnUpdate()
        {
            if (thewalker.pathPending) return;

            if (thewalker.remainingDistance <= thewalker.stoppingDistance)
                if (!thewalker.hasPath || thewalker.velocity.sqrMagnitude == 0)
                    EndAction(TORF);
        }
    }
}