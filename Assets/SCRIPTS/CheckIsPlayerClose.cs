using NodeCanvas.Framework;
using ParadoxNotion.Design;
using UnityEngine;

namespace NodeCanvas.Tasks.Conditions {

	public class CheckIsPlayerClose : ConditionTask {

		public Transform playerwhere;
		public float checkarea = 4;
		public Transform enemy;
		
		protected override bool OnCheck() {
			float howfar = Vector3.Distance(enemy.transform.position,playerwhere.transform.position);
			
			if(howfar <= checkarea)
			{
                return false;
            }
			return true;
		}

		
	}
}