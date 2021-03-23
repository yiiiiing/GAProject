using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Inventory
{
    [CreateAssetMenu(fileName = "new InventorySystem", menuName = "Inventory/InventorySystem")]

    // control the whole inventory system
    public class InventorySystem : ScriptableObject
    {
        // list of inventory items (need to add items in the unity inspector)
        [SerializeField] private List<InventoryItemWrapper> itemList = new List<InventoryItemWrapper>();

        // inventoryUI object
        [SerializeField] private InventoryUI inventoryUIPrefab;
        private InventoryUI _inventoryUI = null;
        private InventoryUI inventoryUI {
            get
            {
                if (!_inventoryUI)
                {
                    _inventoryUI = Instantiate(inventoryUIPrefab, playerEquipment.GetInventoryUIParents());
                }
                return _inventoryUI;             
            }
        }

        // dictionary (inventoryItem and it's count)
        private Dictionary<InventoryItem, int> itemAndCount = new Dictionary<InventoryItem, int>();

        // player equipment
        private myGame.PlayerEquipmentController playerEquipment;

        // add all info of inventory Items into dictionary
        public void InitInventory(myGame.PlayerEquipmentController playerEquipment)
        {
            this.playerEquipment = playerEquipment;
            for (int i = 0; i < itemList.Count; i++)
            {
                itemAndCount.Add(itemList[i].GetItem(), itemList[i].GetCount());
            }
        }

        // open and close inventory UI
        public void OpenInventoryUI()
        {
            inventoryUI.gameObject.SetActive(true);
            inventoryUI.InitInventoryUI(this);
            
            
        }

        public void CloseInventoryUI()
        {
            inventoryUI.gameObject.SetActive(false);
            
         
        }


        // when the item is assigned to the player
        // when the the item is clicked
        public void AssignItem(InventoryItem item)
        {
            string name = item.GetItemName();
            Debug.Log($"The item: {name} has been used");
            item.AssignItemToPlayer(playerEquipment);
        }

        // get the dictionary(inventory items and its counts)
        public Dictionary<InventoryItem, int> GetItemAndCount()
        {
            return itemAndCount;
        }

        // add item to the dictionary
        public void AddItem(InventoryItem item, int count)
        {
            int currentCount;
            // if find item, then add the count
            // if not, add the item into dictionary
            if(itemAndCount.TryGetValue(item, out currentCount))
            {
                itemAndCount[item] = currentCount + count;
            }
            else
            {
                itemAndCount.Add(item, count);
            }
            //Debug.Log($"In inventorySystem, item count is {count+currentCount}");

            // inventoryUI should create/update item and its count
            inventoryUI.CreateOrUpdateSlot(this, item, count);
        }

        public void RemoveItem(InventoryItem item, int count)
        {
            int currentCount;
            // if find item, then add the count
            // if not, add the item into dictionary
            if (itemAndCount.TryGetValue(item, out currentCount))
            {
                // if currentCount - count < 0, then destroy this item
                int newCount = currentCount - count;
                if(newCount <= 0)
                {
                    itemAndCount[item] = 0;
                    // inventory UI should destory this slot
                    inventoryUI.DistroySlot(item);
                }
                else
                {
                    itemAndCount[item] = newCount;
                    // inventory UI should update this count
                    inventoryUI.UpdateSlot(item, newCount);

                }
            }
            else
            {
                Debug.Log($"No item: {name} in the inventory system");
            }
        }

       
    }

}
