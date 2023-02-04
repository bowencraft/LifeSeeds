using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Inventory
{
    private List<Item> itemList;

    public Inventory()
    {
        itemList = new List<Item>();

        AddItem(new Item { itemType = Item.ItemType.RoseSeed, amount = 0 });
        AddItem(new Item { itemType = Item.ItemType.SnakeBeautySeed, amount = 0 });
        AddItem(new Item { itemType = Item.ItemType.PeonySeed, amount = 0 });
        AddItem(new Item { itemType = Item.ItemType.LesbianSeed, amount = 0 });
        Debug.Log(itemList.Count);
    }

    public void AddItem(Item item)
    {
        //bool itemAlreadyInInventory = false;
        //foreach (Item inventoryItem in itemList)
        //{
        //    inventoryItem.amount += item.amount;
        //    itemAlreadyInInventory = true;
        //}
        //if (!itemAlreadyInInventory) {
            itemList.Add(item);
        //}
    }

    public List<Item> GetItemList()
    {
        return itemList;
    }
}
