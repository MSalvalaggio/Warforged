using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Blacksmith : MonoBehaviour {

    public static bool IsClickerActive;

    public Image Blacksmith_House;
    private Animator Blacksmith_House_Animator;

    private int currentLevel = 1;
    private int currentClick;
    private int clickToReach = 5;

    private Inventory itemSharedInventory;

    // Use this for initialization
    void Start ()
    {
        IsClickerActive = true;
        itemSharedInventory = FindObjectOfType<InventoryManager>().ItemSharedInventory;
        Blacksmith_House_Animator = Blacksmith_House.GetComponent<Animator>();
    }
	
	// Update is called once per frame
	void Update ()
    {
        if (Input.touchCount > 0 && Input.GetTouch(0).phase == TouchPhase.Began && IsClickerActive)
        {
            // Suono del ferro sull'incudine
            AnimateClickedBlacksmithHouse();
            currentClick++;
            if (currentClick >= clickToReach)
            {
                currentClick = 0;
                SmithItem();
            }
        }
	}

    public void SmithItem()
    {
        switch (currentLevel)
        {
            case 1:
                FillInventory(ItemsEnum.Armor_001, ItemsEnum.Weapon_001, InventoryManager.Instance.ArmorSprites[0], InventoryManager.Instance.WeaponSprites[0]);
                break;
            case 2:
                FillInventory(ItemsEnum.Armor_002, ItemsEnum.Weapon_002, InventoryManager.Instance.ArmorSprites[1], InventoryManager.Instance.WeaponSprites[1]);
                break;
            case 3:
                FillInventory(ItemsEnum.Armor_003, ItemsEnum.Weapon_003, InventoryManager.Instance.ArmorSprites[2], InventoryManager.Instance.WeaponSprites[2]);
                break;
            case 4:
                FillInventory(ItemsEnum.Armor_004, ItemsEnum.Weapon_004, InventoryManager.Instance.ArmorSprites[3], InventoryManager.Instance.WeaponSprites[3]);
                break;
            case 5:
                FillInventory(ItemsEnum.Armor_005, ItemsEnum.Weapon_005, InventoryManager.Instance.ArmorSprites[4], InventoryManager.Instance.WeaponSprites[4]);
                break;
            case 6:
                FillInventory(ItemsEnum.Armor_006, ItemsEnum.Weapon_006);
                break;
            case 7:
                FillInventory(ItemsEnum.Armor_007, ItemsEnum.Weapon_007);
                break;
            case 8:
                FillInventory(ItemsEnum.Armor_008, ItemsEnum.Weapon_008);
                break;
            case 9:
                FillInventory(ItemsEnum.Armor_009, ItemsEnum.Weapon_009);
                break;
            case 10:
                FillInventory(ItemsEnum.Armor_010, ItemsEnum.Weapon_010);
                break;
            case 11:
                FillInventory(ItemsEnum.Armor_011, ItemsEnum.Weapon_011);
                break;
            case 12:
                FillInventory(ItemsEnum.Armor_012, ItemsEnum.Weapon_012);
                break;
            case 13:
                FillInventory(ItemsEnum.Armor_013, ItemsEnum.Weapon_013);
                break;
            case 14:
                FillInventory(ItemsEnum.Armor_014, ItemsEnum.Weapon_014);
                break;
            case 15:
                FillInventory(ItemsEnum.Armor_015, ItemsEnum.Weapon_015);
                break;
            case 16:
                FillInventory(ItemsEnum.Armor_016, ItemsEnum.Weapon_016);
                break;
            case 17:
                FillInventory(ItemsEnum.Armor_017, ItemsEnum.Weapon_017);
                break;
            case 18:
                FillInventory(ItemsEnum.Armor_018, ItemsEnum.Weapon_018);
                break;
            case 19:
                FillInventory(ItemsEnum.Armor_019, ItemsEnum.Weapon_019);
                break;
            case 20:
                FillInventory(ItemsEnum.Armor_020, ItemsEnum.Weapon_020);
                break;
            case 21:
                FillInventory(ItemsEnum.Armor_021, ItemsEnum.Weapon_021);
                break;
            case 22:
                FillInventory(ItemsEnum.Armor_022, ItemsEnum.Weapon_022);
                break;
            case 23:
                FillInventory(ItemsEnum.Armor_023, ItemsEnum.Weapon_023);
                break;
            case 24:
                FillInventory(ItemsEnum.Armor_024, ItemsEnum.Weapon_024);
                break;
            case 25:
                FillInventory(ItemsEnum.Armor_025, ItemsEnum.Weapon_025);
                break;
            case 26:
                FillInventory(ItemsEnum.Armor_026, ItemsEnum.Weapon_026);
                break;
            case 27:
                FillInventory(ItemsEnum.Armor_027, ItemsEnum.Weapon_027);
                break;
            case 28:
                FillInventory(ItemsEnum.Armor_028, ItemsEnum.Weapon_028);
                break;
            case 29:
                FillInventory(ItemsEnum.Armor_029, ItemsEnum.Weapon_029);
                break;
            case 30:
                FillInventory(ItemsEnum.Armor_030, ItemsEnum.Weapon_030);
                break;
        }
    }

    public void FillInventory(ItemsEnum armorToAdd, ItemsEnum weaponsToAdd, Sprite armorItemSprite = null, Sprite weaponItemSprite = null)
    {
        int tmpRngNum = Random.Range(0, 2);

        if (tmpRngNum == 0)
        {
            itemSharedInventory.AddItemToAvailableInventory(itemSharedInventory, armorToAdd, armorItemSprite);
        }
        else if (tmpRngNum == 1)
        {
            itemSharedInventory.AddItemToAvailableInventory(itemSharedInventory, weaponsToAdd, weaponItemSprite);
        }
    }

    public void AddBlackSmithLevel()
    {
        currentLevel++;
    }

    public void AnimateClickedBlacksmithHouse()
    {
        if (IsClickerActive)
        {
            Blacksmith_House_Animator.Play("Blacksmith_House_Click_Animation");
        }
    }
}