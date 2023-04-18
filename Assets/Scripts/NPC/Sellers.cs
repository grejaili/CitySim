using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Serialization;


public class Sellers : NPCController
{
    [SerializeField] private Inventory inventory;
    [SerializeField] private GameObject tradeWindow;
    
    protected override void Interaction()
    {
        OpenTradeWindow();
    }


    public void OpenTradeWindow()
    {
        foreach (var item in  inventory.GetItems())
        {
           Debug.Log(AllItems.GetItemByName(item).itemID) ;
        }
    }
    
}