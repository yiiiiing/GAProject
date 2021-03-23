using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace BossAI
{
    public class IsInFrontOfNode : myAI.Node
    {
        // check if target is behind the origin with some angle
        private Transform origin;
        private Transform target;
        private float angle;

        public IsInFrontOfNode(Transform origin, Transform target, float angle)
        {
            this.origin = origin;
            this.target = target;
            this.angle = angle;
        }

        public override myAI.NodeState Evaluate()
        {
            Vector3 diff = target.position - origin.position;
            // vector3.Angle is between (0,180)
            Vector3 forward = origin.forward;
            // y-axis doesn't matter
            diff.y = 0.0f;
            forward.y = 0.0f;
            float diffAngle = Vector3.Angle(diff, forward);

            // angle in the range(0, angle) => is in the front of
            mNodestate = diffAngle < angle ? myAI.NodeState.SUCCESS : myAI.NodeState.FAIL;
            return mNodestate;

        }
    }
}


