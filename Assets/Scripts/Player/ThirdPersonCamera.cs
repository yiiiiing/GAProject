using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace myGame
{
    public class ThirdPersonCamera : MonoBehaviour
    {
        // lookAtTarget
        public Transform gcTargetObjectTransform;
        public Transform pivot;

        // default offset
        public Vector3 vOffset;
        public bool isUsingOffset;

        // rotate speed
        public float fRoateSpeed;

        // maximum/minimum x rotate
        public float fUpRotateX = 45f;
        public float fDownRotateX = 315f;

        void Start()
        {
            // first make camera position and rotation same with user
            transform.rotation = gcTargetObjectTransform.rotation;
            pivot.position = gcTargetObjectTransform.position;
            pivot.transform.parent = gcTargetObjectTransform.transform;

            // if don't using offest, then vOffset is relative position of player to camera
            if (!isUsingOffset)
            {
                vOffset = gcTargetObjectTransform.position - transform.localPosition;
                // maker sure that vOffset.x = 0
                vOffset.x = 0.0f;
            }

        }

        // move player first and then move camera
        void LateUpdate()
        {
            

            // first rotate target
            float horizontal = InputController.rightSticker.x;
            float vertical = InputController.rightSticker.y;

            // rotate camera
            transform.Rotate(0f, horizontal * fRoateSpeed * Time.deltaTime, 0f);

            pivot.Rotate(vertical * fRoateSpeed * Time.deltaTime, 0, 0);

            // handel with max and min view angle
            if (pivot.rotation.eulerAngles.x > fUpRotateX && pivot.rotation.eulerAngles.x < 180f)
            {
                pivot.rotation = Quaternion.Euler(fUpRotateX, 0f, 0f);
            }

            if (pivot.rotation.eulerAngles.x > 180 && pivot.rotation.eulerAngles.x < fDownRotateX)
            {
                pivot.rotation = Quaternion.Euler(fDownRotateX, 0f, 0f);
            }

           float desiredYAngle = transform.eulerAngles.y;
           float desiredXAngle = pivot.eulerAngles.x;

           
           Quaternion desiredRotation = Quaternion.Euler(desiredXAngle, desiredYAngle, 0);
           transform.position = gcTargetObjectTransform.position - (desiredRotation * vOffset);

           //// if camera look down the player
           if (transform.position.y < gcTargetObjectTransform.transform.position.y)
           {
                transform.position = new Vector3(transform.position.x, gcTargetObjectTransform.position.y - 0.5f, transform.position.z);
           }

           // last, look at the target
           transform.LookAt(gcTargetObjectTransform.position - new Vector3(0,vOffset.y,0));
        }
    }

 
}
