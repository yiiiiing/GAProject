using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

namespace myGame
{
    public class GlobalTIme : MonoBehaviour
    {
        public GameObject timeBox;

        // set total time and display current time in the unity
        public int iTotalTime = 60;

        public int iCurrentTime;

        private Text timeText;

        private bool ifUpdateTime = false;
        // Start is called before the first frame update
        void Start()
        {
            timeText = timeBox.GetComponent<Text>();
            iCurrentTime = iTotalTime;
            timeText.text = $"Time: {iCurrentTime}";      

        }

        // Update is called once per frame
        void OnGUI()
        {
            if (!ifUpdateTime)
            {
                // begine to record time
                StartCoroutine(UpdateTime());
            }         
            
        }

        IEnumerator UpdateTime()
        {
            ifUpdateTime = true;
            yield return new WaitForSeconds(1.0f);
            iCurrentTime -= 1;
            timeText.text = $"Time: {iCurrentTime}";
            ifUpdateTime = false;
        }
    }


}
