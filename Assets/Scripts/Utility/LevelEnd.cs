using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace myGame
{
    public class LevelEnd : MonoBehaviour
    {
        // when finishing a level, stop level background music
        // play levelEnding sound
        // stop timeBox
        public GameObject levelMusic;
        public AudioSource levelComplete;
        public GameObject TimeBox;

        private void OnTriggerEnter(Collider other)
        {
            if (other.gameObject.tag == "Player")
            {
                levelMusic.SetActive(false);
                TimeBox.SetActive(false);
                levelComplete.Play();
            }
            
        }

    }

}

