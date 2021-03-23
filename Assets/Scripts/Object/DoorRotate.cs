using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace myGame
{
    public class DoorRotate : MonoBehaviour
    {
        public float startRotateY;
        public float endRotateY;

        public float rotateDuration;

        private float fEventTime;

        private float fRatio;

        private Vector3 startPoint;
        private Vector3 endPoint;

        public enum DoorState
        {
            idel, open, close
        };

        private DoorState currentState = DoorState.idel;


        // Start is called before the first frame update
        void Start()
        {
            fEventTime = Time.time;

            startPoint = new Vector3(transform.rotation.x, startRotateY, transform.rotation.z);
            endPoint = new Vector3(transform.rotation.x, endRotateY, transform.rotation.z);
        }

        // Update is called once per frame
        void Update()
        {
            switch (currentState) {
                case DoorState.idel:
                    break;
                case DoorState.open:
                    doorOpen();
                    break;
                case DoorState.close:
                    doorClose();
                    break;
             }

            
        }

        public void ChangeDoorState(DoorState state)
        {
            currentState = state;
            fEventTime = Time.time;
        }

        private void doorOpen()
        {
            fRatio = (Time.time - fEventTime) / rotateDuration;

            transform.eulerAngles = Vector3.Slerp(startPoint, endPoint, fRatio);

            if (fRatio > 1.0f)
            {
                ChangeDoorState(DoorState.idel);
            }
        }

        private void doorClose()
        {
            fRatio = (Time.time - fEventTime) / rotateDuration;

            transform.eulerAngles = Vector3.Slerp(endPoint, startPoint, fRatio);

            if (fRatio > 1.0f)
            {
                ChangeDoorState(DoorState.idel);
            }
        }
    }

}
