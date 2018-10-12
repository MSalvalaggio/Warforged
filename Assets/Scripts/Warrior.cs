using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Warrior : MonoBehaviour {

    private Inventory itemSharedInventory;

    // Use this for initialization
    void Start () {
        itemSharedInventory = FindObjectOfType<InventoryManager>().ItemSharedInventory;
    }

    // Update is called once per frame
    void Update () {
		
	}
}
