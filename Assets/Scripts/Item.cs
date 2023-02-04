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

    public Sprite GetSprite()
    {
        switch (itemType)
        {
            default:
            case ItemType.LesbianSeed:     return SeedAssets.Instance.LesbianSeedSprite;
            case ItemType.RoseSeed:        return SeedAssets.Instance.RoseSeedSprite;
            case ItemType.PeonySeed:       return SeedAssets.Instance.PeonySeedSprite;
            case ItemType.SnakeBeautySeed: return SeedAssets.Instance.SnakeBeautySeedSprite;
        }
    }
}