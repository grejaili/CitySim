using System.Collections.Generic;
using UnityEngine;


public static class AllItems
{
   public static Dictionary <string, Item> items = new Dictionary<string, Item>();

   public  static void CreateAllItems()
   {

       items.Add("item1", new Item("item1",1f,1,"armor"));
       items.Add("item2", new Item("item2",1f,2,"armor"));
       items.Add("item3", new Item("item3",1f,3,"armor"));
       items.Add("item4", new Item("item4",1f,4,"armor"));
   
   }

   public static Item GetItemByName(string name)
   {
       
       return items[name];
   }
}


public class Item   
{
    public Item(string _itemName,float _price, int _itemID,string _type)
    {
        itemName = _itemName;
        price = _price;
        itemID = _itemID;
        icon = Resources.Load("Icons/" + _itemName) as Texture2D;
        type = _type;
    }
    
    public string itemName;
    public float price;
    public Texture2D icon;
    public int itemID;
    public string type;


}


