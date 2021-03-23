using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

namespace myGame
{
    public class SplashScreen : MonoBehaviour
    {
        public int fSplashScreenDurationSeconds;
        // Update is called once per frame
        void Update()
        {
            StartCoroutine(StartSplash());
        }

        IEnumerator StartSplash()
        {
            yield return new WaitForSeconds(fSplashScreenDurationSeconds);
            SceneManager.LoadScene((int)myGame.Constants.Scenes.MainMenu);
        }
    }
}

