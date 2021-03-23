using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Inventory
{
    [System.Serializable] // can see in the inspector
    public class InventoryItemWrapper
    {
        [SerializeField] InventoryItem item;
        [SerializeField] int count;

        public InventoryItem GetItem()
        {
            return item;
        }

        public int GetCount()
        {
            return count;
        }
    }
}

