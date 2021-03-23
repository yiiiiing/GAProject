using UnityEngine;
using System.Threading;
using System;
using System.Collections;
using System.Collections.Generic;

namespace BossAI
{
    // this node is for boss to play attack animation
    public class AnimationNode : myAI.Node
    {
        // attack animation
        private string animationName;
        private Animator animator;

        public AnimationNode(string animationName, Animator animator)
        {
            this.animationName = animationName;
            this.animator = animator;
        }

        public override myAI.NodeState Evaluate()
        {          
            //Thread.Sleep(duration);
            Debug.Log("is playing" + animationName);
            animator.Play(animationName);
            mNodestate = myAI.NodeState.RUNNING;
            return mNodestate;
        }

        IEnumerator PlayAnimation()
        {
            animator.Play(animationName);
            int duration = (int)Mathf.Ceil(animator.GetCurrentAnimatorStateInfo(0).length);
            yield return new WaitForSeconds(duration);
            mNodestate = myAI.NodeState.RUNNING;

        }

        
    }
}

