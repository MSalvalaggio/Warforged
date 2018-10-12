using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MenuManager : MonoBehaviour {

    public Canvas BlacksmithCanvas;
    public Canvas InventoryCanvas;

    public void EnableBlacksmithCanvas()
    {
        BlacksmithCanvas.gameObject.SetActive(true);
        Blacksmith.IsClickerActive = true;
    }

    public void EnableInventoryCanvas()
    {
        InventoryCanvas.gameObject.SetActive(true);
        Blacksmith.IsClickerActive = false;
    }
}