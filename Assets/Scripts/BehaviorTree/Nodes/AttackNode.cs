using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;


namespace myAI
{
    public class AttackNode : Node
    {
        private NavMeshAgent agent;
        private EnemyAI ai;
        private Transform target;

        private Vector3 currentVelocity;
        private float smoothTime;

        public AttackNode(NavMeshAgent agent, EnemyAI ai, Transform target)
        {
            this.agent = agent;
            this.ai = ai;
            this.target = target;
            smoothTime = 1f;
        }

        public override NodeState Evaluate()
        {
            agent.isStopped = true;

            // first direction is toward to the player
            Vector3 direction = target.position - ai.transform.position;
            // Gradually changes a vector towards a desired goal over time.
            // the current direction, the direction we want to reach
            //The current velocity, this value is modified by the function every time you call it.
            Vector3 currentDirection = Vector3.SmoothDamp(ai.transform.forward, direction, ref currentVelocity, smoothTime);
            Quaternion rotation = Quaternion.LookRotation(currentDirection, Vector3.up);
            ai.transform.rotation = rotation;

            // Then attack animation, TODO: player attack animation



            mNodestate = NodeState.RUNNING;
            return mNodestate;
        }
    }
}

