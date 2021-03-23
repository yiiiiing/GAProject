using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

namespace myAI
{
    public class ChaseNode : Node
    {
        private Transform target;
        private NavMeshAgent agent;

        public ChaseNode(Transform target, NavMeshAgent agent)
        {
            this.target = target;
            this.agent = agent;
        }

        public override NodeState Evaluate()
        {
            float distance = Vector3.Distance(target.position, agent.transform.position);

            // if distance is larger than a very small value, then enemy move
            // otherwise, enemy already reached the position and then moving is success
            if (distance > 0.2f)
            {
                agent.isStopped = false;
                agent.SetDestination(target.position);
                mNodestate = NodeState.RUNNING;
                return mNodestate;
            }
            else
            {
                agent.isStopped = false;
                mNodestate = NodeState.SUCCESS;
                return mNodestate;
            }
            
        }
    }
}

