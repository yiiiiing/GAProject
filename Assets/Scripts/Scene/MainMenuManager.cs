using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

namespace myGame
{
    public class MainMenuManager : MonoBehaviour
    {
        public AudioSource StartGameSound;

        public void PlayGame()
        {
            StartGameSound.Play();
            RedirectScene.iCurrentScene = (int)myGame.Constants.Scenes.BossCastle;
            StartCoroutine(ChangeScene());           
        }

        IEnumerator ChangeScene()
        {
            yield return new WaitForSeconds(0.7f);          
            SceneManager.LoadScene((int)myGame.Constants.Scenes.RedirectScene);

        }


        public void QuitGame()
        {
            Application.Quit();
        }
    }

}
