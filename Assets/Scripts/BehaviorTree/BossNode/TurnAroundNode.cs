using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace BossAI
{
    public class TurnAroundNode : myAI.Node
    {
        private Transform target;
        private Transform origin;
        private float turnSpeed;
        private Animation animation;

        public TurnAroundNode(Transform target, Transform origin, float turnSpeed, Animation animation) 
        {
            this.target = target;
            this.origin = origin;
            this.turnSpeed = turnSpeed;
            this.animation = animation;
        }

        public override myAI.NodeState Evaluate()
        {
            animation.Play();
            Vector3 diff = target.position - origin.position;

            Quaternion targetRotation = Quaternion.LookRotation(diff, Vector3.up);

            Quaternion realRotation = Quaternion.Slerp(origin.rotation, targetRotation, turnSpeed * Time.deltaTime);

            origin.rotation = realRotation;

            mNodestate = myAI.NodeState.RUNNING;
            return mNodestate;
        }
    }
}

