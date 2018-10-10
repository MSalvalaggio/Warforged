using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Blacksmith : MonoBehaviour {

    private int currentLevel = 1;
    private int currentClick;
    private int clickToReach = 5;

    private Inventory armorSharedInventory;
    private Inventory weaponSharedInventory;

    // Use this for initialization
    void Start ()
    {
        armorSharedInventory = FindObjectOfType<InventoryManager>().ArmorSharedInventory;
        weaponSharedInventory = FindObjectOfType<InventoryManager>().WeaponSharedInventory;
    }
	
	// Update is called once per frame
	void Update ()
    {
        if (Input.touchCount > 0 && Input.GetTouch(0).phase == TouchPhase.Began)
        {
            // Suono del ferro sull'incudine
            currentClick++;
            if (currentClick >= clickToReach)
            {
                currentClick = 0;
                SmithItem();
                //armorSharedInventory.Items.ForEach((element) => { print(element); });
                //weaponSharedInventory.Items.ForEach((element) => { print(element); });
            }
        }
	}

    public void SmithItem()
    {
        
        switch (currentLevel)
        {
            case 1:
                FillInventory(ItemsEnum.Armor_001, ItemsEnum.Weapon_001);
                break;
            case 2:
                FillInventory(ItemsEnum.Armor_002, ItemsEnum.Weapon_002);
                break;
            case 3:
                FillInventory(ItemsEnum.Armor_003, ItemsEnum.Weapon_003);
                break;
            case 4:
                FillInventory(ItemsEnum.Armor_004, ItemsEnum.Weapon_004);
                break;
            case 5:
                FillInventory(ItemsEnum.Armor_005, ItemsEnum.Weapon_005);
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

    public void FillInventory(ItemsEnum armorToAdd, ItemsEnum weaponsToAdd)
    {
        int tmpRngNum = Random.Range(0, 2);

        if (tmpRngNum == 0)
        {
            armorSharedInventory.AddItemToAvailableInventory(armorSharedInventory, weaponSharedInventory, armorToAdd, weaponsToAdd);
        }
        else if (tmpRngNum == 1)
        {
            weaponSharedInventory.AddItemToAvailableInventory(weaponSharedInventory, armorSharedInventory, weaponsToAdd, armorToAdd);
        }
    }

    public void AddBlackSmithLevel()
    {
        currentLevel++;
    }
}