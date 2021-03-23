using System.Collections;
using System.Collections.Generic;
using myAI;
using UnityEngine;

namespace BossAI
{
    public class RunToTargetNode : Node
    {
        // orgin move to the target
        private Transform origin;
        private Transform target;
        private float runSpeed;
        private float turnSpeedInRun;
        private string animationName;
        private Animator animator;

        public RunToTargetNode(Transform origin, Transform target, float runSpeed, float turnSpeedInRun, string animationName, Animator animator)
        {
            this.origin = origin;
            this.target = target;
            this.runSpeed = runSpeed;
            this.turnSpeedInRun = turnSpeedInRun;
            this.animationName = animationName;
            this.animator = animator;
        }

        public override NodeState Evaluate()
        {
            animator.Play(animationName);
            Vector3 offset = target.position - origin.position;

            Quaternion targetRotation = Quaternion.LookRotation(offset, Vector3.up);

            Quaternion realRotation = Quaternion.Slerp(origin.rotation, targetRotation, turnSpeedInRun * Time.deltaTime);

            origin.rotation = realRotation;

            origin.position += origin.forward * runSpeed * Time.deltaTime;

            mNodestate = NodeState.RUNNING;
            return mNodestate;
        }
    }
}

