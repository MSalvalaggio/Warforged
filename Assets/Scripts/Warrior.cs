using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Warrior : MonoBehaviour {

    private Inventory armorSharedInventory;
    private Inventory weaponSharedInventory;

    // Use this for initialization
    void Start () {
        armorSharedInventory = FindObjectOfType<InventoryManager>().ArmorSharedInventory;
        weaponSharedInventory = FindObjectOfType<InventoryManager>().WeaponSharedInventory;
    }
	
	// Update is called once per frame
	void Update () {
		
	}
}
