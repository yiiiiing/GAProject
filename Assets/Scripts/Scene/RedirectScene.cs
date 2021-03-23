using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

namespace myGame
{
    public class RedirectScene : MonoBehaviour
    {

        public static int iCurrentScene;

        // Update is called once per frame
        void Update()
        {

            StartCoroutine(RedirectToLevel());
        }

        IEnumerator RedirectToLevel()
        {
            yield return new WaitForSeconds(2);
            SceneManager.LoadScene(iCurrentScene);

        }

    }
}

