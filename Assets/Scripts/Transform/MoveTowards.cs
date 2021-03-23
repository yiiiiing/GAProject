using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace myTransform
{
    public static class MoveTowards
    {

        public static void  Move(Transform targetTransform, Transform movingTransform, float moveSpeed, float turnSpeed)
        {
            Vector3 offset = targetTransform.position - movingTransform.position;

            Quaternion targetRotation = Quaternion.LookRotation(offset, Vector3.up);

            Quaternion realRotation = Quaternion.Slerp(movingTransform.rotation, targetRotation, turnSpeed*Time.deltaTime);

            movingTransform.rotation = realRotation;

            movingTransform.position += movingTransform.forward * moveSpeed * Time.deltaTime;
        }

        //public static Transform TurnToTarget(Transform targetTransform, ref Transform movingTransform, float turnSpeed)
        //{
        //    Vector3 offset = targetTransform.position - movingTransform.position;
        //    Quaternion targetRotation = Quaternion.LookRotation(offset, Vector3.up);

        //    Quaternion realRotation = Quaternion.Slerp(movingTransform.rotation, targetRotation, turnSpeed * Time.deltaTime);

        //    movingTransform.rotation = realRotation;

        //    return movingTransform;
        //}
    }

}

