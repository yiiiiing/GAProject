using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace myAI
{
    // selectorNode has list of nodes (like choose one action to run)
    // only all conditions are failed, the selector is fail, if one node success, then selector success
    public class Selector : Node
    {
        protected List<Node> nodes = new List<Node>();

        public Selector(List<Node> nodes)
        {
            this.nodes = nodes;
        }


        public override NodeState Evaluate()
        {
            foreach (Node node in nodes)
            {
                switch (node.Evaluate())
                {
                    case NodeState.RUNNING:
                        // if one node is running, then all selector is running
                        mNodestate = NodeState.RUNNING;
                        return mNodestate;
                    case NodeState.SUCCESS:
                        mNodestate = NodeState.SUCCESS;
                        return mNodestate;
                    case NodeState.FAIL:
                    default:
                        break;
                }
            }
            mNodestate = NodeState.FAIL; 
            return mNodestate;
        }
    }

}
