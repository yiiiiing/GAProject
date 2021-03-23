using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

namespace Object
{
    // because I add button component to itemIcon, so I add selectHandler to it 
    public class ItemIcon: MonoBehaviour, ISelectHandler, IDeselectHandler
    {
        [SerializeField] GameObject background;

        public void OnSelect(BaseEventData eventData)
        {
            //Debug.Log(this.gameObject.name + " was selected");
            // change background's image
            background.GetComponent<Inventory.InventorySlotBackground>().changeImageWhenSelect();
        }

        public void OnDeselect(BaseEventData eventData)
        {
            //Debug.Log(this.gameObject.name + "'s selection is cancled");
            background.GetComponent<Inventory.InventorySlotBackground>().changeImageWhenDeselect();
        }

    }

}
