using NodeCanvas.Framework;
using ParadoxNotion.Design;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.AI;


namespace NodeCanvas.Tasks.Actions {

	public class Saw : ActionTask {

        public Renderer Renderer;
        public NavMeshAgent thewalker;
        public Transform playerplace;

        public Transform ThisEnemyplace;
        public NavMeshAgent dogback;
        protected override void OnExecute()
        {
            thewalker.SetDestination(playerplace.position);
            Renderer.material.color = Color.red;
            if(Renderer.material.color == Color.red)
            {
                dogback.SetDestination(ThisEnemyplace.position);
            }
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