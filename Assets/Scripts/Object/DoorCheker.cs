using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

namespace myGame
{
    public class DoorCheker : MonoBehaviour
    {
        public GameObject ActionDisplay;
        public GameObject ActionText;

        public GameObject leftDoor;
        public GameObject rightDoor;

        public AudioSource openDoorAudio;

        private bool canOpenDoor;

        private void Start()
        {
            ActionText.GetComponent<Text>().text = "Open Gate : Press A";
        }

        private void Update()
        {
            if (canOpenDoor)
            {
                if (InputController.ifEnter)
                {
                    openDoorAudio.Play();
                    canOpenDoor = false;

                    // door open text appear
                    ActionDisplay.SetActive(false);
                    gameObject.SetActive(false);

                    leftDoor.GetComponent<DoorRotate>().ChangeDoorState(DoorRotate.DoorState.open);
                    rightDoor.GetComponent<DoorRotate>().ChangeDoorState(DoorRotate.DoorState.open);


                }
            }
        }

        private void OnTriggerEnter(Collider other)
        {
            if (other.gameObject.CompareTag("Player"))
            {
                // door open text appear
                ActionDisplay.SetActive(true);
                canOpenDoor = true;
                

            }
        }

        private void OnTriggerExit(Collider other)
        {
            if (other.gameObject.CompareTag("Player"))
            {
                // door open text appear
                canOpenDoor = false;
                ActionDisplay.SetActive(false);

            }
        }
    }

}
