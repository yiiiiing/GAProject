using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace myGame
{
    public class BossCutScene : MonoBehaviour
    {
        public GameObject thePlayer;
        public GameObject cutCamera;

        public GameObject leftDoor;
        public GameObject rightDoor;


        public AudioSource fightBossBGM;

        public AudioSource closeDoor;

        private bool ifCutSceneFinish = false;

        public GameObject bossHPbar;

        private void OnTriggerEnter(Collider other)
        {

            // play cutscene animation
            StartCoroutine(cutScene());

        }

        IEnumerator cutScene()
        {
            InputController.currentStatus = Constants.GameStatus.CutScene;
            closeDoor.Play();
            // door close
            leftDoor.GetComponent<DoorRotate>().ChangeDoorState(DoorRotate.DoorState.close);
            rightDoor.GetComponent<DoorRotate>().ChangeDoorState(DoorRotate.DoorState.close);
            yield return new WaitForSeconds(3.5f);

            //thePlayer.SetActive(false);
            cutCamera.SetActive(true);
            yield return new WaitForSeconds(6);
            cutCamera.SetActive(false);
            // when cutscene animation is finished and enble the inputs from player
            //thePlayer.SetActive(true);

            // and active boss fighting music
            fightBossBGM.Play();
            gameObject.SetActive(false);
            InputController.currentStatus = Constants.GameStatus.Normal;
            ifCutSceneFinish = true;
            bossHPbar.SetActive(true);

        }

        public bool GetIfCutSceneFinish()
        {
            return ifCutSceneFinish;
        }
    }
}

