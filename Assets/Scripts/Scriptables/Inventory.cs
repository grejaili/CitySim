using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.Serialization;

[System.Serializable]
public class Inventory : MonoBehaviour
{
    [SerializeField] List<string> items;
    [SerializeField] private float money;
    

    public List<string> GetItems()
    {
        return items;
    }

    private void RemoveItem(string itemToRemove)
    {
        items.Remove(itemToRemove);
    }

    private void AddItem(string itemToAdd)
    {
        items.Add(itemToAdd);
    }
}