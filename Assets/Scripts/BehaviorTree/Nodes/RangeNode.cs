using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace myAI
{
    // check if player is in the enemy's range 
    public class RangeNode : Node
    {
        // the range that is considered as that player is in 
        private float range;
        // the target(player) transform and origin(enemy) transform
        private Transform target;
        private Transform origin;

        public RangeNode(float range, Transform target, Transform origin)
        {
            this.range = range;
            this.target = target;
            this.origin = origin;

        }
  
        public override NodeState Evaluate()
        {
            // calcualte the distance from origin to the target
            Vector3 diff = target.position - origin.position;
            // because y doesn't matter
            diff.y = 0.0f;

            float distance = diff.magnitude;

            mNodestate = distance < range ? NodeState.SUCCESS : NodeState.FAIL;
            return mNodestate;
        }
    }
}

