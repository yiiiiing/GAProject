using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

namespace myGame
{
    public class Death : MonoBehaviour
    {
        void OnTriggerEnter()
        {

            SceneManager.LoadScene((int)myGame.Constants.Scenes.DeathScene);
        }
    }

}
