using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace myTransform
{
    public class AlwaysLerpFromTwoPoints : MonoBehaviour
    {
        // two lerp points
        public Transform gcLerpPoint1;
        public Transform gcLerpPoint2;

        // lerp seconds(how much time take moving object from start to end)
        public float fLerpDurationSeconds = 3.0f;

        private float fEventTime;

        private float fRatio;

        // Start is called before the first frame update
        void Start()
        {
            fEventTime = Time.time;
        }

        // Update is called once per frame
        void Update()
        {
            fRatio = (Time.time - fEventTime) / fLerpDurationSeconds;

            transform.position = Vector3.Lerp(gcLerpPoint1.position, gcLerpPoint2.position, fRatio);

            if (fRatio > 1.0f)
            {
                var gcTemp = gcLerpPoint1;
                gcLerpPoint1 = gcLerpPoint2;
                gcLerpPoint2 = gcTemp;
                fEventTime = Time.time;
            }
        }
    }

}
