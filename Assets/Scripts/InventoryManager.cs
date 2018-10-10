using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InventoryManager : MonoBehaviour {

    public GameObject InventorySlotPrefab;
    public RectTransform ArmorsInventory;
    public RectTransform WeaponsInventory;


    public Inventory ArmorSharedInventory;
    public Inventory WeaponSharedInventory;

    private int startingInventorySlots = 5;

    void Awake()
    {
        ArmorSharedInventory = new Inventory(new List<ItemsEnum>());
        for (int i = 0; i < startingInventorySlots; i++)
        {
            AddInventorySlot(ArmorSharedInventory);
        }

        WeaponSharedInventory = new Inventory(new List<ItemsEnum>());
        for (int i = 0; i < startingInventorySlots; i++)
        {
            AddInventorySlot(WeaponSharedInventory);
        }
    }

    public void AddPhysicalInventorySlot(Inventory inventoryToExpand)
    {
        if (inventoryToExpand == ArmorSharedInventory)
        {
            Instantiate(InventorySlotPrefab, ArmorsInventory);
        }
        else if (inventoryToExpand == WeaponSharedInventory)
        {
            Instantiate(InventorySlotPrefab, WeaponsInventory);
        }
    }

    public void AddInventorySlot(Inventory _inventoryToExpand)
    {
        _inventoryToExpand.AddLogicalInventorySlot(_inventoryToExpand);
        AddPhysicalInventorySlot(_inventoryToExpand);
    }
}