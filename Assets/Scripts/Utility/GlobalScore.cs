using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

namespace myGame
{
    public class GlobalScore : MonoBehaviour
    {
        public GameObject scoreBox;

        // static score cannot display in the unity inspector
        public static int iCurrentScore = 0;

        // create a variable for displaying in the unity, which is same as iCurrentScore
        public int iMyScore;

        // text of scoreBox
        private Text gcScoreText;

        // Start is called before the first frame update
        void Start()
        {
            gcScoreText = scoreBox.GetComponent<Text>();
        }

        private void OnGUI()
        {
            iMyScore = iCurrentScore;

            // combine string and int together, would convert int to score
            gcScoreText.text = $"Score: {iMyScore}";
            
        }
    }

}
