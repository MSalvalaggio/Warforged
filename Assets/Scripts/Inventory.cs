using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Inventory {

    public List<ItemsEnum> Items;

    public Inventory(List<ItemsEnum> newItems)
    {
        Items = newItems;
    }

    public void AddLogicalInventorySlot(Inventory inventoryToExpand)
    { 
        inventoryToExpand.Items.Add(ItemsEnum.Null_Item);
    }

    public void AddItemToAvailableInventory(Inventory firstInventoryToCheck, Inventory secondInventoryListToCheck, ItemsEnum itemToAddToFirstList, ItemsEnum itemToAddToSecondList)
    {
        if (firstInventoryToCheck.Items.Contains(ItemsEnum.Null_Item))
        {
            firstInventoryToCheck.Items[firstInventoryToCheck.Items.IndexOf(ItemsEnum.Null_Item)] = itemToAddToFirstList;
        }
        else if (secondInventoryListToCheck.Items.Contains(ItemsEnum.Null_Item))
        {
            secondInventoryListToCheck.Items[secondInventoryListToCheck.Items.IndexOf(ItemsEnum.Null_Item)] = itemToAddToSecondList;
        }
        else
        {
            //TODO Messaggio di errore perché hai finito gli slot e devi potenziare
            Debug.LogError("HAI FINITO GLI OGGETTI NELL'INVENTARIO! BASTA SPAMMARE!");
        }
    }
}
