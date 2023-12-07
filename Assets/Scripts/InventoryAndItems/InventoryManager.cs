using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InventoryManager : MonoBehaviour
{
    public GameObject InventoryMenu;
    private bool menuActivated;
    public ItemSlot[] ItemSlot;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetButtonDown("Inventory") && menuActivated)
        {
            Time.timeScale = 1;
            InventoryMenu.SetActive(false);
            menuActivated = false;
            Cursor.lockState = CursorLockMode.Locked;
            Cursor.visible = false;
        }
        else if (Input.GetButtonDown("Inventory") && !menuActivated)
        {
            Time.timeScale = 0;
            InventoryMenu.SetActive(true);
            menuActivated = true;
            Cursor.lockState = CursorLockMode.None;
            Cursor.visible = true;
        }
    }
    public int AddItem(string itemName, int quantity, Sprite itemSprite, string itemDescription)
    {
        for (int i = 0; i < ItemSlot.Length; i++)
        {
            if (ItemSlot[i].isFull == false && ItemSlot[i].name == name || ItemSlot[i].quantity == 0)
            {
                int leftOverItems = ItemSlot[i].AddItem(itemName, quantity, itemSprite, itemDescription);
                if (leftOverItems > 0)
                    leftOverItems = AddItem(itemName, leftOverItems, itemSprite, itemDescription);
                
                return leftOverItems;
            }
        }
        return quantity;
    }
    public void DeselectAllSlots()
    {
        for (int i = 0; i < ItemSlot.Length; i++)
        {
            ItemSlot[i].selectedShader.SetActive(false);
            ItemSlot[i].thisItemSelected = false;
        }
    }
}
