using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace myGame
{
    public class RotateSkybox : MonoBehaviour
    {
        // roate speed (roate speed relative to real time)
        // default is 0, which is static time
        [SerializeField]
        private float fRoateSpeed = 1.2f;

        // Update is called once per frame
        void Update()
        {
            RenderSettings.skybox.SetFloat("_Rotation", Time.time * fRoateSpeed);
        }
    }

}
