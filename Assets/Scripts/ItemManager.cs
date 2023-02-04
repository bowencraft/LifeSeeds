using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ItemManager : MonoBehaviour
{
    private Inventory inventory;

    [SerializeField] private UI_Inventory uiInventory;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void Awake()
    {
        inventory = new Inventory();
        uiInventory.SetInventory(inventory);
    }
}
