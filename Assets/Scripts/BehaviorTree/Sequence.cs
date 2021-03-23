using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace myAI
{
    // sequenceNode has list of nodes (like execute each conditions)
    // only all conditions are satisfied, the sequence is success, otherwise fail if one node fails
    public class Sequence : Node
    {
        protected List<Node> nodes = new List<Node>();

        public Sequence(List<Node> nodes)
        {
            this.nodes = nodes;
        }


        public override NodeState Evaluate()
        {
            bool isAnyNodeRunning = false;
            foreach (Node node in nodes)
            {
                switch (node.Evaluate())
                {
                    case NodeState.RUNNING:
                        // if one node is running, then the sequence is running
                        isAnyNodeRunning = true;
                        break;
                    case NodeState.SUCCESS:
                        break;
                    case NodeState.FAIL:
                        // if one node fail, then the sequence fails and then return 
                        mNodestate = NodeState.FAIL;
                        return mNodestate;
                    default:
                        break;
                }
            }

            // only no nodes fail that can reach this line
            mNodestate = isAnyNodeRunning ? NodeState.RUNNING : NodeState.SUCCESS;
            return mNodestate;
        }
    }

}
