using NodeCanvas.Framework;
using ParadoxNotion.Design;
using UnityEngine;
using UnityEngine.AI;

namespace NodeCanvas.Tasks.Actions {

	public class randommove : ActionTask {

		public Transform[] pointtomove;//where the enemy gonna move to random point array
		public NavMeshAgent thewalker;


		//Use for initialization. This is called only once in the lifetime of the task.
		//Return null if init was successfull. Return an error string otherwise
		protected override string OnInit() {
			return null;
		}

		//This is called once each time the task is enabled.
		//Call EndAction() to mark the action as finished, either in success or failure.
		//EndAction can be called from anywhere.
		protected override void OnExecute() {

			int whichpoint = Random.Range(0, 3);

            thewalker.SetDestination(pointtomove[whichpoint].position);
        }
        protected override void OnUpdate()
        {
            if (thewalker.pathPending) return;

            if (thewalker.remainingDistance <= thewalker.stoppingDistance)
                if (!thewalker.hasPath || thewalker.velocity.sqrMagnitude == 0)
                    EndAction(true);
        }

    }
}