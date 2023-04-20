using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.Serialization;

[System.Serializable]
public class Inventory : MonoBehaviour
{
    [SerializeField] List<string> items;
    [SerializeField] public float money;
    [HideInInspector] public int selectedItem;
    public List<string> GetItems()
    {
        return items;
    }

    public void RemoveItem(string itemToRemove)
    {
        items.Remove(itemToRemove);
    }

    public void AddItem(string itemToAdd)
    {
        items.Add(itemToAdd);
    }
}