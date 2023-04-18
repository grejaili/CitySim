using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Serialization;
using UnityEngine.UIElements;

public class InteractionManager : MonoBehaviour
{
    public static InteractionManager instance;

    public InventoryUI playerInventory;
    public InventoryUI npcInventory;
    public GameObject tradePanel;
    public Button buyButton;
    public Button sellButton;

    // Start is called before the first frame update
    private void Awake()
    {
        instance = this;
    }

    public void OpenClosePlayerInventory()
    {
        playerInventory.gameObject.SetActive(!playerInventory.gameObject.activeSelf);
    }

    public void OpenCloseNPCInventory()
    {
        if (playerInventory.gameObject.activeSelf.Equals(false))
        {
            playerInventory.gameObject.SetActive(true);
        }
        npcInventory.gameObject.SetActive(!npcInventory.gameObject.activeSelf);
    }
    public void OpenCloseNPCInventory(bool aux)
    {
        playerInventory.gameObject.SetActive(false);
        npcInventory.gameObject.SetActive(aux); 
    }
    
}