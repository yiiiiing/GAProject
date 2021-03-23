using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace myTransform
{
    public class alwaysRoatate : MonoBehaviour
    {
        private Transform gcTransform;

        public enum EAxis
        {
            _UP,
            _FORWARD,
            _RIGHT,
        };

        public EAxis iAxis = EAxis._UP;

        // rotate relative to world space or local space
        public Space iMoveRelative = Space.World;

        public float fRotSpeed;

        // Start is called before the first frame update
        void Start()
        {
            gcTransform = GetComponent<Transform>();

        }

        // Update is called once per frame
        void Update()
        {
            switch (iAxis)
            {
                case EAxis._UP:
                    gcTransform.Rotate(Vector3.up, fRotSpeed * Time.deltaTime, iMoveRelative);
                    break;
                case EAxis._FORWARD:
                    gcTransform.Rotate(Vector3.forward, fRotSpeed * Time.deltaTime, iMoveRelative);
                    break;
                case EAxis._RIGHT:
                    gcTransform.Rotate(Vector3.right, fRotSpeed * Time.deltaTime, iMoveRelative);
                    break;
            }

        }
    }

}

