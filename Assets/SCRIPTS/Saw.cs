using NodeCanvas.Framework;
using ParadoxNotion.Design;
using UnityEngine;
using UnityEngine.AI;


namespace NodeCanvas.Tasks.Actions {

	public class Saw : ActionTask {

        public Renderer Renderer;
        public NavMeshAgent thewalker;
        public Transform playerplace
           ;
        protected override void OnExecute()
        {
            thewalker.SetDestination(playerplace.position);
            Renderer.material.color = Color.red;
            EndAction(true);

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