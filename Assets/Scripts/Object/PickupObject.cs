using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


namespace Object
{
    public class PickupObject : MonoBehaviour
    {

        public AudioSource PickupSound;
        public Inventory.InventoryItem inventoryItem;
        public Inventory.InventorySystem system;

        [SerializeField] private GameObject ActionDisplayBox;
        [SerializeField] private GameObject ActionTextBox;

        private bool ifTrigger = false;

        private void Start()
        {
            ActionTextBox.GetComponent<Text>().text = "Pick Up : Press Y";
        }

        private void Update()
        {
            if (ifTrigger && myGame.InputController.ifPick)
            {
                StartCoroutine(PickUp());
            }
        }

        private IEnumerator PickUp()
        {
            PickupSound.Play();          
            yield return new WaitForSeconds(PickupSound.clip.length);
            // destroy or disActive? TBD later
            //add this object into inventory system
            system.AddItem(inventoryItem, 1);
            Destroy(this.gameObject);
            ifTrigger = false;
            ActionDisplayBox.SetActive(false);
        }

        private void OnTriggerEnter(Collider other)
        {
            if (other.gameObject.CompareTag("Player"))
            {
                ifTrigger = true;              
                ActionDisplayBox.SetActive(true);
            } 

            // score in the score box increase by 1
            //myGame.GlobalScore.iCurrentScore += 1;
           
        }

        private void OnTriggerExit(Collider other)
        {
            // text disappear
            ifTrigger = false;
            ActionDisplayBox.SetActive(false);
        }


        //private void OnGUI()
        //{
        //    if (ifTrigger)
        //    {
        //        string text = "Pick Up\nPress Y";
        //        var position = Camera.main.WorldToScreenPoint(gameObject.transform.position);
        //        var textSize = GUI.skin.label.CalcSize(new GUIContent(text));
        //        GUI.Label(new Rect(position.x, Screen.height - position.y, textSize.x, textSize.y), text);
        //    }
            
        //}
    }

}

