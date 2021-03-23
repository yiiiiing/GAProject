using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.UI;

namespace Inventory
{
    public class InventorySlot : MonoBehaviour
    {
        [SerializeField] private Image itemIcon;
        [SerializeField] private Text itemName;
        [SerializeField] private Text itemCount;

        // the slotButton is added to the itemIcon(itemIcon has button component, which means that
        // that the itemIcon can be regarded as a button)
        [SerializeField] private Button slotButton;

        // display slots
        public void InitDisplaySlot(Sprite sprite, string name, int count)
        {
            itemIcon.sprite = sprite;
            itemName.text = name;
            UpdateSlotCount(count);
        }

        public void UpdateSlotCount(int count)
        {
            itemCount.text = count.ToString();
        }

        public Button GetSlotButton()
        {
            return slotButton;
        }

        // when click button, then run onClickCallback
        // TODO: when using controller to select button, button click should invoke
        public void AssignSlotButtonCallback(System.Action onClickCallback)
        {
            // pass result from onClick to onClickCallback function
            slotButton.onClick.AddListener(()=>onClickCallback());

        }

        //private void Update()
        //{
        //    if (!ifSlotSelected && EventSystem.current.currentSelectedGameObject == slotButton.gameObject)
        //    {
        //        ifSlotSelected = true;
        //        // change background
        //    }
        //    else
        //    {
        //        // button is default background
        //    }
        //}
    }

}
