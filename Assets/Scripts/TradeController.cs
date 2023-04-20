using System;
using UnityEngine;


public class TradeController : MonoBehaviour
{
    InteractionManager _interactionManager;

    private void Start()
    {
        _interactionManager = InteractionManager.instance;
    }


    
    // MERGE IF I HAVE TIME with parameters
    [ContextMenu("sell item")]
    public void SellItem()
    {
        if (_interactionManager.playerInventory._selectedItem < 0)
            return;
        Inventory _npcInventory = _interactionManager.npcInventory.inventoryReference; 
        Inventory _playerInventory = _interactionManager.playerInventory.inventoryReference;
        Item item = AllItems.GetItemByName(_playerInventory.GetItems()[_playerInventory.selectedItem]);

        _playerInventory.money += item.price;
        _npcInventory.AddItem(item.itemName);
      
        _playerInventory.RemoveItem(item.itemName);
        
        _interactionManager.playerInventory.GenerateInventory();
        _interactionManager.npcInventory.GenerateInventory();
        Canvas.ForceUpdateCanvases();
    }

    [ContextMenu("buy item")]
    public void BuyItem()
    {
        if (_interactionManager.playerInventory._selectedItem < 0)
            return;
        Inventory _npcInventory = _interactionManager.npcInventory.inventoryReference; 
        Inventory _playerInventory = _interactionManager.playerInventory.inventoryReference;
        Item item = AllItems.GetItemByName(_npcInventory.GetItems()[_npcInventory.selectedItem]);

        _npcInventory.money += item.price;
        _playerInventory.AddItem(item.itemName);
      
        _npcInventory.RemoveItem(item.itemName);
        
        _interactionManager.playerInventory.GenerateInventory();
        _interactionManager.npcInventory.GenerateInventory();
        Canvas.ForceUpdateCanvases();
    }
}