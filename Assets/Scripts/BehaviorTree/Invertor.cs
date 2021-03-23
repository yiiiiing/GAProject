using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace myAI
{
    // change node from success to fail or fail to success
    // eg.for some conditions, sometimes if yes, then return success but sometimes needs to return fail
    public class Invertor : Node
    {
        protected Node node;

        public Invertor(Node node)
        {
            this.node = node;
        }

        public override NodeState Evaluate()
        {
            switch (node.Evaluate())
            {
                case NodeState.RUNNING:
                    mNodestate = NodeState.RUNNING;
                    break;
                case NodeState.SUCCESS:
                    mNodestate = NodeState.FAIL;
                    break;
                case NodeState.FAIL:
                    mNodestate = NodeState.SUCCESS;
                    break;
                default:
                    break;
            }

            return mNodestate;
        }       
    }
}

