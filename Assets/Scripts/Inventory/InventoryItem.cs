using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Inventory
{
    // scriptableObject is a data container to store item's information
    //[CreateAssetMenu(fileName = "new InventoryItem", menuName = "Inventory/InventoryItem", order = 1)]
    // item can be in the inventory system
    public abstract class InventoryItem : ScriptableObject
    {
        // item model
        [SerializeField] private GameObject itemPrefab;
        // item graphics
        [SerializeField] Sprite itemSprite;
        // item name
        [SerializeField] string itemName;
        // if item is weapon,then item has position and rotation
        [SerializeField] Vector3 itemLocalPosition;
        [SerializeField] Vector3 itemLocalRotation;

        // getter method
        public GameObject GetItemPrefab()
        { 
            return itemPrefab;
        }

        public Sprite GetItemSprite()
        {
            return itemSprite;
        }

        public string GetItemName()
        {
            return itemName;
        }

        public Vector3 GetItemLocalPosition()
        {
            return itemLocalPosition;
        }

        public Quaternion GetItemLocalRotation()
        {
            return Quaternion.Euler(itemLocalRotation);
        }

        // when assign the item to the player
        public abstract void AssignItemToPlayer(myGame.PlayerEquipmentController playerEquipment);
        

    }
}

