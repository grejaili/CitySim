using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.UI;
using Button = UnityEngine.UIElements.Button;

public class InventoryUI : MonoBehaviour
{
    public Inventory inventoryReference;
    public ItemUI ItemBase;
    public Transform Itemholder;
 

     private List<ItemUI> _uiItems = new List<ItemUI>();

  [SerializeField] private float _selectedItem;
     
    private void OnEnable()
    {
        var list = inventoryReference.GetItems();
        
        for (var index = 0; index < list.Count; index++)
        {
            var item = list[index];
            var uiItem = Instantiate(ItemBase, Itemholder);
            var itemInfo = AllItems.GetItemByName(item);
            Debug.Log(itemInfo);
            Sprite spriteIcon = Sprite.Create(itemInfo.icon,
                new Rect(0, 0, itemInfo.icon.width, itemInfo.icon.height),
                Vector2.one / 2, 100);

            
            uiItem.icon.sprite = spriteIcon;
            uiItem.name.text = itemInfo.itemName;
            uiItem.price.text = "Price: " + itemInfo.price;

            var index1 = index;
            uiItem.button.onClick.AddListener(()=>SetSelectItem(index1));
            _uiItems.Add(uiItem);
        }
    }

    void SetSelectItem(int index)
    {
        _selectedItem = index;
        
    }
    
    private void OnDisable()
    {
        foreach (var item in _uiItems)
        {
            Destroy(item.GameObject());
        }
        _uiItems.Clear();
    }
}
