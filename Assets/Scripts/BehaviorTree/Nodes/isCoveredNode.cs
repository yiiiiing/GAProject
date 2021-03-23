using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace myAI
{
    public class isCoveredNode : Node
    {
        // transform of the player and the enemy
        private Transform target;
        private Transform origin;

        public isCoveredNode(Transform target, Transform origin )
        {
            this.target = target;
            this.origin = origin;
        }

        public override NodeState Evaluate()
        {
            RaycastHit hit;
            // origin, direcion and return the first hit 
            if (Physics.Raycast(origin.position, target.position - origin.position, out hit))
            {
                // if hit something, which means there is a seperator between player and enemy
                if (hit.collider.transform != target)
                {
                    mNodestate = NodeState.SUCCESS;
                    return mNodestate;
                }

            }
            mNodestate = NodeState.FAIL;
            return mNodestate;
        }

    }

}
