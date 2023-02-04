using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SeedAssets : MonoBehaviour
{
    public static SeedAssets Instance { get; private set; }

    private void Awake()
    {
        Instance = this;
    }

    public Sprite RoseSeedSprite;
    public Sprite SnakeBeautySeedSprite;
    public Sprite PeonySeedSprite;
    public Sprite LesbianSeedSprite;
}
