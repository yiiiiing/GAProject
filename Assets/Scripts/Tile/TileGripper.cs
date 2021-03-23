using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace myGame
{
    public class TileGripper : MonoBehaviour
    {
        public GameObject playerObject;
        public GameObject theLedge;

        private void OnTriggerEnter(Collider other)
        {
            if (other.gameObject.tag == "Player")
            {
                //Debug.Log("Player is standing on this platform");
                // the player's parant should has same gizmos as player
                // also its parant should be moving one
                playerObject.transform.parent = theLedge.transform;
            }
  
        }

        private void OnTriggerExit(Collider other)
        {
            if (other.gameObject.tag == "Player")
            {
                //Debug.Log("Player is leaving on this platform");
                playerObject.transform.parent = null;
            }


        }
    }
}
