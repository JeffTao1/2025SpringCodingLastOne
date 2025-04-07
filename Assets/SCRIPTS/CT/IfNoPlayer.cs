using NodeCanvas.Framework;
using ParadoxNotion.Design;
using UnityEngine;


namespace NodeCanvas.Tasks.Conditions {

	public class IfNoPlayer : ConditionTask {

        public Transform playerwhere;
        public float checkarea = 4;// how big is the checking
        public Transform enemy;

        protected override bool OnCheck()
        {
            float howfar = Vector3.Distance(enemy.transform.position, playerwhere.transform.position);// find if there is player close to attack or not if no then enemy will move random point

            if (howfar >= checkarea) 
            {
                return false;
            }
            return true;
        }
    }
}