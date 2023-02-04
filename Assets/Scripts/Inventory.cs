using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Inventory
{
    private List<Item> itemList;

    public Inventory()
    {
        itemList = new List<Item>();

        AddItem(new Item { itemType = Item.ItemType.RoseSeed, amount = 1 });
        AddItem(new Item { itemType = Item.ItemType.SnakeBeautySeed, amount = 1 });
        AddItem(new Item { itemType = Item.ItemType.PeonySeed, amount = 1 });
        AddItem(new Item { itemType = Item.ItemType.LesbianSeed, amount = 1 });
        Debug.Log(itemList.Count);
    }

    public void AddItem(Item item)
    {
            itemList.Add(item);
    }

    public void AddItemAmount(Item item)
    {
        foreach (Item inventoryItem in itemList)
        {
            inventoryItem.amount += item.amount;
        }
    }

    public List<Item> GetItemList()
    {
        return itemList;
    }
}
