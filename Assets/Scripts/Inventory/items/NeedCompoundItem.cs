using System.Collections;
using System.Collections.Generic;
using myGame;
using UnityEngine;

namespace Inventory
{
    [CreateAssetMenu(fileName = "new item", menuName = "Inventory/NeedCompoundItem")]
    public class NeedCompoundItem : InventoryItem
    {
        [SerializeField] private float healthValue;
        [SerializeField] private float magicValue;

        public override void AssignItemToPlayer(PlayerEquipmentController playerEquipment)
        {
            playerEquipment.AssignCompoundItem(this);
        }

    }

}
