using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace myAI
{
    // if health is under a threshold, then enemy will elude
    // if health is above, then no need to elude
    public class HealthNode : Node
    {
        private EnemyAI ai;
        private float HPthreshold;

        public HealthNode(EnemyAI ai, float HPthreshold)
        {
            this.ai = ai;
            this.HPthreshold = HPthreshold;
        }
         
        public override NodeState Evaluate()
        {
            mNodestate = ai.GetCurrentHealth() <= HPthreshold ? NodeState.SUCCESS : NodeState.FAIL;
            return mNodestate;
        }

    }

}
