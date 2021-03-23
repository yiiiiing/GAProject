using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

namespace Inventory
{
    public class InventorySlotBackground : MonoBehaviour
    {
        [SerializeField] Sprite selectedSprite;
        [SerializeField] Sprite disselectedSprite;

        private Image backImage;

        public void changeImageWhenSelect()
        {
            backImage = GetComponent<Image>();
            backImage.sprite = selectedSprite;
        }

        public void changeImageWhenDeselect()
        {
            backImage = GetComponent<Image>();
            backImage.sprite = disselectedSprite;
        }

    }

}
