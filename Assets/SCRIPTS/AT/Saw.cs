using NodeCanvas.Framework;
using ParadoxNotion.Design;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.AI;


namespace NodeCanvas.Tasks.Actions {

	public class Saw : ActionTask {

        public Renderer Renderer;
        public NavMeshAgent thewalker;// this enemy nav
        public Transform playerplace;

        public Transform ThisEnemyplace;// allow the other enemy to find this enemy
        public NavMeshAgent dogback;// the other enemy nav
        protected override void OnExecute()
        {
            thewalker.SetDestination(playerplace.position);//find the player places
            Renderer.material.color = Color.red;// after enemy saw the player it will turn red in 0.75s
            if(Renderer.material.color == Color.red)
            {
                dogback.SetDestination(ThisEnemyplace.position);// check if the other enemy find the player if is yes then this enemy will go to the other enemy place
            }
            EndAction(true);

        }
        protected override void OnUpdate()
        {
            if (thewalker.pathPending) return;// make the move better

            if (thewalker.remainingDistance <= thewalker.stoppingDistance)
                if (!thewalker.hasPath || thewalker.velocity.sqrMagnitude == 0)
                    EndAction(true);
        }

    }
}