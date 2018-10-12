using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class InventoryManager : MonoBehaviour {

    public static InventoryManager Instance;

    public GameObject InventorySlotPrefab;
    public RectTransform ItemsInventory;
    public Inventory ItemSharedInventory;
    public List<Sprite> ArmorSprites;
    public List<Sprite> WeaponSprites;

    private int startingInventorySlots = 4;

    void Awake()
    {
        if (Instance == null)
        {
            Instance = this;
        }
        else
        {
            Destroy(gameObject);
        }

        ItemSharedInventory = new Inventory(new List<ItemsEnum>(), new List<Image>());

        for (int i = 0; i < startingInventorySlots; i++)
        {
            AddInventorySlot(ItemSharedInventory);
        }
    }

    private void AddPhysicalInventorySlot(Inventory inventoryToExpand)
    {
        inventoryToExpand.InventoryItemsImages.Add(Instantiate(InventorySlotPrefab, ItemsInventory).GetComponentsInChildren<Image>()[1]);
    }

    public void AddInventorySlot(Inventory _inventoryToExpand)
    {
        _inventoryToExpand.AddLogicalInventorySlot(_inventoryToExpand);
        AddPhysicalInventorySlot(_inventoryToExpand);
    }
}