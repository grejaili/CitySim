using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Serialization;

public class ItensInUse : MonoBehaviour
{
    private string armorInUse = "";
    private string weaponInuse;
    InteractionManager _interactionManager;
    public ItemUI armorSlot;
    public ItemUI weaponSlot;
   public Sprite unUsedSlot;
    
    private void Start()
    {
        _interactionManager = InteractionManager.instance;
    }

    private void OnEnable()
    {
        if (armorInUse != "")
        {
            updateArmorSlot(AllItems.GetItemByName(armorInUse));
        }
        else
        {
            EmptySlot();
        }
    }

    private void EmptySlot()
    {
        armorSlot.icon.sprite = unUsedSlot;
        armorSlot.name.text = "No armor";
        armorSlot.price.text = "";
    }

    void updateArmorSlot(Item item)
    {
        GenerateSlot(item,armorSlot);
    }

    private void GenerateSlot(Item item,ItemUI slotType)
    {
        Sprite spriteIcon = Sprite.Create(item.icon,
            new Rect(0, 0, item.icon.width, item.icon.height),
            Vector2.one / 2, 100);
        slotType.icon.sprite = spriteIcon;
        slotType.name.text = item.itemName;
        slotType.price.text = "Price: " + item.price;
    }

    [ContextMenu("EQUIP SELECTED ITEM")]
    public void EquipSelectedItem()
    {
        
        if (_interactionManager.playerInventory._selectedItem < 0)
            return;
     
        Inventory _playerInventory = _interactionManager.playerInventory.inventoryReference;
        Item item = AllItems.GetItemByName(_playerInventory.GetItems()[_playerInventory.selectedItem]);
        switch (item.type)
        {
            case "armor":

                if (armorInUse != "")
                    return;
                
                armorInUse = item.itemName;
                updateArmorSlot(item);
                break;
            case "weapon":
                if(weaponInuse != "")
                    return;
                weaponInuse = item.itemName;
                break;
            
        }
        _playerInventory.RemoveItem(item.itemName);
        _interactionManager.playerInventory.GenerateInventory();
        
        Canvas.ForceUpdateCanvases();
    }


    public void RemoveItem(string type)
    {
        switch ( type)
        {
            case "armor":
                if(armorInUse == "")
                    return;
                _interactionManager.playerInventory.inventoryReference.AddItem(armorInUse);
                _interactionManager.playerInventory.GenerateInventory();
                armorInUse = "";
                EmptySlot();
                break;
            case "weapon":
                if(armorInUse == "")
                    return;
                _interactionManager.playerInventory.inventoryReference.AddItem(weaponInuse);
                _interactionManager.playerInventory.GenerateInventory();
                weaponInuse = "";
                EmptySlot();
                break;
            
        }
        
    }

    
}
