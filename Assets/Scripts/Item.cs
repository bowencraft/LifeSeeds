using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Item {

    public enum ItemType
    {
        RoseSeed,
        SnakeBeautySeed,
        PeonySeed,
        LesbianSeed,
    }

    public ItemType itemType;
    public int amount;
}