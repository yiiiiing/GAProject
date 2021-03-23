using System;
using System.Collections;
using System.Collections.Generic;
using Inventory;
using UnityEngine;

namespace myGame
{
    // connect character to inventory
    public class PlayerEquipmentController : MonoBehaviour
    {
        [SerializeField] private Inventory.InventorySystem inventory;

        [SerializeField] private Transform inventoryUIParents;


        public void AssignCompoundItem(NeedCompoundItem needCompoundItem)
        {
            //Debug.Log("click the Needcompound item");
        }

        private void Start()
        {
            inventory.InitInventory(this);
            
        }

        public Transform GetInventoryUIParents()
        {
            return inventoryUIParents;
        }

        // TODO: if press menu button, closeMenu, if press UI.menu, then close the menu
        public void CloseMenu()
        {
            InputController.currentStatus = Constants.GameStatus.Normal;
            Debug.Log("close");
            inventory.CloseInventoryUI();           
        }

        public void OpenMenu()
        {
            inventory.OpenInventoryUI();
            InputController.currentStatus = Constants.GameStatus.MenuScene;
        }
    }
}

