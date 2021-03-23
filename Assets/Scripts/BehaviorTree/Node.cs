using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace myAI
{
    [System.Serializable]
    // inherite from monobehavior, cannot new
    // because monobehavior should be attached to a gameobject, you can only use AddComponent to add monobehavior script to a gameobject
    public abstract class Node 
    {
        // only subclass can use the protected
        protected NodeState mNodestate;

        public NodeState nodeState { get { return mNodestate; } }

        // each node has method to evaluate node if success or fail
        public abstract NodeState Evaluate();
    }

    public enum NodeState
    {
        RUNNING,
        SUCCESS,
        FAIL,
    }
}

