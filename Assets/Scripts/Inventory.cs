using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Inventory {

    public List<ItemsEnum> Items;
    public List<Image> InventoryItemsImages;

    public Inventory(List<ItemsEnum> newItems, List<Image> newInventorySlots)
    {
        Items = newItems;
        InventoryItemsImages = newInventorySlots;
    }

    public void AddLogicalInventorySlot(Inventory inventoryToExpand)
    { 
        inventoryToExpand.Items.Add(ItemsEnum.Null_Item);
    }

    public void AddItemToAvailableInventory(Inventory inventoryToCheck, ItemsEnum itemToAdd, Sprite spriteToUse)
    {
        for (int i = 0; i < Items.Count; i++)
        {
            if (Items[i] == ItemsEnum.Null_Item && InventoryItemsImages[i].sprite == null)
            {
                inventoryToCheck.Items[i] = itemToAdd;
                inventoryToCheck.InventoryItemsImages[i].sprite = spriteToUse;
                return;
            }
        }
        Debug.LogError("HAI FINITO GLI OGGETTI NELL'INVENTARIO! BASTA SPAMMARE!");
    }
}
