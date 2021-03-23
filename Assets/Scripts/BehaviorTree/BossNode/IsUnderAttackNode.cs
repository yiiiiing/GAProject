using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace BossAI
{
    public class IsUnderAttackNode : myAI.Node
    {
        private Boss boss;

        private float decreaseHealthThreshold;

        public IsUnderAttackNode(Boss boss, float decreaseHealthThreshold)
        {
            this.boss = boss;
            this.decreaseHealthThreshold = decreaseHealthThreshold;
        }

        public override myAI.NodeState Evaluate()
        {
            if (boss.healthDecreaseAmount > decreaseHealthThreshold)
            {
                boss.CleanHealthDecreaseAmount();
                Debug.Log("healthdecrease is " + boss.healthDecreaseAmount);
                mNodestate = myAI.NodeState.SUCCESS;
            }
            else
            {
                mNodestate = myAI.NodeState.FAIL;
            }

            return mNodestate;
        }
    }

}
