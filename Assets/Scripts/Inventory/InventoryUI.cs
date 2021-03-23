using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using UnityEngine;

namespace Inventory
{
    public class InventoryUI : MonoBehaviour
    {
        // the grid layout slots (slotsParents)
        [SerializeField] private Transform slotsParents;

        // slot in the slotsParents
        [SerializeField] private InventorySlot slotPrefab;

        // inventoryItem <-> inventory slot 
        private Dictionary<InventoryItem, InventorySlot> itemAndSlot = new Dictionary<InventoryItem, InventorySlot>();

        // initialize inventoryUI

        public void InitInventoryUI(InventorySystem inventory)
        {
            var itemAndCount = inventory.GetItemAndCount();

            
            foreach(var pair in itemAndCount)
            {
                CreateOrUpdateSlot(inventory, pair.Key,pair.Value);

            }

            // everytime, the button of first slot has been selected

            if (itemAndSlot.Count > 0)
            {
                itemAndSlot.Values.First().GetSlotButton().Select();
            }
            
        }

        public void CreateOrUpdateSlot(InventorySystem inventory, InventoryItem item, int count)
        {
            // if has key, then create item, otherwise update count
            if (!itemAndSlot.ContainsKey(item))
            {
                // create new slot
                InventorySlot slot = CreateSlot(inventory, item, count);
                itemAndSlot.Add(item, slot);
            }
            else
            {
                UpdateSlot(item, count);
            }
        }

        // update slot
        public void UpdateSlot(InventoryItem item, int count)
        {
            itemAndSlot[item].UpdateSlotCount(count);
        }

        private InventorySlot CreateSlot(InventorySystem inventory, InventoryItem item, int count)
        {
            InventorySlot slot = Instantiate(slotPrefab, slotsParents);
            slot.InitDisplaySlot(item.GetItemSprite(), item.GetItemName(), count);
            slot.AssignSlotButtonCallback(() => inventory.AssignItem(item));
            return slot;
        }

        // given item and distroy its corresponding slot
        public void DistroySlot(InventoryItem item)
        {
            Destroy(itemAndSlot[item].gameObject);
            itemAndSlot.Remove(item);
        }

    }


}
