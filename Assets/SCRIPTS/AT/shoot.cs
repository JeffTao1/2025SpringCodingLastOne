using NodeCanvas.Framework;
using ParadoxNotion.Design;
using UnityEngine;


namespace NodeCanvas.Tasks.Actions {

	public class shoot : ActionTask {

        public BBParameter<GameObject> bullet;
        public Transform whereStartShoot;
        public Renderer Renderer;
        
        //Use for initialization. This is called only once in the lifetime of the task.
        //Return null if init was successfull. Return an error string otherwise
     

		//This is called once each time the task is enabled.
		//Call EndAction() to mark the action as finished, either in success or failure.
		//EndAction can be called from anywhere.
		

		//Called once per frame while the action is active.

        
       
        protected override void OnExecute()
        {

            //GameObject shoot = GameObject.Instantiate(bullet.value, whereStartShoot.position, whereStartShoot.rotation);
            

            

        }
        protected override void OnUpdate()
        {
            GameObject shoot = GameObject.Instantiate(bullet.value, whereStartShoot.position, whereStartShoot.rotation);// the enemy shoot the bullet(spwon)
            Renderer.material.color = Color.blue;// also the color will back to blue after it stop shoot
           

        }


    }
}